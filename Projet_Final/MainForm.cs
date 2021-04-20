using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Final
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonNouveauEtudiant_Click(object sender, EventArgs e)
        {
            this.Hide();
            NouveauEtudiantForm formNouveauEtudiant = new NouveauEtudiantForm();
            formNouveauEtudiant.ShowDialog();
            this.Show();
        }

        private void buttonNouveauCours_Click(object sender, EventArgs e)
        {
            this.Hide();
            NouveauCoursForm formNouveauCours = new NouveauCoursForm();
            formNouveauCours.ShowDialog();
            this.Show();
        }

        private void buttonVoirEtudiants_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListeEtudiantsForm formListeEtudiants = new ListeEtudiantsForm();
            formListeEtudiants.ShowDialog();
            this.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GlobalVariables.CreateInFile();
            GlobalVariables.ReadInFile();
        }
    }
}
