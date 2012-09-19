using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDGT.eQuote.Model
{
    public class eReader : ProductBase
    {
        public bool PDFReady { get; set; }
        public bool WithBackLight { get; set; }
        public double ScreenSize { get; set; }
        public int ScreenResolution { get; set; }


       
    }
}
