using BookHub.DataAccess.Repository.IRepository;
using BookHub.Models;
using BookHub.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookHub.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class GenreController : Controller
    {

        private readonly ILogger<GenreController> _logger;
        private readonly IUnitOfWork _unitofWork;
        public GenreController(ILogger<GenreController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitofWork = unitOfWork;
        }

        public IActionResult PersonalDevelopment()
        {
            IEnumerable<Product> productList = _unitofWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
        }
        public IActionResult Biographies()
        {
            IEnumerable<Product> productList = _unitofWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
        }
        public IActionResult CrimeThriller()
        {
            IEnumerable<Product> productList = _unitofWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
        }
        public IActionResult LiteratureFiction()
        {
            IEnumerable<Product> productList = _unitofWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
        }
        public IActionResult Romance()
        {
            IEnumerable<Product> productList = _unitofWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
        }
        public IActionResult BusinessEconomics()
        {
            IEnumerable<Product> productList = _unitofWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
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
