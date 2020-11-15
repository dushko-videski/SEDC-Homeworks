using System;
using System.IO;


namespace Class12.Exercise.Services
{
    public static class LogerService
    {

        //METODA ZA CITANJE I PRINTANJE VO KONSOLA
        public static void ReadAndWriteInConsole(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }

        //METODA ZA ZAPISUVANJE NA JSON VO FILE
        public static void WriteJsonInFile(string filePath, string directoryPath, string json)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(json);
            }
        }






    }
}
