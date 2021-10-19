using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingleResponsibilityPrinciple.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Classes.Tests
{
    [TestClass()]
    public class FileVersionTests
    {
        [TestMethod()]
        public void getFileVersionTest()
        {
            FileVersion fv = new FileVersion();
            var res = fv.getFileVersion("");
            Assert.IsNotNull(res);
        }
    }
}