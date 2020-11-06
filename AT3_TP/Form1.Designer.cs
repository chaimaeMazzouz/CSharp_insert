namespace AT3_TP
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.passagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piloteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passagerToolStripMenuItem,
            this.piloteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // passagerToolStripMenuItem
            // 
            this.passagerToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.passagerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passagerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passagerToolStripMenuItem.Name = "passagerToolStripMenuItem";
            this.passagerToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.passagerToolStripMenuItem.Text = "Passager";
            this.passagerToolStripMenuItem.Click += new System.EventHandler(this.passagerToolStripMenuItem_Click);
            // 
            // piloteToolStripMenuItem
            // 
            this.piloteToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.piloteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piloteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.piloteToolStripMenuItem.Name = "piloteToolStripMenuItem";
            this.piloteToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.piloteToolStripMenuItem.Text = "Pilote";
            this.piloteToolStripMenuItem.Click += new System.EventHandler(this.piloteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem passagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piloteToolStripMenuItem;
    }
}

