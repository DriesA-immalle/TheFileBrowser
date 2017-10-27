using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheFileBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args[0])
            {
                case "-f":
                    Console.Write("Alle files in de huidige directory: ");
                    break;
                case "-c":
                    Console.Write("De huidige directory: ");
                    break;
                case "-d":
                    Console.Write("Alle huidige subdirectories: ");
                    break;
                case "-h":
                    Console.WriteLine("Hulp:");
                    break;
                default:
                    Console.WriteLine("Ongeldig argument! Probeer '-h'");
                    break;
            }
        }
        static void FilesInDirectory()
        {

        }

        static void HuidigeDirectory()
        {

        }

        static void HuidigeSubdirectories()
        {

        }

        static void Hulp()
        {

        }
    }

}
