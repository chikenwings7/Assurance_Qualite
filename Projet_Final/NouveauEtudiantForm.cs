﻿using System;
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
    public partial class NouveauEtudiantForm : Form
    {
        public NouveauEtudiantForm()
        {
            InitializeComponent();
        }

        private void buttonSaveEtudiant_Click(object sender, EventArgs e)
        {
            string numeroEtudiant = textBoxNumeroEtudiant.Text;
            string nomEtudiant = textBoxNomEtudiant.Text;
            string prenomEtudiant = textBoxPrenomEtudiant.Text;
            //ListeEtudiants.Add(new Etudiant(numeroEtudiant, nomEtudiant, prenomEtudiant));
            this.DialogResult = DialogResult.OK;
        }
    }
}
