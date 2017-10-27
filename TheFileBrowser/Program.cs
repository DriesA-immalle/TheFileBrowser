using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TheFileBrowser
{
    class Program
    {
        
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Geef een argument! Probeer '-h'");
            }
            else
            {
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
            Console.WriteLine("Alle files in de huidige directory: ");
            Console.WriteLine("");
            string[] dirs = Directory.GetFiles(Environment.CurrentDirectory);
            foreach (string dir in dirs)
            {
                Console.WriteLine(Path.GetFileName(dir));
            }
        }
        
        static void HuidigeDirectory()
        {
            Console.Write("De huidige directory: " + Environment.CurrentDirectory);
        }

        static void HuidigeSubdirectories()
        {
            Console.Write("Alle huidige subdirectories: ");
            Console.WriteLine("");
            
        }

        static void Hulp()
        {
            Console.WriteLine("Hulp:");
            Console.WriteLine("De volgende argumenten zijn mogelijk:");
            Console.WriteLine("-f toont alle files in de huidige directory.");
            Console.WriteLine("-c toont de huidige directory.");
            Console.WriteLine("-d toont alle subdirectories van de huidige directory.");
            Console.WriteLine("-h toont alle mogelijke arguments.");
        }
    }

}
