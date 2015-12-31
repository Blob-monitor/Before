namespace Before.Models
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBeforeDataAccess
    {
        #region Organization CRUD

        IEnumerable<Organization> Organziations { get; }
        Task AddOrganization(Organization organization);
        Task DeleteOrganization(int organizationId);
        Organization GetOrganization(int organizationId);
        Task UpdateOrganization(Organization organization);

        #endregion


        #region User CRUD

        IEnumerable<ApplicationUser> Users { get; }
        Task AddUser(ApplicationUser user);
        Task DeleteUser(string userId);
        ApplicationUser GetUser(string userId);
        Task UpdateUser(ApplicationUser user);

        #endregion
    }
}