//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Bozor.Web.Brokers.Storages;
using Bozor.Web.Models.Foundations.Product;

namespace Bozor.Web.Services.Foundations.Products
{
    public class ProductService : IProductService
    {
        private readonly IStorageBroker storageBroker;

        public ProductService(IStorageBroker storageBroker) =>
           this.storageBroker = storageBroker;

        public async ValueTask<Product> AddProductAsync(Product product) =>
            await this.storageBroker.InsertProductAsync(product);

        public async ValueTask<IQueryable<Product>> RetrieveAllProductsAsync() =>
            await this.storageBroker.SelectAllProductsAsync();

        public async ValueTask<Product> RetrieveProductByIdAsync(int productId)=>
            await this.storageBroker.SelectProductByIdAsync(productId);
       
        public async ValueTask<Product> ModifyProductAsync(Product product)=>
            await this.storageBroker.UpdateProductAsync(product);
       
        public async ValueTask<Product> RemoveProductAsync(int productId)
        {
            Product maybeProduct = await this.storageBroker
                .SelectProductByIdAsync(productId);

            return await this.storageBroker.DeleteProductAsync(maybeProduct);
        }
    }
}
