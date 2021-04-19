
namespace Projet_Final
{
    partial class NouvelleNoteForm
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
            this.labelNumeroEtudiant = new System.Windows.Forms.Label();
            this.labelNomEtudiant = new System.Windows.Forms.Label();
            this.labelPrenomEtudiant = new System.Windows.Forms.Label();
            this.labelNouvelleNote = new System.Windows.Forms.Label();
            this.textBoxNouvelleNote = new System.Windows.Forms.TextBox();
            this.buttonSubmitNote = new System.Windows.Forms.Button();
            this.labelTitreCours = new System.Windows.Forms.Label();
            this.labelCodeCours = new System.Windows.Forms.Label();
            this.labelNumeroCours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumeroEtudiant
            // 
            this.labelNumeroEtudiant.AutoSize = true;
            this.labelNumeroEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroEtudiant.Location = new System.Drawing.Point(12, 9);
            this.labelNumeroEtudiant.Name = "labelNumeroEtudiant";
            this.labelNumeroEtudiant.Size = new System.Drawing.Size(81, 18);
            this.labelNumeroEtudiant.TabIndex = 0;
            this.labelNumeroEtudiant.Text = "# Étudiant: ";
            // 
            // labelNomEtudiant
            // 
            this.labelNomEtudiant.AutoSize = true;
            this.labelNomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomEtudiant.Location = new System.Drawing.Point(12, 27);
            this.labelNomEtudiant.Name = "labelNomEtudiant";
            this.labelNomEtudiant.Size = new System.Drawing.Size(49, 18);
            this.labelNomEtudiant.TabIndex = 1;
            this.labelNomEtudiant.Text = "Nom: ";
            // 
            // labelPrenomEtudiant
            // 
            this.labelPrenomEtudiant.AutoSize = true;
            this.labelPrenomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenomEtudiant.Location = new System.Drawing.Point(12, 45);
            this.labelPrenomEtudiant.Name = "labelPrenomEtudiant";
            this.labelPrenomEtudiant.Size = new System.Drawing.Size(69, 18);
            this.labelPrenomEtudiant.TabIndex = 2;
            this.labelPrenomEtudiant.Text = "Prénom: ";
            // 
            // labelNouvelleNote
            // 
            this.labelNouvelleNote.AutoSize = true;
            this.labelNouvelleNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNouvelleNote.Location = new System.Drawing.Point(12, 171);
            this.labelNouvelleNote.Name = "labelNouvelleNote";
            this.labelNouvelleNote.Size = new System.Drawing.Size(48, 18);
            this.labelNouvelleNote.TabIndex = 3;
            this.labelNouvelleNote.Text = "Note: ";
            // 
            // textBoxNouvelleNote
            // 
            this.textBoxNouvelleNote.Location = new System.Drawing.Point(66, 169);
            this.textBoxNouvelleNote.Name = "textBoxNouvelleNote";
            this.textBoxNouvelleNote.Size = new System.Drawing.Size(49, 20);
            this.textBoxNouvelleNote.TabIndex = 4;
            // 
            // buttonSubmitNote
            // 
            this.buttonSubmitNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitNote.Location = new System.Drawing.Point(15, 221);
            this.buttonSubmitNote.Name = "buttonSubmitNote";
            this.buttonSubmitNote.Size = new System.Drawing.Size(125, 65);
            this.buttonSubmitNote.TabIndex = 5;
            this.buttonSubmitNote.Text = "Soummetre Note";
            this.buttonSubmitNote.UseVisualStyleBackColor = true;
            this.buttonSubmitNote.Click += new System.EventHandler(this.buttonSubmitNote_Click);
            // 
            // labelTitreCours
            // 
            this.labelTitreCours.AutoSize = true;
            this.labelTitreCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreCours.Location = new System.Drawing.Point(191, 45);
            this.labelTitreCours.Name = "labelTitreCours";
            this.labelTitreCours.Size = new System.Drawing.Size(45, 18);
            this.labelTitreCours.TabIndex = 8;
            this.labelTitreCours.Text = "Titre: ";
            // 
            // labelCodeCours
            // 
            this.labelCodeCours.AutoSize = true;
            this.labelCodeCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodeCours.Location = new System.Drawing.Point(191, 27);
            this.labelCodeCours.Name = "labelCodeCours";
            this.labelCodeCours.Size = new System.Drawing.Size(52, 18);
            this.labelCodeCours.TabIndex = 7;
            this.labelCodeCours.Text = "Code: ";
            // 
            // labelNumeroCours
            // 
            this.labelNumeroCours.AutoSize = true;
            this.labelNumeroCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroCours.Location = new System.Drawing.Point(191, 9);
            this.labelNumeroCours.Name = "labelNumeroCours";
            this.labelNumeroCours.Size = new System.Drawing.Size(69, 18);
            this.labelNumeroCours.TabIndex = 6;
            this.labelNumeroCours.Text = "# Cours: ";
            // 
            // NouvelleNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 298);
            this.Controls.Add(this.labelTitreCours);
            this.Controls.Add(this.labelCodeCours);
            this.Controls.Add(this.labelNumeroCours);
            this.Controls.Add(this.buttonSubmitNote);
            this.Controls.Add(this.textBoxNouvelleNote);
            this.Controls.Add(this.labelNouvelleNote);
            this.Controls.Add(this.labelPrenomEtudiant);
            this.Controls.Add(this.labelNomEtudiant);
            this.Controls.Add(this.labelNumeroEtudiant);
            this.Name = "NouvelleNoteForm";
            this.Text = "NouvelleNoteForm";
            this.Load += new System.EventHandler(this.NouvelleNoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumeroEtudiant;
        private System.Windows.Forms.Label labelNomEtudiant;
        private System.Windows.Forms.Label labelPrenomEtudiant;
        private System.Windows.Forms.Label labelNouvelleNote;
        private System.Windows.Forms.TextBox textBoxNouvelleNote;
        private System.Windows.Forms.Button buttonSubmitNote;
        private System.Windows.Forms.Label labelTitreCours;
        private System.Windows.Forms.Label labelCodeCours;
        private System.Windows.Forms.Label labelNumeroCours;
    }
}