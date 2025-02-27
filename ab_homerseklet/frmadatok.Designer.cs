namespace ab_homerseklet
{
    partial class frmadatok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadatok));
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.azon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napszak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ertek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csapadek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbedit = new System.Windows.Forms.RadioButton();
            this.rbnew = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txcsapadek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txertek = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtdatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbnapszak = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txvaros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txazon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.azon,
            this.varos,
            this.napszak,
            this.datum,
            this.ertek,
            this.csapadek});
            this.dgadatok.Location = new System.Drawing.Point(14, 12);
            this.dgadatok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(640, 426);
            this.dgadatok.TabIndex = 0;
            // 
            // azon
            // 
            this.azon.HeaderText = "Azonosító";
            this.azon.Name = "azon";
            this.azon.ReadOnly = true;
            // 
            // varos
            // 
            this.varos.HeaderText = "Város";
            this.varos.Name = "varos";
            this.varos.ReadOnly = true;
            // 
            // napszak
            // 
            this.napszak.HeaderText = "Napszak";
            this.napszak.Name = "napszak";
            this.napszak.ReadOnly = true;
            // 
            // datum
            // 
            this.datum.HeaderText = "Dátum";
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            // 
            // ertek
            // 
            this.ertek.HeaderText = "Mért hőmérséklet";
            this.ertek.Name = "ertek";
            this.ertek.ReadOnly = true;
            // 
            // csapadek
            // 
            this.csapadek.HeaderText = "Mért csapadék";
            this.csapadek.Name = "csapadek";
            this.csapadek.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbedit);
            this.groupBox1.Controls.Add(this.rbnew);
            this.groupBox1.Location = new System.Drawing.Point(677, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Művelet";
            // 
            // rbedit
            // 
            this.rbedit.AutoSize = true;
            this.rbedit.Location = new System.Drawing.Point(16, 42);
            this.rbedit.Name = "rbedit";
            this.rbedit.Size = new System.Drawing.Size(84, 17);
            this.rbedit.TabIndex = 1;
            this.rbedit.TabStop = true;
            this.rbedit.Text = "Módosítás";
            this.rbedit.UseVisualStyleBackColor = true;
            // 
            // rbnew
            // 
            this.rbnew.AutoSize = true;
            this.rbnew.Location = new System.Drawing.Point(16, 19);
            this.rbnew.Name = "rbnew";
            this.rbnew.Size = new System.Drawing.Size(90, 17);
            this.rbnew.TabIndex = 0;
            this.rbnew.TabStop = true;
            this.rbnew.Text = "Új felvétele";
            this.rbnew.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txcsapadek);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txertek);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtdatum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbnapszak);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txvaros);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txazon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(677, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 237);
            this.panel1.TabIndex = 2;
            // 
            // txcsapadek
            // 
            this.txcsapadek.Location = new System.Drawing.Point(114, 202);
            this.txcsapadek.Name = "txcsapadek";
            this.txcsapadek.Size = new System.Drawing.Size(97, 20);
            this.txcsapadek.TabIndex = 11;
            this.txcsapadek.TextChanged += new System.EventHandler(this.txcsapadek_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mért csapadék:";
            // 
            // txertek
            // 
            this.txertek.Location = new System.Drawing.Point(127, 158);
            this.txertek.Name = "txertek";
            this.txertek.Size = new System.Drawing.Size(84, 20);
            this.txertek.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mért hőmérséklet:";
            // 
            // dtdatum
            // 
            this.dtdatum.CustomFormat = "yyyy-mm-dd";
            this.dtdatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdatum.Location = new System.Drawing.Point(66, 121);
            this.dtdatum.Name = "dtdatum";
            this.dtdatum.Size = new System.Drawing.Size(145, 20);
            this.dtdatum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dátum:";
            // 
            // cbnapszak
            // 
            this.cbnapszak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnapszak.FormattingEnabled = true;
            this.cbnapszak.Items.AddRange(new object[] {
            "reggel",
            "délelőtt",
            "délután",
            "este",
            "éjaszaka"});
            this.cbnapszak.Location = new System.Drawing.Point(79, 81);
            this.cbnapszak.Name = "cbnapszak";
            this.cbnapszak.Size = new System.Drawing.Size(132, 21);
            this.cbnapszak.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Napszak:";
            // 
            // txvaros
            // 
            this.txvaros.Location = new System.Drawing.Point(62, 49);
            this.txvaros.MaxLength = 40;
            this.txvaros.Name = "txvaros";
            this.txvaros.Size = new System.Drawing.Size(149, 20);
            this.txvaros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Város:";
            // 
            // txazon
            // 
            this.txazon.Location = new System.Drawing.Point(91, 13);
            this.txazon.Name = "txazon";
            this.txazon.Size = new System.Drawing.Size(120, 20);
            this.txazon.TabIndex = 1;
            this.txazon.TextChanged += new System.EventHandler(this.txazon_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító: ";
            // 
            // btsave
            // 
            this.btsave.Image = ((System.Drawing.Image)(resources.GetObject("btsave.Image")));
            this.btsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsave.Location = new System.Drawing.Point(677, 365);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(108, 64);
            this.btsave.TabIndex = 3;
            this.btsave.Text = "Mentés";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Image = ((System.Drawing.Image)(resources.GetObject("btexit.Image")));
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btexit.Location = new System.Drawing.Point(791, 365);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(108, 64);
            this.btexit.TabIndex = 4;
            this.btexit.Text = "Elvet";
            this.btexit.UseVisualStyleBackColor = true;
            // 
            // frmadatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgadatok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmadatok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adatok rögzítése";
            this.Load += new System.EventHandler(this.frmadatok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn azon;
        private System.Windows.Forms.DataGridViewTextBoxColumn varos;
        private System.Windows.Forms.DataGridViewTextBoxColumn napszak;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ertek;
        private System.Windows.Forms.DataGridViewTextBoxColumn csapadek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbedit;
        private System.Windows.Forms.RadioButton rbnew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbnapszak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txvaros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txazon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txcsapadek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txertek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtdatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btexit;
    }
}