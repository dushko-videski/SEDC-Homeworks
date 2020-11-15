using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace Disposing
{
    public class CustomWriter : IDisposable
    {

        private string path;
        private StreamWriter _sw;
        private bool disposedValue = false;//dali prethodno e povikan despose metodot, vo slucajot ne

        //CONSTRUCTOR:
        public CustomWriter(string filePath)
        {
            path = filePath;
            _sw = new StreamWriter(path, true);
        }
        //*****************************************
        // metod za pisuvanje vo file
        public void WriteInFile (string text)
        {
            _sw.WriteLine(text);
        }
        //******************************************
        // nas metod za despose, koj go povikuvame vo metodot podole implementiran od IDisposable
        private void _dispose()
        {
            if (!disposedValue)
            {
                _sw.Dispose();
                path = "";
                disposedValue = true;
            }
        }
        //*****************************************
        // od IDisposable implementirano avtomatski
        public void Dispose()
        {
            _dispose();
        }   
    }
}
