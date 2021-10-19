using SingleResponsibilityPrinciple.helper;
using SingleResponsibilityPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace SingleResponsibilityPrinciple.Classes
{
    public class FileSize:IFileSize
    {
        public int getFileSize(string path)
        {
            int fileSize = 0;
            try
            {
                FileDetails obj = new FileDetails();
                fileSize = obj.Size(path);
                
            }
            catch(Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
            }
            return fileSize;
        }
    }
}
