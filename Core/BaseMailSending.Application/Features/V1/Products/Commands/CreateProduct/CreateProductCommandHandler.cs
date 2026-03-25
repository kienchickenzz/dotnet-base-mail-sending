namespace BaseMailSending.Application.Features.V1.Products.Commands.CreateProduct;

using BaseMailSending.Application.Common.Messaging;
using BaseMailSending.Application.Common.ApplicationServices.Persistence;
using BaseMailSending.Domain.AggregatesModels.Products;
using BaseMailSending.Domain.Common;


public sealed class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, int>
{
    private readonly IProductRepository _productRepository;
    public CreateProductCommandHandler(
        IProductRepository productRepository
    )
    {
        _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
    }

    public async Task<Result<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = Product.Create(
            request.Name,
            request.Description,
            request.Price);

        var result = await _productRepository.AddAsync(product);

        return result.Id;
    }
}
