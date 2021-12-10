using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace P6_3_1204026
{
    public partial class Form1 : Form
    {
        private string url = "server=localhost;userid=root;password=;database=p6_1204026";
        DataTable dataprodi = new DataTable();
        private void filldataset()
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(url))
            {
                MySqlCommand sqlCmd = new MySqlCommand("SELECT id_prodi, singkatan FROM msprodi", sqlConnection);
                sqlConnection.Open();
                MySqlDataAdapter sqlReader = new MySqlDataAdapter(sqlCmd);
                sqlReader.Fill(dataprodi);

               
            }
            comboBox1.DataSource = dataprodi;
            comboBox1.DisplayMember = "singkatan";
            comboBox1.ValueMember = "id_prodi";
        }

        public Form1()
        {
            InitializeComponent();
            filldataset();
        }
        private void InsertDB(string cmd)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(url);
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Data has been Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jk = "";
            if (rbPr.Checked) { jk = rbPr.Text; } else if (rblk.Checked) { jk = rblk.Text; }
            string sDate = tgl.SelectionStart.ToString("yyyy\\/MM\\/dd");
            string alamat = Alamat.Text;
            string cmdsave = "insert into MSMHS values('" + numeric1.Text + "','" + chartb1.Text + "','" + tgl + "','" + jk + "','" + Alamat + "','" + numeric2.Text + "','" + comboBox1.SelectedValue + "')";
            InsertDB(cmdsave);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numeric1.Clear();
            chartb1.Clear();
            numeric2.Clear();
            Alamat.Text = "";
            comboBox1.Items.Insert(0, "-Please Select-");
            rbPr.Checked = false;
            rblk.Checked = false;

        }

        private void numeric1_Leave(object sender, EventArgs e)
        {
            if (numeric1.Text == "")
            {
                epSalah.SetError(numeric1, "Textbox harus diisi angka !!");
            }
            else 
                {
                    epBenar.SetError(numeric1, "Betul");
                }
            
        }

        private void chartb1_Leave(object sender, EventArgs e)
        {
            if (chartb1.Text == "")
            {
                epSalah.SetError(chartb1, "Textbox harus diisi huruf !!");
             
            }
            else
            {
               
                epBenar.SetError(chartb1, "Betul");
            }
        }

        private void Alamat_Leave(object sender, EventArgs e)
        {
            if (chartb1.Text == "")
            {
                epSalah.SetError(Alamat, "Textbox harus diisi  !!");

            }
            else
            {

                epBenar.SetError(Alamat, "Betul");
            }

        }

        private void numeric2_Leave(object sender, EventArgs e)
        {
            if (numeric2.Text == "")
            {
                epSalah.SetError(numeric2, "Textbox harus diisi angka !!");
            }
            else
            {
                epBenar.SetError(numeric2, "Betul");
            }
        }
    }
}
