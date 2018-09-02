namespace Agenda_Telefonica
{
    partial class frmMainWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Incarca_Datele = new System.Windows.Forms.Button();
            this.Salveaza_datele = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializare_informatii = new System.Windows.Forms.ToolStripMenuItem();
            this.preferinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Culoare_Fereastra = new System.Windows.Forms.ToolStripMenuItem();
            this.Verde = new System.Windows.Forms.ToolStripMenuItem();
            this.Albastru = new System.Windows.Forms.ToolStripMenuItem();
            this.Font_Butoane = new System.Windows.Forms.ToolStripMenuItem();
            this.Arial = new System.Windows.Forms.ToolStripMenuItem();
            this.Font_Gridview = new System.Windows.Forms.ToolStripMenuItem();
            this.Italic = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautarePersoanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Incarca_Datele
            // 
            this.Incarca_Datele.Location = new System.Drawing.Point(583, 38);
            this.Incarca_Datele.Name = "Incarca_Datele";
            this.Incarca_Datele.Size = new System.Drawing.Size(124, 23);
            this.Incarca_Datele.TabIndex = 1;
            this.Incarca_Datele.Text = "Incarca datele";
            this.Incarca_Datele.UseVisualStyleBackColor = true;
            this.Incarca_Datele.Click += new System.EventHandler(this.Incarca_Datele_Click);
            // 
            // Salveaza_datele
            // 
            this.Salveaza_datele.Location = new System.Drawing.Point(583, 67);
            this.Salveaza_datele.Name = "Salveaza_datele";
            this.Salveaza_datele.Size = new System.Drawing.Size(124, 23);
            this.Salveaza_datele.TabIndex = 2;
            this.Salveaza_datele.Text = "Salveaza datele";
            this.Salveaza_datele.UseVisualStyleBackColor = true;
            this.Salveaza_datele.Click += new System.EventHandler(this.Salveaza_datele_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializare_informatii,
            this.preferinteToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "Fisier";
            // 
            // serializare_informatii
            // 
            this.serializare_informatii.Name = "serializare_informatii";
            this.serializare_informatii.Size = new System.Drawing.Size(181, 22);
            this.serializare_informatii.Text = "Serializare Informatii";
            this.serializare_informatii.Click += new System.EventHandler(this.serializare_informatii_Click);
            // 
            // preferinteToolStripMenuItem
            // 
            this.preferinteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Culoare_Fereastra,
            this.Font_Butoane,
            this.Font_Gridview});
            this.preferinteToolStripMenuItem.Name = "preferinteToolStripMenuItem";
            this.preferinteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.preferinteToolStripMenuItem.Text = "Preferinte";
            // 
            // Culoare_Fereastra
            // 
            this.Culoare_Fereastra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Verde,
            this.Albastru});
            this.Culoare_Fereastra.Name = "Culoare_Fereastra";
            this.Culoare_Fereastra.Size = new System.Drawing.Size(165, 22);
            this.Culoare_Fereastra.Text = "Culoare Fereastra";
            // 
            // Verde
            // 
            this.Verde.Name = "Verde";
            this.Verde.Size = new System.Drawing.Size(118, 22);
            this.Verde.Text = "Verde";
            this.Verde.Click += new System.EventHandler(this.Standard1_Click);
            // 
            // Albastru
            // 
            this.Albastru.Name = "Albastru";
            this.Albastru.Size = new System.Drawing.Size(118, 22);
            this.Albastru.Text = "Albastru";
            this.Albastru.Click += new System.EventHandler(this.Albastru_Click);
            // 
            // Font_Butoane
            // 
            this.Font_Butoane.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arial});
            this.Font_Butoane.Name = "Font_Butoane";
            this.Font_Butoane.Size = new System.Drawing.Size(165, 22);
            this.Font_Butoane.Text = "Font Butoane";
            this.Font_Butoane.Click += new System.EventHandler(this.Font_Butoane_Click);
            // 
            // Arial
            // 
            this.Arial.Name = "Arial";
            this.Arial.Size = new System.Drawing.Size(98, 22);
            this.Arial.Text = "Arial";
            this.Arial.Click += new System.EventHandler(this.Arial_Click);
            // 
            // Font_Gridview
            // 
            this.Font_Gridview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Italic});
            this.Font_Gridview.Name = "Font_Gridview";
            this.Font_Gridview.Size = new System.Drawing.Size(165, 22);
            this.Font_Gridview.Text = "Font Gridview";
            // 
            // Italic
            // 
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(99, 22);
            this.Italic.Text = "Italic";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cautarePersoanaToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.editToolStripMenuItem.Text = "Editeaza";
            // 
            // cautarePersoanaToolStripMenuItem
            // 
            this.cautarePersoanaToolStripMenuItem.Name = "cautarePersoanaToolStripMenuItem";
            this.cautarePersoanaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cautarePersoanaToolStripMenuItem.Text = "Cautare persoana";
            this.cautarePersoanaToolStripMenuItem.Click += new System.EventHandler(this.cautarePersoanaToolStripMenuItem_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 319);
            this.Controls.Add(this.Salveaza_datele);
            this.Controls.Add(this.Incarca_Datele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainWindow";
            this.Text = "frmMainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Incarca_Datele;
        private System.Windows.Forms.Button Salveaza_datele;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializare_informatii;
        private System.Windows.Forms.ToolStripMenuItem preferinteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautarePersoanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Culoare_Fereastra;
        private System.Windows.Forms.ToolStripMenuItem Verde;
        private System.Windows.Forms.ToolStripMenuItem Albastru;
        private System.Windows.Forms.ToolStripMenuItem Font_Butoane;
        private System.Windows.Forms.ToolStripMenuItem Arial;
        private System.Windows.Forms.ToolStripMenuItem Font_Gridview;
        private System.Windows.Forms.ToolStripMenuItem Italic;
    }
}

