using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIexercieses.Models
{
    [Table("shipper")]
    public class shipper
    {
        [Key]
        public int shipperId { get; set; }
        public string companyName { get; set; }
        public string phone { get; set; }
    }
}
