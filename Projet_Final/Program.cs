using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projet_Final
{
    internal static class GlobalVariables
    {
        public static List<Etudiant> listeEtudiants = new List<Etudiant>();
        public static List<Cours> listeCours = new List<Cours>();
        public static List<Note> listeNotes = new List<Note>();
        public static int listBoxEtudiantIndex = -1;
        public static int listBoxCoursIndex = -1;
        public static string path = Path.Combine(Environment.CurrentDirectory, @"ListeEtudiants.txt");

        public static void CreateInFile()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    //sw.WriteLine("Ceci est la liste d'edudiants");
                }
            }
        }

        public static void AddInFile(Etudiant etudiant)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                    sw.WriteLine(etudiant.ToString());
            }
        }

        public static void ReadInFile()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s != "")
                    {
                        string[] words = s.Split(',');
                        GlobalVariables.listeEtudiants.Add(new Etudiant(words[0], words[1], words[2]));
                    }
                }
            }
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
