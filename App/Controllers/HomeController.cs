using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using OnionArchitecture.Services.Interfaces;
using OnionArchitecture.Domain.Interfaces;
using OnionArchitecture.Domain.Core;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _productRepository;
        private IOrderService _orderService;

        public HomeController(IProductRepository productRepository, IOrderService orderService)
        {
            _productRepository = productRepository;
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.ListAsync();
            return View();
        }

        //!!! Do not do that. Do not call order service with GET Method
        [HttpGet]
        public async Task<IActionResult> Buy(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _orderService.Order(product);
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
