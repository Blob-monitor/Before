namespace Before.Controllers
{
    using Microsoft.AspNet.Mvc;
    using Models;
    using System;
    using System.Linq;
    using ViewModels;

    public class OrganizationController : Controller
    {
        IBeforeDataAccess _dataAccess;

        public OrganizationController(IBeforeDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [Route("Organizations/")]
        public IActionResult Index()
        {
            return View(_dataAccess.Organziations.Select(t => new OrganizationViewModel(t)).ToList());
        }

        [Route("Organization/{id}/")]
        public IActionResult ShowOrganization(int id)
        {
            var organization = _dataAccess.GetOrganization(id);

            if (organization == null)
            {
                return HttpNotFound();
            }

            return View("Organization", new OrganizationViewModel(organization));
        }
    }
}