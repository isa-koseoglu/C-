using EchoposCRUD.Classes;
using EchoposCRUD.Context;
using EchoposCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EchoposCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Product> _repository;
        private readonly CrudContext context;

        public HomeController(ILogger<HomeController> logger, CrudContext context)
        {
            _logger = logger;
            _repository = new Repository(context);
        }

        public IActionResult Index()
        {
            var list=_repository.GetAll().Result;
            return View(list);
        }

        public async Task<IActionResult>Created(Product product)
        {
            if (product.ID == 0)
            {
                product.createdDate = DateTime.Now;
                
                var result = await _repository.Add(product);
                if (result != null)
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                product.updatedDate = DateTime.Now;
                var result=await _repository.Update(product);
                if (result != null)
                {
                    return RedirectToAction("Index");
                }
            }
           
            return RedirectToAction("Product");
        }
       
        public IActionResult Product(int? id)
        {
            Product product;
            if (id.HasValue)
            {
                product = _repository.Get(id.Value).Result;
                if (product is null)
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                product = new Product();
            }
            
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
