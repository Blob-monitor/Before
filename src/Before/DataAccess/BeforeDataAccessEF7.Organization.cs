namespace Before.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public partial class BeforeDataAccessEF7 : IBeforeDataAccess
    {
        public IEnumerable<Organization> Organziations
        {
            get
            {
                return _dbContext.Organizations.ToList();
            }
        }

        public Task AddOrganization(Organization newOrganization)
        {
            _dbContext.Organizations.Add(newOrganization);
            return _dbContext.SaveChangesAsync();
        }

        public Task DeleteOrganization(int organizationId)
        {
            var organization = _dbContext.Organizations.SingleOrDefault(c => c.Id == organizationId);

            if (organization != null)
            {
                _dbContext.Organizations.Remove(organization);
                return _dbContext.SaveChangesAsync();
            }
            return null;
        }

        Organization IBeforeDataAccess.GetOrganization(int organizationId)
        {
            return _dbContext.Organizations.SingleOrDefault(t => t.Id == organizationId);
        }

        public Task UpdateOrganization(Organization newOrganization)
        {
            var organization = _dbContext.Organizations.SingleOrDefault(c => c.Id == newOrganization.Id);

            if (organization != null)
            {
                _dbContext.Organizations.Update(organization);
                return _dbContext.SaveChangesAsync();
            }
            return null;
        }
    }
}
