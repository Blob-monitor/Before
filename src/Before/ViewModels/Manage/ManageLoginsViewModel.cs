namespace Before.ViewModels.Manage
{
    using Microsoft.AspNet.Http.Authentication;
    using Microsoft.AspNet.Identity;
    using System.Collections.Generic;

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }
}