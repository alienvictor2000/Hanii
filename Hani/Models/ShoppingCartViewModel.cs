using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hani.Models
{
    [Serializable]
    public class ShoppingCartViewModel
    {
        public int ProductId { set; get; }
        public Product Product{set; get;}
        public int Quantity { set; get; }
    }
}
