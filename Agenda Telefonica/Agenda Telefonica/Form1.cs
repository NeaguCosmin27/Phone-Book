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
using System.IO;
using System.Xml;

namespace Agenda_Telefonica
{
    public partial class frmMainWindow : Form
    {
        string provider = ConfigurationManager.AppSettings["provider"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];
        SqlConnection connection = new SqlConnection();
        SqlCommand comanda = new SqlCommand();
        private SqlDataAdapter adaptor;
        private DataSet set;
        private DataTable date;
        
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        
        private void Incarca_Datele_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = connectionString;

            if(connection == null)
            {
                MessageBox.Show("Nu exista conexiune la baza de date!");
                return;
            }

            connection.Open();

            dataGridView1.Columns.Remove("Index");
            dataGridView1.Columns.Remove("Nume");
            dataGridView1.Columns.Remove("Prenume");
            dataGridView1.Columns.Remove("Telefon");
            dataGridView1.Columns.Remove("Retea");

            adaptor = new SqlDataAdapter(comanda);
            date = new DataTable();

          

            comanda.Connection = connection;

            comanda.CommandText = "Select * From Abonati";

            adaptor.Fill(date);
            dataGridView1.DataSource = date;
            if(dataGridView1.Rows.Count ==1)
            {
                MessageBox.Show("Nici un abonat gasit in baza de date!");
            }
            connection.Close();


        }

        private void Salveaza_datele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commanda1 = new SqlCommandBuilder(adaptor);
                adaptor.Update(date);
                MessageBox.Show("Elementul a fost salvat in baza de date");
            }
            catch (Exception)
            {
                MessageBox.Show("Datorita unei erori, datele nu au putut fi salvate. Asigurati-va ca ati completat intotdeauna campul Index al fiecarei noi inregistrari!");
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           if (MessageBox.Show("Sunteti sigur ca doriti sa iesiti?(Da/Nu)", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
           else
            {

            }
           
        }

        private void cautarePersoanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchWindow cautare = new frmSearchWindow();
            cautare.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Index";
            dataGridView1.Columns[1].Name = "Nume";
            dataGridView1.Columns[2].Name = "Prenume";
            dataGridView1.Columns[3].Name = "Telefon";
            dataGridView1.Columns[4].Name = "Retea";
            
        }

       
        private void Standard1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Green;           
        }

        private void Albastru_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;           
        }

        private void Font_Butoane_Click(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Italic", 7.6F, GraphicsUnit.Pixel);
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Italic", 7.6F, GraphicsUnit.Pixel);
        }

        private void Arial_Click(object sender, EventArgs e)
        {
            Incarca_Datele.Font = new Font("Arial", 10.8F, GraphicsUnit.Pixel);
            Salveaza_datele.Font = new Font("Arial", 10.8F, GraphicsUnit.Pixel);
        }

        private void serializare_informatii_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Nimic de serializat!");
            }else
            {
                SaveFileDialog salvare = new SaveFileDialog();
               
                salvare.Filter = "Fisier XML'|.xml";
                salvare.FileName = "Abonati_'" + DateTime.Now.ToString("yyyyMMddHHmmss") +"'.xml";
                if (salvare.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = salvare.FileName;
                                       
                    adaptor = new SqlDataAdapter(comanda);
                    set = new DataSet();
                    date = new DataTable();
                    adaptor.Fill(date);
                    set.Tables.Add(date);
                    set.WriteXml(path);
                    set.Dispose();
                    
                }
                else
                {
                    this.Text = "Cancel Pressed";
                }
                

            }
        }
    }
}
