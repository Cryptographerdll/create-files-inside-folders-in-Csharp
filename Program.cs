using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;


namespace WriteFile_Fichier
{
    class Program
    {
        // How To create A file inside folder and edit it by writing text inside it .
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Folder has Allready exist .
            string fichier = path + Path.DirectorySeparatorChar + "Fichier" + Path.DirectorySeparatorChar + "khalil.txt";

            if(!File.Exists(fichier))
            {
                string txt = "Welcome to khalil world " + Environment.NewLine;
                File.WriteAllText(fichier, txt);
            }
            else
            {
                string txt = "New Line" + Environment.NewLine;
                File.AppendAllText(fichier, txt);
            }
            Console.ReadLine();
        }
    }
}
