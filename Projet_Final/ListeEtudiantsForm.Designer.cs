
namespace Projet_Final
{
    partial class ListeEtudiantsForm
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
            this.listBoxEtudiants = new System.Windows.Forms.ListBox();
            this.buttonNouvelleNote = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.listBoxCours = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxEtudiants
            // 
            this.listBoxEtudiants.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEtudiants.FormattingEnabled = true;
            this.listBoxEtudiants.ItemHeight = 18;
            this.listBoxEtudiants.Location = new System.Drawing.Point(12, 43);
            this.listBoxEtudiants.Name = "listBoxEtudiants";
            this.listBoxEtudiants.Size = new System.Drawing.Size(334, 328);
            this.listBoxEtudiants.Sorted = true;
            this.listBoxEtudiants.TabIndex = 0;
            // 
            // buttonNouvelleNote
            // 
            this.buttonNouvelleNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouvelleNote.Location = new System.Drawing.Point(163, 425);
            this.buttonNouvelleNote.Name = "buttonNouvelleNote";
            this.buttonNouvelleNote.Size = new System.Drawing.Size(110, 58);
            this.buttonNouvelleNote.TabIndex = 1;
            this.buttonNouvelleNote.Text = "Nouvelle Note";
            this.buttonNouvelleNote.UseVisualStyleBackColor = true;
            this.buttonNouvelleNote.Click += new System.EventHandler(this.buttonNouvelleNote_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(442, 425);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 58);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Fermer";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveToFile.Location = new System.Drawing.Point(304, 425);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(110, 58);
            this.buttonSaveToFile.TabIndex = 3;
            this.buttonSaveToFile.Text = "Sauvegarder Dans Un Fichier";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            // 
            // listBoxCours
            // 
            this.listBoxCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCours.FormattingEnabled = true;
            this.listBoxCours.ItemHeight = 18;
            this.listBoxCours.Location = new System.Drawing.Point(372, 43);
            this.listBoxCours.Name = "listBoxCours";
            this.listBoxCours.Size = new System.Drawing.Size(334, 328);
            this.listBoxCours.Sorted = true;
            this.listBoxCours.TabIndex = 4;
            // 
            // ListeEtudiantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 497);
            this.Controls.Add(this.listBoxCours);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNouvelleNote);
            this.Controls.Add(this.listBoxEtudiants);
            this.Name = "ListeEtudiantsForm";
            this.Text = "ListeEtudiants";
            this.Load += new System.EventHandler(this.ListeEtudiantsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEtudiants;
        private System.Windows.Forms.Button buttonNouvelleNote;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.ListBox listBoxCours;
    }
}