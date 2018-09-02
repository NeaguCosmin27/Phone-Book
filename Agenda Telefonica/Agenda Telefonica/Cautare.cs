using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;

namespace Agenda_Telefonica
{
    public partial class frmSearchWindow : Form
    {
        string provider = ConfigurationManager.AppSettings["provider"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];
        SqlConnection connection1 = new SqlConnection();
        SqlCommand comanda1 = new SqlCommand();
        private SqlDataAdapter adaptor1;
        private DataTable date1;
        
        
        
        public frmSearchWindow()
        {
            InitializeComponent();
        }

        private void Cautare_Load(object sender, EventArgs e)
        {
            connection1.ConnectionString = connectionString;

            if (connection1 == null)
            {
                MessageBox.Show("Eroare de conexiune!");
                return;
            }

            string valoareDeCautat = casutaCautare.Text.ToString();
            connection1.Open();

            comanda1.Connection = connection1;

            comanda1.CommandText = "Select * From Abonati";

            adaptor1 = new SqlDataAdapter(comanda1);
            date1 = new DataTable();
            adaptor1.Fill(date1);
            connection1.Close();
            this.BackColor = frmMainWindow.ActiveForm.BackColor;
           
            
            

        }

        private void Cauta_Click(object sender, EventArgs e)
        {
            DataView dv = date1.DefaultView;

            if (casutaCautare.Text.ToString() == "")
            {
                MessageBox.Show("Introduceti un indiciu pentru cautare");
            }
            else
            {
                dv.RowFilter = string.Format("Prenume like '%{0}%' OR Nume like '%{0}%' OR Retea like '%{0}%' OR Telefon like '%{0}%' OR Index like '%{0}%'", casutaCautare.Text);
                dataGridView1.DataSource = dv.ToTable();
                
                if (dv.Count == 0)
                {
                    MessageBox.Show("Nici un abonat gasit in baza de date!");
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Show();
        }

        private void casutaCautare_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
