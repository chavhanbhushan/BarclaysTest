﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Interfaces
{
    public interface IFileVersion
    {
        string getFileVersion(string path);
    }
}
