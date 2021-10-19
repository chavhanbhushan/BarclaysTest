using SingleResponsibilityPrinciple;
using SingleResponsibilityPrinciple.Classes;
using SingleResponsibilityPrinciple.helper;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FileData
{
    public static class Program
    {
       static string[] fileVersionParameter = {"-v", "--v", "/v", "--version"};
        static string[] fileSizeParameter = { "-s", "--s", "/s", "--size" };
        public static void Main(string[] args)
        {
            try
            {
                // Single Responsibility Principle
                FileOperation obj = new FileOperation(new FileVersion(), new FileSize());
                if (Array.Exists(fileVersionParameter, element => element == args[0].ToString()))
                {
                    Console.WriteLine($"The File Version Is {obj.getFileVersion(args[1].ToString())}");
                }
                if (Array.Exists(fileSizeParameter, element => element == args[0].ToString()))
                {
                    Console.WriteLine($"The File Version Is {obj.getFileSize(args[1].ToString())}");
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
            }
        }
    }
}
