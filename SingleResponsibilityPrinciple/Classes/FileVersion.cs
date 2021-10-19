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
    public class FileVersion : IFileVersion
    {
        public string getFileVersion(string path)
        {
            string version = "";
            try
            {
                FileDetails obj = new FileDetails();
                version = obj.Version(path);
                
            }
            catch(Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
            }
            return version;
        }
    }
}
