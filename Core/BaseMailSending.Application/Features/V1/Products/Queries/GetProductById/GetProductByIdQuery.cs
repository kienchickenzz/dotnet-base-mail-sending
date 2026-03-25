namespace BaseMailSending.Application.Features.V1.Products.Queries.GetProductById;

using BaseMailSending.Application.Common.Messaging;
using BaseMailSending.Application.Features.V1.Products.Models;


public sealed record GetProductByIdQuery(Guid Id) : IQuery<ProductResponse>;
