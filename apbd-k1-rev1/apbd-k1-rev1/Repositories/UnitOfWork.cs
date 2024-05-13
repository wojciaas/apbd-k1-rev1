using System.Data.SqlClient;

namespace apbd_k1_rev1.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly SqlConnection _connection;

    public UnitOfWork(SqlConnection connection)
    {
        _connection = connection;
    }

    public void Dispose()
    {
        _connection.Dispose();
    }

    public ValueTask DisposeAsync()
    {
        _connection.Dispose();
        return ValueTask.CompletedTask;
    }

    public Task InitializeAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task CommitAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public SqlCommand CreateCommand()
    {
        return _connection.CreateCommand();
    }
}