using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStores.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
