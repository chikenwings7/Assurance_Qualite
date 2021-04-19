
namespace Projet_Final
{
    partial class NouveauCoursForm
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
            this.buttonSaveCours = new System.Windows.Forms.Button();
            this.textBoxTitreCours = new System.Windows.Forms.TextBox();
            this.textBoxCodeCours = new System.Windows.Forms.TextBox();
            this.textBoxNumeroCours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveCours
            // 
            this.buttonSaveCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveCours.Location = new System.Drawing.Point(133, 206);
            this.buttonSaveCours.Name = "buttonSaveCours";
            this.buttonSaveCours.Size = new System.Drawing.Size(100, 50);
            this.buttonSaveCours.TabIndex = 1;
            this.buttonSaveCours.Text = "Save";
            this.buttonSaveCours.UseVisualStyleBackColor = true;
            this.buttonSaveCours.Click += new System.EventHandler(this.buttonSaveCours_Click);
            // 
            // textBoxTitreCours
            // 
            this.textBoxTitreCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitreCours.Location = new System.Drawing.Point(162, 152);
            this.textBoxTitreCours.Name = "textBoxTitreCours";
            this.textBoxTitreCours.Size = new System.Drawing.Size(186, 26);
            this.textBoxTitreCours.TabIndex = 12;
            // 
            // textBoxCodeCours
            // 
            this.textBoxCodeCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodeCours.Location = new System.Drawing.Point(162, 92);
            this.textBoxCodeCours.Name = "textBoxCodeCours";
            this.textBoxCodeCours.Size = new System.Drawing.Size(186, 26);
            this.textBoxCodeCours.TabIndex = 11;
            // 
            // textBoxNumeroCours
            // 
            this.textBoxNumeroCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroCours.Location = new System.Drawing.Point(162, 31);
            this.textBoxNumeroCours.Name = "textBoxNumeroCours";
            this.textBoxNumeroCours.Size = new System.Drawing.Size(186, 26);
            this.textBoxNumeroCours.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Titre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numéro du Cours :";
            // 
            // NouveauCoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 286);
            this.Controls.Add(this.textBoxTitreCours);
            this.Controls.Add(this.textBoxCodeCours);
            this.Controls.Add(this.textBoxNumeroCours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveCours);
            this.Name = "NouveauCoursForm";
            this.Text = "NouveauCoursForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveCours;
        private System.Windows.Forms.TextBox textBoxTitreCours;
        private System.Windows.Forms.TextBox textBoxCodeCours;
        private System.Windows.Forms.TextBox textBoxNumeroCours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}