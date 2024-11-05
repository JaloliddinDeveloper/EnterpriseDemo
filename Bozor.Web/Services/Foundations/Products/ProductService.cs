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
    }
}
