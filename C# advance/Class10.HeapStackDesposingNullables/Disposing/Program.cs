using Microsoft.Win32.SafeHandles;
using System;
using System.IO;

namespace Disposing
{

    class Program
    {
        //PATEKI ZA FOLDEROT I ZA FAJLOT:
        public static string AppPath = $@"..\..\..\Text";
        public static string FilePath = AppPath + $@"\text.txt";
        //****************************************************************
        //METOD ZA KREIRANJE FOLDER:
        public static void CreateFolder (string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path); // ovde ne treba da se zatvori patekata
            }
        }
        //METOD ZA KREIRANJE FILE:
        public static void CreateFile (string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close(); // ovde mora da se zatvori fajot, patekata
            }
        }
        //***************************************************************
        //METOD ZA PISUVANJE VO FILE:
        public static void WriteTextInFile(string text, string path)
        {
            using (var sw = new StreamWriter(path, true)) // "var sw" --> moze ili var ili StreamWriter sw
            {
                sw.WriteLine(text);
            }
        }
        //METOD ZA PISUVANJE VO FILE - manuelno:
        public static void WriteTextInFileManual (string text, string path)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(text);
            //sw.Close(); //samo ja zatvora konekcijata
            sw.Dispose(); //zatvara konekcija i brise od memorija ---> close() + brisenje od memorija (go sodrzi i Close())
        }
        //METOD ZA CITANJE OD FILE:
        public static void ReadTextFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        //METOD ZA CITANJE VO FILE - manuelno:
        public static void ReadTextInFileManual(string path)
        {
            StreamReader sr = new StreamReader(path);
            Console.WriteLine(sr.ReadToEnd());
            sr.Dispose(); //zatvara konekcija i brise od memorija ---> close() + brisenje od memorija (go sodrzi i Close())
        }
        //***************************************************************
        //CUSTOM METODA ZA PISUVANJE VO FAJK SO CUSTOM StreamWriter
        public static void WriteTextInFileOurImplementation(string text, string path)
        {
            using (var ow = new CustomWriter(path))
            {
                ow.WriteInFile(text);
            }
        }
        //CUSTOM METODA ZA CITANJE VO FAJK SO CUSTOM StreamReader
        public static void ReadTextInFileOurImplementation(string path)
        {
            using (CustomReader or = new CustomReader(path))
            {
                or.ReadInFile();
            }
        }
       //***************************************************************
        //METOD za input na text od user sto sakame da se zapise vo file
        public static void WriteAndReadInFile()
        {
            try
            {
                Console.WriteLine("Please enter text for pt1:");
                string text1 = Console.ReadLine();
                //WriteTextInFile(text1, FilePath);
                //WriteTextInFileManual(text1, FilePath);
                WriteTextInFileOurImplementation(text1, FilePath);

                Console.WriteLine("Please enter text for pt2:");
                string text2 = Console.ReadLine();
                //WriteTextInFile(text2, FilePath);
                //WriteTextInFileManual(text2, FilePath);
                WriteTextInFileOurImplementation(text2, FilePath);

                Console.WriteLine("Please enter text for pt3:");
                string text3 = Console.ReadLine();
                //WriteTextInFile(text3, FilePath);
                //WriteTextInFileManual(text3, FilePath);
                WriteTextInFileOurImplementation(text3, FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem in writing the file");
                Console.WriteLine(ex.Message);
            }

            Console.Clear();
            Console.WriteLine("----------- You entered: -----------");

            try
            {
                //ReadTextFromFile(FilePath);
                //ReadTextInFileManual(FilePath);
                ReadTextInFileOurImplementation(FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem in reading the file");
                Console.WriteLine(ex.Message);
            }
        }
        //MAIN METHOD #################################################
        static void Main(string[] args)
        {

            CreateFolder(AppPath);
            CreateFile(FilePath);

            WriteAndReadInFile();

            Console.ReadLine();
        }

    }
}
