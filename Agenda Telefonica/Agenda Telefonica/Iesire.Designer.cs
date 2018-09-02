namespace Agenda_Telefonica
{
    partial class Iesire
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
            this.label1 = new System.Windows.Forms.Label();
            this.Da = new System.Windows.Forms.Button();
            this.Nu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunteti sigur ca vreti sa iesiti?(Da/Nu)";
            // 
            // Da
            // 
            this.Da.Location = new System.Drawing.Point(75, 43);
            this.Da.Name = "Da";
            this.Da.Size = new System.Drawing.Size(75, 23);
            this.Da.TabIndex = 1;
            this.Da.Text = "Da";
            this.Da.UseVisualStyleBackColor = true;
            this.Da.Click += new System.EventHandler(this.Da_Click);
            // 
            // Nu
            // 
            this.Nu.Location = new System.Drawing.Point(232, 43);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(75, 23);
            this.Nu.TabIndex = 2;
            this.Nu.Text = "Nu";
            this.Nu.UseVisualStyleBackColor = true;
            this.Nu.Click += new System.EventHandler(this.Nu_Click);
            // 
            // Iesire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 78);
            this.Controls.Add(this.Nu);
            this.Controls.Add(this.Da);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Iesire";
            this.ShowIcon = false;
            this.Text = "Iesire";
            this.Load += new System.EventHandler(this.Iesire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Da;
        private System.Windows.Forms.Button Nu;
    }
}