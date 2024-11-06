//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Bozor.Web.Brokers.Storages;
using Bozor.Web.Models;
using Bozor.Web.Models.Foundations.Product;
using Bozor.Web.Services.Foundations.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace Bozor.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService) =>
            this.productService = productService;

        public IActionResult AddProduct() => View();

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

        public async Task<IActionResult> Edit(int id)
        {
            var product = await productService.RetrieveProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                product.CreatedDate = DateTimeOffset.Now;
                await productService.ModifyProductAsync(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmRemoveProduct(int id)
        {
            Product remoneProduct = await productService.RetrieveProductByIdAsync(id);

            if (remoneProduct != null)
            {
                return View(remoneProduct);
            }
            ModelState.AddModelError(string.Empty, "Product not found.");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveProduct(int id)
        {
            var result = await this.productService.RemoveProductAsync(id);

            if (result != null)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Unable to delete the house. Please try again.");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Index()
        {
            var products = await productService.RetrieveAllProductsAsync();
            return View(products);
        }

        public IActionResult Privacy()=>View();
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
