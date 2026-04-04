/**
 * Repository implementation for Product aggregate.
 *
 * <p>Inherits all CRUD operations from base Repository.
 * Add domain-specific query methods here if needed.</p>
 */
namespace BaseMailSending.Persistence.Repositories;

using BaseMailSending.Application.Common.ApplicationServices.Repositories;
using BaseMailSending.Domain.AggregatesModels.Products;
using BaseMailSending.Persistence.Common;
using BaseMailSending.Persistence.DatabaseContext;


public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
