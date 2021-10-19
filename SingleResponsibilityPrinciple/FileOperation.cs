using SingleResponsibilityPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class FileOperation
    {
        private readonly IFileVersion _fileVersion;
        private readonly IFileSize _fileSize;

        public FileOperation(IFileVersion fileVersion, IFileSize fileSize)
        {
            _fileVersion = fileVersion;
            _fileSize = fileSize;
        }

        public string getFileVersion(string path)
        {
           return _fileVersion.getFileVersion(path);
        }

        public int getFileSize(string path)
        {
            return _fileSize.getFileSize(path);
        }
    }
}
