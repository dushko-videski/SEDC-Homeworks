using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Disposing
{
    public class CustomReader : IDisposable
    {
        private string _path;
        private StreamReader _sr;
        private bool disposedValue = false; //dali prethodno e povikan despose metodot, vo slucajot ne
        //CONSTRUCTOR
        public CustomReader(string filePath)
        {
            _path = filePath;
            _sr = new StreamReader(_path);
        }
        //***************************************
        //metoda za citanje od file
        public void ReadInFile()
        {
            Console.WriteLine(_sr.ReadToEnd());
        }
        //******************************************
        // nas metod za despose, koj go povikuvame vo metodot podole implementiran od IDisposable
        private void _dispose()
        {
            if (!disposedValue)
            {
                _sr.Dispose();
                _path = "";
                disposedValue = true;
            }
        }
        //*****************************
        //metoda od IDisposable
        public void Dispose()
        {
            _dispose();
        }
    }
}
