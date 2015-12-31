namespace Before.Models
{
    using Microsoft.Data.Entity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public partial class BeforeDataAccessEF7 : IBeforeDataAccess
    {
        IEnumerable<ApplicationUser> IBeforeDataAccess.Users
        {
            get
            {
                return _dbContext.Users
                    .Include(u => u.Claims)
                    .ToList();
            }
        }

        Task IBeforeDataAccess.AddUser(ApplicationUser value)
        {
            _dbContext.Users.Add(value);
            return _dbContext.SaveChangesAsync();
        }

        Task IBeforeDataAccess.DeleteUser(string userId)
        {
            var toDelete = _dbContext.Users.Where(u => u.Id == userId).SingleOrDefault();
            if (toDelete != null)
            {
                _dbContext.Users.Remove(toDelete);
                return _dbContext.SaveChangesAsync();
            }
            return null;
        }

        ApplicationUser IBeforeDataAccess.GetUser(string userId)
        {
            return _dbContext.Users
                .Where(u => u.Id == userId)
                .Include(u => u.Claims)
                .SingleOrDefault();
        }

        Task IBeforeDataAccess.UpdateUser(ApplicationUser value)
        {
            _dbContext.Users.Update(value);
            return _dbContext.SaveChangesAsync();
        }
    }
}