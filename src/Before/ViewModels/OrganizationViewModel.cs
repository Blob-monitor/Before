namespace Before.ViewModels
{
    using Models;
    using System;

    public class OrganizationViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public OrganizationViewModel(Organization organization)
        {
            Id = organization.Id;
            Name = organization.Name;
        }
    }
}