using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStores.Models;
using SportStores.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportStores.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductsController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category, int productPage = 1)
           => View(new ProductsListViewModel
           { Products = repository.Products
               .Where(p => category == null || p.Category == category)
               .OrderBy(p => p.ProductID)
               .Skip((productPage - 1) * PageSize).Take(PageSize),
               PagingInfo = new PagingInfo { CurrentPage = productPage, ItemsPerPage = PageSize,
                        TotalItems = category == null ? repository.Products.Count() : repository.Products.Where(e => e.Category == category).Count() },
               CurrentCategory = category
           });
            

    }
}
