namespace Before.Models
{
    public partial class BeforeDataAccessEF7 : IBeforeDataAccess
    {
        private readonly BeforeContext _dbContext;

        public BeforeDataAccessEF7(BeforeContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}