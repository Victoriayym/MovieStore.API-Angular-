using MovieStore.Core.Entities;
using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Infrastructure.Data;


namespace MovieStore.Infrastructure.Repositories
{
    public class PurchaseRepository : ERepository<Purchase>, IPurchaseRepository
    {

        public PurchaseRepository(MovieStoreDbContext dbContext) : base(dbContext)
        {

        }

    }
}
