//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Bozor.Web.Models.Foundations.Product;

namespace Bozor.Web.Services.Foundations.Products
{
    public interface IProductService
    {
        ValueTask<Product> AddProductAsync(Product product);
        ValueTask<IQueryable<Product>> RetrieveAllProductsAsync();
    }
}
