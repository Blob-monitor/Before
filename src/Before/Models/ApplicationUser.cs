namespace Before.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;

    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}