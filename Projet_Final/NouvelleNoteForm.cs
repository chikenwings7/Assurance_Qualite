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
    public partial class NouvelleNoteForm : Form
    {
        public NouvelleNoteForm()
        {
            InitializeComponent();
        }

        private void NouvelleNoteForm_Load(object sender, EventArgs e)
        {

            Etudiant etudiantSelectionne = GlobalVariables.listeEtudiants[GlobalVariables.listBoxEtudiantIndex];
            labelNumeroEtudiant.Text += etudiantSelectionne.getNumeroEtudiant();
            labelNomEtudiant.Text += etudiantSelectionne.getNom();
            labelPrenomEtudiant.Text += etudiantSelectionne.getPrenom();

            Cours coursSelectionne = GlobalVariables.listeCours[GlobalVariables.listBoxCoursIndex];
            labelNumeroCours.Text += coursSelectionne.getNumeroCours();
            labelCodeCours.Text += coursSelectionne.getCode();
            labelTitreCours.Text += coursSelectionne.getTitre();
        }

        private void buttonSubmitNote_Click(object sender, EventArgs e)
        {
            Etudiant etudiantSelectionne = GlobalVariables.listeEtudiants[GlobalVariables.listBoxEtudiantIndex];
            Cours coursSelectionne = GlobalVariables.listeCours[GlobalVariables.listBoxCoursIndex];
            string nouvelleNote = textBoxNouvelleNote.Text;
            GlobalVariables.listeNotes.Add(new Note(etudiantSelectionne.getNumeroEtudiant(), coursSelectionne.getNumeroCours(), nouvelleNote));
            this.DialogResult = DialogResult.OK;
        }
    }
}
