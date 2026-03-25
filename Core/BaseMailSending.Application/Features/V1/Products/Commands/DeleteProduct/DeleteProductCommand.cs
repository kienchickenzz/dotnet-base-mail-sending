namespace BaseMailSending.Application.Features.V1.Products.Commands.DeleteProduct;

using BaseMailSending.Application.Common.Messaging;


public sealed record DeleteProductCommand(Guid Id) : ICommand<Guid>;
