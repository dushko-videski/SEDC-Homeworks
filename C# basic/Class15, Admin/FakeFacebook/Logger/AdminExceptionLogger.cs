using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FakeFacebook.Loger
{
    public class AdminExceptionLogger
    {
        private string FilePath { get; set; } = 
            @"C:\Users\dushk\OneDrive\Desktop\SEAVUS\C# Basic\Last-Homeworks\Class15, Admin\ExceptionLogger.txt";

        public void ExceptionLogger (Exception ex)
        {
            var sw = new StreamWriter(FilePath);

            sw.WriteLine($"Name:{ex.GetType().Name}; Message:{ex.Message}; Trace:{ex.StackTrace}");

            sw.Close();
        }
    }
}
