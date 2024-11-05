//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using System.Diagnostics;
using Bozor.Web.Models;
using Bozor.Web.Models.Foundations.Product;
using Bozor.Web.Services.Foundations.Products;
using Microsoft.AspNetCore.Mvc;

namespace Bozor.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)=>
            this.productService = productService;
        
        public IActionResult AddProduct()=>View();
        
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                product.CreatedDate = DateTimeOffset.Now;
              this.productService.AddProductAsync(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public async Task<IActionResult> Index()
        {
            var products = await productService.RetrieveAllProductsAsync();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
