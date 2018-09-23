using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int orderId { get; set; }
        public int productId { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
