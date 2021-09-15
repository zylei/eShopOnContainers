using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.eShopOnContainers.Services.Ordering.Domain.Seedwork
{
    /// <summary>
    /// A unit of work is referred to as a single transaction that involves multiple insert, update, or delete operations.
    /// In simple terms, it means that for a specific user action, such as a registration on a website, all the insert, update,
    /// and delete operations are handled in a single transaction. This is more efficient than handling multiple database transactions in a chattier way.
    /// 
    /// These multiple persistence operations are performed later in a single action when your code from the application layer commands it.
    /// The decision about applying the in-memory changes to the actual database storage is typically based on the Unit of Work pattern.
    /// In EF, the Unit of Work pattern is implemented as the DbContext.
    /// 
    /// In many cases, this pattern or way of applying operations against the storage can increase application performance and reduce the
    /// possibility of inconsistencies.It also reduces transaction blocking in the database tables, because all the intended operations are
    /// committed as part of one transaction. This is more efficient in comparison to executing many isolated operations against the database.
    /// Therefore, the selected ORM can optimize the execution against the database by grouping several update actions within the same transaction,
    /// as opposed to many small and separate transaction executions.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
