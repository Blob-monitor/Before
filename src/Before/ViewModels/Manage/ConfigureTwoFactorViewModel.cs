namespace Before.ViewModels.Manage
{
    using Microsoft.AspNet.Mvc.Rendering;
    using System.Collections.Generic;

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }
    }
}