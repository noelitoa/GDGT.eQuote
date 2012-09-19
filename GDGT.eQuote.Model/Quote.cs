using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDGT.eQuote.Model
{
    public class Quote
    {
        public int Id { get; set; }
        public DateTime QuoteDateTime { get; set; }
        public double Total { get; set; }
    }
}
