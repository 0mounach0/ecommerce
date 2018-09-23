using ecommerce.Data.Interfaces;
using ecommerce.Data.Models;
using ecommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Controllers
{
    public class ProductController :Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.Products.OrderBy(n => n.ProductId);
                currentCategory = "All products";
            }
            else
            {
                if (string.Equals("Phone", _category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _productRepository.Products.Where(p => p.Category.CategoryName.Equals("Phone")).OrderBy(n => n.Name);
                }else if(string.Equals("Tablet", _category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _productRepository.Products.Where(p => p.Category.CategoryName.Equals("Tablet")).OrderBy(n => n.Name);
                }
                else if (string.Equals("Pc", _category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _productRepository.Products.Where(p => p.Category.CategoryName.Equals("Pc")).OrderBy(n => n.Name);
                }
                else if (string.Equals("Television", _category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _productRepository.Products.Where(p => p.Category.CategoryName.Equals("Television")).OrderBy(n => n.Name);
                }
                else
                {
                    products = _productRepository.Products.OrderBy(n => n.ProductId);
                    _category = "All products";
                }

                currentCategory = _category;

            }
            var productListViewModel = new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            };

            return View(productListViewModel);
        }

        //
        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Product> products;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductId);
            }
            else
            {
                products = _productRepository.Products.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Product/List.cshtml", new ProductListViewModel { Products = products, CurrentCategory = "All products" });
        }
        //
        public ViewResult Details(int productId)
        {
            var product = _productRepository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(product);
        }

        //


    }
}
