using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIexercieses.Models
{
    [Table("orderdetail")]
    public class orderdetail
    {
        [Key]
        public int orderDetailId { get; set; }
        public int orderId { get; set; }
        public int productId { get; set; }
        public decimal unitPrice { get; set; }
        public int quantity { get; set; }
        public decimal discount { get; set; }
    }
}
