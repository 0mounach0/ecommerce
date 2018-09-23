using ecommerce.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Data.Models;

namespace ecommerce.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                    {
                    new Product
                    {
                        Name = "Iphone X",
                        Price = 7.95M,
                        ShortDescription = "The most powerful iphone",
                        LongDescription = "description loooooooooooooooong one",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://www.imore.com/sites/imore.com/files/styles/xlarge/public/field/image/2017/10/iphone-x-colors-apple-art.jpg?itok=3iCVeFc-",
                        InStock = true,
                        isPreferredProduct = true,
                        ImageThumbnailUrl = "https://www.imore.com/sites/imore.com/files/styles/xlarge/public/field/image/2017/10/iphone-x-colors-apple-art.jpg?itok=3iCVeFc-"
                    },
                    new Product
                    {
                        Name = "One+ 5t",
                        Price = 12.95M, ShortDescription = "One+ 5t.",
                        LongDescription = "One+ 5t",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "https://d2giyh01gjb6fi.cloudfront.net/default/0002/06/thumb_105796_default_big.jpeg",
                        InStock = true,
                        isPreferredProduct = false,
                        ImageThumbnailUrl = "https://d2giyh01gjb6fi.cloudfront.net/default/0002/06/thumb_105796_default_big.jpeg"
                    },
                    new Product
                    {
                        Name = "samsung s9+",
                        Price = 12.95M,
                        ShortDescription = "samsung s9+.",
                        LongDescription = "samsung s9+samsung s9+samsung s9+samsung s9+",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "http://asset-a.grid.id/crop/0x0:0x0/700x465/photo/2018/02/06/238350663.jpg",
                        InStock = true,
                        isPreferredProduct = false,
                        ImageThumbnailUrl = "http://asset-a.grid.id/crop/0x0:0x0/700x465/photo/2018/02/06/238350663.jpg"
                    }
                };
            }
        }


        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Product> PreferredProducts { get; }
       

        

        
    }
}
