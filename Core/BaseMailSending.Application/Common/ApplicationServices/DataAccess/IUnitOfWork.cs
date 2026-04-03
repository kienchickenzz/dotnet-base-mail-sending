namespace BaseMailSending.Application.Common.ApplicationServices.DataAccess;

public interface IUnitOfWork : IAsyncDisposable
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
