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
    public partial class ListeEtudiantsForm : Form
    {
        public ListeEtudiantsForm()
        {
            InitializeComponent();
        }

        private void ListeEtudiantsForm_Load(object sender, EventArgs e)
        {
            //foreach (var etudiant in GlobalVariables.listeEtudiants)
            //{
            //listBoxEtudiants.Items.Add(etudiant.ToString());
            //}

            //foreach (var cours in GlobalVariables.listeCours)
            //{
            //listBoxCours.Items.Add(cours.ToString());
            //}

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonNouvelleNote_Click(object sender, EventArgs e)
        {
            GlobalVariables.listBoxEtudiantIndex = listBoxEtudiants.SelectedIndex;
            GlobalVariables.listBoxCoursIndex = listBoxCours.SelectedIndex;
            if (listBoxEtudiants.SelectedIndex != -1 && listBoxCours.SelectedIndex != -1)
            {
                    this.Hide();
                    NouvelleNoteForm formNouvelleNote = new NouvelleNoteForm();
                    formNouvelleNote.ShowDialog();
                    this.Show();
            }
            else
            {
                MessageBox.Show("Sélectionner un étudiant et un cours.");
            }
        }

        private void buttonVoirNote_Click(object sender, EventArgs e)
        {
            if (listBoxEtudiants.SelectedIndex != -1 && listBoxCours.SelectedIndex != -1)
            {
                foreach (var note in GlobalVariables.listeNote)
                { 
                    if(note.getNumberoEtudiant() == listBoxEtudiants.SelectedItem.ToString() && note.getNumberoCours() == listBoxCours.SelectedItem.ToString())
                    {
                        MessageBox.Show(note.getNote());
                    }
                    else
                    {
                        MessageBox.Show("Sélectionner un étudiant et un cours.");
                    }
                }
            }
        }
    }
}
