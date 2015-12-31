namespace Before.Models
{
    using System.Collections.Generic;

    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Application users which are members of this Organization.
        /// Users may be members of more than one organization.
        /// </summary>
        public List<ApplicationUser> Users { get; set; }
    }
}