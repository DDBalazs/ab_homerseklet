namespace ab_homerseklet
{
    partial class Fomenu
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
            this.adatokMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txadatok = new System.Windows.Forms.ToolStripMenuItem();
            this.tsstatisztika = new System.Windows.Forms.ToolStripMenuItem();
            this.txexit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adatokMenüToolStripMenuItem,
            this.txexit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adatokMenüToolStripMenuItem
            // 
            this.adatokMenüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txadatok,
            this.tsstatisztika});
            this.adatokMenüToolStripMenuItem.Name = "adatokMenüToolStripMenuItem";
            this.adatokMenüToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.adatokMenüToolStripMenuItem.Text = "Adatok menü";
            // 
            // txadatok
            // 
            this.txadatok.Name = "txadatok";
            this.txadatok.Size = new System.Drawing.Size(180, 22);
            this.txadatok.Text = "Adatok rögzítése";
            this.txadatok.Click += new System.EventHandler(this.txadatok_Click);
            // 
            // tsstatisztika
            // 
            this.tsstatisztika.Name = "tsstatisztika";
            this.tsstatisztika.Size = new System.Drawing.Size(180, 22);
            this.tsstatisztika.Text = "Statisztika";
            // 
            // txexit
            // 
            this.txexit.Name = "txexit";
            this.txexit.Size = new System.Drawing.Size(56, 20);
            this.txexit.Text = "Kilépés";
            this.txexit.Click += new System.EventHandler(this.txexit_Click);
            // 
            // Fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Fomenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adatokMenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txadatok;
        private System.Windows.Forms.ToolStripMenuItem tsstatisztika;
        private System.Windows.Forms.ToolStripMenuItem txexit;
    }
}

