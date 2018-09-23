using ecommerce.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Data.Models;

namespace ecommerce.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContect;
        public CategoryRepository(AppDbContext appDbContect)
        {
            _appDbContect = appDbContect;
        }

        public IEnumerable<Category> Categories => _appDbContect.Categories;
    }
}
