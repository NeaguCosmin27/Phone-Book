﻿namespace Agenda_Telefonica
{
    partial class frmSearchWindow
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
            this.Cauta = new System.Windows.Forms.Button();
            this.casutaCautare = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(473, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cauta
            // 
            this.Cauta.Location = new System.Drawing.Point(552, 35);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(75, 23);
            this.Cauta.TabIndex = 1;
            this.Cauta.Text = "Cauta";
            this.Cauta.UseVisualStyleBackColor = true;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // casutaCautare
            // 
            this.casutaCautare.Location = new System.Drawing.Point(514, 79);
            this.casutaCautare.Name = "casutaCautare";
            this.casutaCautare.Size = new System.Drawing.Size(153, 20);
            this.casutaCautare.TabIndex = 2;
            this.casutaCautare.TextChanged += new System.EventHandler(this.casutaCautare_TextChanged);
            // 
            // frmSearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 261);
            this.Controls.Add(this.casutaCautare);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSearchWindow";
            this.Text = "frmSearchWindow";
            this.Load += new System.EventHandler(this.Cautare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cauta;
        private System.Windows.Forms.TextBox casutaCautare;
    }
}