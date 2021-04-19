
namespace Projet_Final
{
    partial class NouveauEtudiantForm
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
            this.buttonSaveEtudiant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumeroEtudiant = new System.Windows.Forms.TextBox();
            this.textBoxNomEtudiant = new System.Windows.Forms.TextBox();
            this.textBoxPrenomEtudiant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSaveEtudiant
            // 
            this.buttonSaveEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveEtudiant.Location = new System.Drawing.Point(136, 206);
            this.buttonSaveEtudiant.Name = "buttonSaveEtudiant";
            this.buttonSaveEtudiant.Size = new System.Drawing.Size(100, 50);
            this.buttonSaveEtudiant.TabIndex = 0;
            this.buttonSaveEtudiant.Text = "Save";
            this.buttonSaveEtudiant.UseVisualStyleBackColor = true;
            this.buttonSaveEtudiant.Click += new System.EventHandler(this.buttonSaveEtudiant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro Étudiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prénom :";
            // 
            // textBoxNumeroEtudiant
            // 
            this.textBoxNumeroEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroEtudiant.Location = new System.Drawing.Point(147, 34);
            this.textBoxNumeroEtudiant.Name = "textBoxNumeroEtudiant";
            this.textBoxNumeroEtudiant.Size = new System.Drawing.Size(186, 26);
            this.textBoxNumeroEtudiant.TabIndex = 4;
            // 
            // textBoxNomEtudiant
            // 
            this.textBoxNomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomEtudiant.Location = new System.Drawing.Point(147, 95);
            this.textBoxNomEtudiant.Name = "textBoxNomEtudiant";
            this.textBoxNomEtudiant.Size = new System.Drawing.Size(186, 26);
            this.textBoxNomEtudiant.TabIndex = 5;
            // 
            // textBoxPrenomEtudiant
            // 
            this.textBoxPrenomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenomEtudiant.Location = new System.Drawing.Point(147, 155);
            this.textBoxPrenomEtudiant.Name = "textBoxPrenomEtudiant";
            this.textBoxPrenomEtudiant.Size = new System.Drawing.Size(186, 26);
            this.textBoxPrenomEtudiant.TabIndex = 6;
            // 
            // NouveauEtudiantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 286);
            this.Controls.Add(this.textBoxPrenomEtudiant);
            this.Controls.Add(this.textBoxNomEtudiant);
            this.Controls.Add(this.textBoxNumeroEtudiant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveEtudiant);
            this.Name = "NouveauEtudiantForm";
            this.Text = "NouveauEtudiantForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveEtudiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumeroEtudiant;
        private System.Windows.Forms.TextBox textBoxNomEtudiant;
        private System.Windows.Forms.TextBox textBoxPrenomEtudiant;
    }
}