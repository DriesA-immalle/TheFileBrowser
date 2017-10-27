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
            if (args.Length == 0)
            {
                Console.WriteLine("Geef een argument! Probeer '-h'");

                switch (args[0])
                {
                    case "-f":
                        FilesInDirectory();
                        break;
                    case "-c":
                        HuidigeDirectory();
                        break;
                    case "-d":
                        HuidigeSubdirectories();
                        break;
                    case "-h":
                        Hulp();
                        break;
                    default:
                        Console.WriteLine("Ongeldig argument! Probeer '-h'");
                        break;
                }
            }
        }
        static void FilesInDirectory()
        {
            Console.Write("Alle files in de huidige directory: ");
        }

        static void HuidigeDirectory()
        {
            Console.Write("De huidige directory: ");
        }

        static void HuidigeSubdirectories()
        {
            Console.Write("Alle huidige subdirectories: ");
        }

        static void Hulp()
        {
            Console.WriteLine("Hulp:");
        }
    }

}
