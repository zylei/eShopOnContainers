using Microsoft.eShopOnContainers.Services.Ordering.Domain.Seedwork;
using System.Threading.Tasks;

namespace Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.BuyerAggregate
{
    //This is just the RepositoryContracts or Interface defined at the Domain Layer
    //as requisite for the Buyer Aggregate

    /// <summary>
    /// A better way to have the code enforce the convention that each repository is related to a single aggregate is to implement a generic repository type. That way,
    /// it's explicit that you're using a repository to target a specific aggregate. That can be easily done by implementing a generic IRepository base interface
    /// </summary>
    public interface IBuyerRepository : IRepository<Buyer>
    {
        Buyer Add(Buyer buyer);
        Buyer Update(Buyer buyer);
        Task<Buyer> FindAsync(string BuyerIdentityGuid);
        Task<Buyer> FindByIdAsync(string id);
    }
}
