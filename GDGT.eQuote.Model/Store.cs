using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDGT.eQuote.Model
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public List<ProductBase> Products { get; set; }

    }
}
