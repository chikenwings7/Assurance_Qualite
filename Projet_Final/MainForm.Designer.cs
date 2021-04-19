
namespace Projet_Final
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNouveauEtudiant = new System.Windows.Forms.Button();
            this.buttonNouveauCours = new System.Windows.Forms.Button();
            this.buttonVoirEtudiants = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNouveauEtudiant
            // 
            this.buttonNouveauEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouveauEtudiant.Location = new System.Drawing.Point(12, 55);
            this.buttonNouveauEtudiant.Name = "buttonNouveauEtudiant";
            this.buttonNouveauEtudiant.Size = new System.Drawing.Size(150, 100);
            this.buttonNouveauEtudiant.TabIndex = 0;
            this.buttonNouveauEtudiant.Text = "Nouveau Étudiant";
            this.buttonNouveauEtudiant.UseVisualStyleBackColor = true;
            this.buttonNouveauEtudiant.Click += new System.EventHandler(this.buttonNouveauEtudiant_Click);
            // 
            // buttonNouveauCours
            // 
            this.buttonNouveauCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouveauCours.Location = new System.Drawing.Point(176, 55);
            this.buttonNouveauCours.Name = "buttonNouveauCours";
            this.buttonNouveauCours.Size = new System.Drawing.Size(150, 100);
            this.buttonNouveauCours.TabIndex = 4;
            this.buttonNouveauCours.Text = "Nouveau Cours";
            this.buttonNouveauCours.UseVisualStyleBackColor = true;
            this.buttonNouveauCours.Click += new System.EventHandler(this.buttonNouveauCours_Click);
            // 
            // buttonVoirEtudiants
            // 
            this.buttonVoirEtudiants.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoirEtudiants.Location = new System.Drawing.Point(340, 55);
            this.buttonVoirEtudiants.Name = "buttonVoirEtudiants";
            this.buttonVoirEtudiants.Size = new System.Drawing.Size(150, 100);
            this.buttonVoirEtudiants.TabIndex = 5;
            this.buttonVoirEtudiants.Text = "Voir Étudiants";
            this.buttonVoirEtudiants.UseVisualStyleBackColor = true;
            this.buttonVoirEtudiants.Click += new System.EventHandler(this.buttonVoirEtudiants_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 211);
            this.Controls.Add(this.buttonVoirEtudiants);
            this.Controls.Add(this.buttonNouveauCours);
            this.Controls.Add(this.buttonNouveauEtudiant);
            this.Name = "MainForm";
            this.Text = "Projet Final";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNouveauEtudiant;
        private System.Windows.Forms.Button buttonNouveauCours;
        private System.Windows.Forms.Button buttonVoirEtudiants;
    }
}

