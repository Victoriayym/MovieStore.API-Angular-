using MovieStore.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieStore.Core.RepositoryInterfaces
{
    public interface IPurchaseRepository: IAsyncRepository<Purchase>
    {
       //public Task<IEnumerable<Purchase>> Purchase(int MovieId);
    }

}
