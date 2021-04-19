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

            //Etudiand etudiantSelectionne = GlobalVariables.listeEtudiants[GlobalVariables.listBoxEtudiantIndex];
            //labelNumeroEtudiant.Text.Append(etudiantSelectionne.getNumeroEtudiant());
            //labelNomEtudiant.Text.Append(etudiantSelectionne.getNomEtudiant());
            //labelNomEtudiant.Text.Append(etudiantSelectionne.getPrenomEtudiant());

            //Cours coursSelectionne = GlobalVariables.listeCours[GlobalVariables.listBoxCoursIndex];
            //labelNumeroCours.Text.Append(coursSelectionne.getNumeroCours());
            //labelCodeCours.Text.Append(coursSelectionne.getCode());
            //labelTitreCours.Text.Append(coursSelectionne.getTitre());
        }

        private void buttonSubmitNote_Click(object sender, EventArgs e)
        {
            string nouvelleNote = textBoxNouvelleNote.Text;
            //GlobalVariables.ListeNotes.Add(new Note(etudiantSelectionne.getNumeroEtudiant(), coursSelectionne.getNumeroCours(), nouvelleNote));
            this.DialogResult = DialogResult.OK;
        }
    }
}
