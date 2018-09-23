using ecommerce.Data.Interfaces;
using ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Data.Mocks
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> Categories {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Phone", Description = "All Mobile Phones" },
                    new Category { CategoryName = "Tv", Description = "All Televisions" }
                };
            }
                
                }
    }
}
