using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDGT.eQuote.Model
{
    public class Tablet : ProductBase
    {
        public double ScreenSize { get; set; }
        public int ScreenResolution { get; set; }
        public bool FrontFaceCamera { get; set; }
        public bool RearCamera { get; set; }



        
    }
}
