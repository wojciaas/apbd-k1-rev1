using System.Data.SqlClient;

namespace apbd_k1_rev1.Repositories;

public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    Task InitializeAsync(CancellationToken cancellationToken);
    Task CommitAsync(CancellationToken cancellationToken);
    SqlCommand CreateCommand();
}