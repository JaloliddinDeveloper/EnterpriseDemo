//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Bozor.Web.Models.Foundations.Product;

namespace Bozor.Web.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Product> InsertProductAsync(Product product);
        ValueTask<IQueryable<Product>> SelectAllProductsAsync();
        ValueTask<Product> SelectProductByIdAsync(int id);
        ValueTask<Product> UpdateProductAsync(Product product);
        ValueTask<Product> DeleteProductAsync(Product product);
    }
}
