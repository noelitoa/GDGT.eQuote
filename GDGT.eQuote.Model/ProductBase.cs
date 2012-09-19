using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDGT.eQuote.Model
{
    public abstract class ProductBase
    {
         public int Id { get; set; }
         public string Name { get; set; }
         public double Price { get; set; }


    }
}
