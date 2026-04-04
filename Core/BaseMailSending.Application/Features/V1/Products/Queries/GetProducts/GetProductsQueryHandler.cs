/**
 * Handler for GetProductsQuery - retrieves paginated list of products.
 *
 * <p>Uses LINQ extensions for filtering, sorting, and pagination
 * instead of Specification pattern.</p>
 */
namespace BaseMailSending.Application.Features.V1.Products.Queries.GetProducts;

using BaseMailSending.Application.Common.ApplicationServices.Repositories;
using BaseMailSending.Application.Common.Extensions;
using BaseMailSending.Application.Common.Messaging;
using BaseMailSending.Application.Common.Models;
using BaseMailSending.Application.Features.V1.Products.Extensions;
using BaseMailSending.Application.Features.V1.Products.Models;
using BaseMailSending.Domain.Common;


public sealed class GetProductsQueryHandler : IQueryHandler<GetProductsQuery, PaginationResponse<ProductResponse>>
{
    private readonly IProductRepository _productRepository;

    public GetProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
    }

    public async Task<Result<PaginationResponse<ProductResponse>>> Handle(
        GetProductsQuery request,
        CancellationToken cancellationToken)
    {
        var result = await _productRepository.Query
            .WhereKeywordMatches(request.Keyword)
            .OrderByNewest()
            .SelectAsResponse()
            .ToPaginatedListAsync(
                request.PageNumber,
                request.PageSize,
                cancellationToken);

        return Result.Success(result);
    }
}
