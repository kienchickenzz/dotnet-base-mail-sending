namespace BaseMailSending.Application.Features.V1.Products.Queries.GetProducts;

using BaseMailSending.Application.Common.Messaging;
using BaseMailSending.Application.Common.Models;
using BaseMailSending.Application.Features.V1.Products.Models;


public sealed class GetProductsQuery : PaginationFilter, IQuery<PaginationResponse<ProductResponse>>
{
}
