using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projet_Final
{

    internal static class GlobalVariables
    {
        //public static List<Etudiant> listeEtudiants = new List<Etudiant>();
        //public static List<Cours> listeCours = new List<Cours>();
        //public static List<Note> listeNotes = new List<Note>();
        public static int listBoxEtudiantIndex = -1;
        public static int listBoxCoursIndex = -1;
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
