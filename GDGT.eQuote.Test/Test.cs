using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GDGT.eQuote.Model;

namespace GDGT.eQuote.Test
{
    [TestFixture]
    class Test
    {
        [Test]
        public void TestModel()
        {
            Tablet tablet = new Tablet { Id = 1 };
            eReader eReader = new eReader { Id = 1 };

            Assert.AreEqual(1, tablet.Id);

            
        }

    }
}
