using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repository) {
            _repository = repository;
        }

        public ViewResult List(int page = 1) => 
            View(_repository.Products.OrderBy(p => p.ProductID)
                .Skip((page - 1) * PageSize).Take(PageSize));
    }
}