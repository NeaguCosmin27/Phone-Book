using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Telefonica
{
    public partial class Iesire : Form
    {
        public Iesire()
        {
            InitializeComponent();
        }

        private void Nu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Da_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

       private void Iesire_Load(object sender, EventArgs e)
        {

        }
    }
}
