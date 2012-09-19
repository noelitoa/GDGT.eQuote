using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDGT.eQuote.Model
{
    public class Customer
    {
        // Primitive Properties
        public Customer()
        {
            Quotations = new HashSet<Quote>();
        }


        //Navigation Properties
        public ICollection<Quote> Quotations { get; set; }


    }
}
