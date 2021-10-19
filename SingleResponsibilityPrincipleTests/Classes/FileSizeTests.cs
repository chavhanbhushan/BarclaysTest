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
    public class FileSizeTests
    {
        [TestMethod()]
        public void getFileSizeTest()
        {

            FileSize fs = new FileSize();
            var res = fs.getFileSize("");
            Assert.IsNotNull(res);
        }
    }
}