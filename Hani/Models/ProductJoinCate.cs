using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hani.Models
{
    public class ProductJoinCate
    {
        [Key]
        public int Id { get; set; }
        public int PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string CATE_NAME { get; set; }
        public int PRODUCT_PRICE { get; set; }
        public string PRODUCT_AVATAR { get; set; }
        public string PRODUCT_SLUG { get; set; }
        public string PRODUCT_DES { get; set; }
    }
}
