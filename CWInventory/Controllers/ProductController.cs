﻿using CWInventory.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CWInventory.Controllers
{
    public class ProductController : BaseController
    {
        private IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await productService.AllProducts();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ProductQuantity(int id)
        {
            var model = await productService.GetQuantityInStorages(id);

            return View(model);
        }
    }
}
