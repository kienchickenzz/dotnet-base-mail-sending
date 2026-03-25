namespace BaseMailSending.Domain.AggregatesModels.Products;

using BaseMailSending.Domain.Common;


public static class ProductErrors
{
    public static Error NotFound = new(
        "Product.NotFound",
        "Product not found!");
}
