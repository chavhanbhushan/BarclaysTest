using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SingleResponsibilityPrinciple;
using SingleResponsibilityPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Tests
{
    [TestClass()]
    public class FileOperationTests
    {
        [TestMethod()]
        public void getFileVersionTest()
        {
            Mock<IFileVersion> fv = new Mock<IFileVersion>();
            Mock<IFileSize> fs = new Mock<IFileSize>();
            fv.Setup(x => x.getFileVersion("")).Returns("3.2.1");
            FileOperation fo = new FileOperation(fv.Object,fs.Object);
            var res = fo.getFileVersion("");
            Assert.IsNotNull(res);
        }

        [TestMethod()]
        public void getFileSizeTest()
        {
            Mock<IFileVersion> fv = new Mock<IFileVersion>();
            Mock<IFileSize> fs = new Mock<IFileSize>();
            fs.Setup(x => x.getFileSize("")).Returns(10);
            FileOperation fo = new FileOperation(fv.Object, fs.Object);
            var res = fo.getFileSize("");
            Assert.IsNotNull(res);
        }
    }
}