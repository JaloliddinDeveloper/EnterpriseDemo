//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Bozor.Web.Models.Foundations.Product;
using Microsoft.EntityFrameworkCore;

namespace Bozor.Web.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Product> Products { get; set; }

        public async ValueTask<Product> InsertProductAsync(Product product)=>
            await InsertAsync(product);
       
        public async ValueTask<IQueryable<Product>> SelectAllProductsAsync()=>
            await SelectAllAsync<Product>();
       
        public async ValueTask<Product> SelectProductByIdAsync(int id)=>
            await SelectByIdAsync<Product>(id);
      
        public async ValueTask<Product> UpdateProductAsync(Product product)=>
            await UpdateAsync(product);
       
        public async ValueTask<Product> DeleteProductAsync(Product product)=>
            await DeleteAsync(product);
    }
}
