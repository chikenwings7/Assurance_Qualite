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
    public partial class NouveauCoursForm : Form
    {
        public NouveauCoursForm()
        {
            InitializeComponent();
        }

        private void buttonSaveCours_Click(object sender, EventArgs e)
        {
            string numeroCours = textBoxNumeroCours.Text;
            string codeCours = textBoxCodeCours.Text;
            string titreCours = textBoxTitreCours.Text;
            GlobalVariables.listeCours.Add(new Cours(numeroCours, codeCours, titreCours));
            this.DialogResult = DialogResult.OK;
        }
    }
}
