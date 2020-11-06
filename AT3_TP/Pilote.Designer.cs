namespace AT3_TP
{
    partial class Pilote
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
            this.Inserer_Pilote = new System.Windows.Forms.Button();
            this.Pilote_ville = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pilote_Code_Postal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pilote_Nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Inserer_Pilote
            // 
            this.Inserer_Pilote.BackColor = System.Drawing.Color.White;
            this.Inserer_Pilote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inserer_Pilote.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.Inserer_Pilote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Inserer_Pilote.Location = new System.Drawing.Point(531, 163);
            this.Inserer_Pilote.Name = "Inserer_Pilote";
            this.Inserer_Pilote.Size = new System.Drawing.Size(99, 64);
            this.Inserer_Pilote.TabIndex = 21;
            this.Inserer_Pilote.Text = "Inserer";
            this.Inserer_Pilote.UseVisualStyleBackColor = false;
            this.Inserer_Pilote.Click += new System.EventHandler(this.Inserer_Pilote_Click);
            // 
            // Pilote_ville
            // 
            this.Pilote_ville.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pilote_ville.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Pilote_ville.Location = new System.Drawing.Point(282, 256);
            this.Pilote_ville.Name = "Pilote_ville";
            this.Pilote_ville.Size = new System.Drawing.Size(169, 30);
            this.Pilote_ville.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(138, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "ville";
            // 
            // Pilote_Code_Postal
            // 
            this.Pilote_Code_Postal.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pilote_Code_Postal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Pilote_Code_Postal.Location = new System.Drawing.Point(282, 181);
            this.Pilote_Code_Postal.Name = "Pilote_Code_Postal";
            this.Pilote_Code_Postal.Size = new System.Drawing.Size(169, 30);
            this.Pilote_Code_Postal.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Code Postal";
            // 
            // Pilote_Nom
            // 
            this.Pilote_Nom.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pilote_Nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Pilote_Nom.Location = new System.Drawing.Point(282, 105);
            this.Pilote_Nom.Name = "Pilote_Nom";
            this.Pilote_Nom.Size = new System.Drawing.Size(169, 30);
            this.Pilote_Nom.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "nom";
            // 
            // Pilote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Inserer_Pilote);
            this.Controls.Add(this.Pilote_ville);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pilote_Code_Postal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pilote_Nom);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.LightCoral;
            this.Name = "Pilote";
            this.Text = "Pilote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inserer_Pilote;
        private System.Windows.Forms.TextBox Pilote_ville;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pilote_Code_Postal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pilote_Nom;
        private System.Windows.Forms.Label label1;
    }
}