namespace Microsoft.eShopOnContainers.Services.Ordering.Domain.Seedwork
{
    /// <summary>
    /// A better way to have the code enforce the convention that each repository is related to a single aggregate is to implement a generic repository type. That way,
    /// it's explicit that you're using a repository to target a specific aggregate. That can be easily done by implementing a generic IRepository base interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
