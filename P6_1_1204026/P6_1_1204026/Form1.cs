using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace P6_1_1204026
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string url = "server=localhost;userid=root;password=;database=p6_1204026";
        private void UpdateDB(string cmd)
        {
            try
            {
                MySqlConnection myconn = new MySqlConnection(url);
                myconn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = myconn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Database has been Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void clear()
        {
            idProdi.Text = "";
            namaProdi.Text = "";
            Singkatan.Text = "";
            kaProdi.Text = "";
            sekProdi.Text
                = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myCmd = "INSERT INTO msprodi VALUES('"
                + idProdi.Text + "','" + namaProdi + "','" + Singkatan + "','" + kaProdi + "', '" + sekProdi + "')";
            UpdateDB(myCmd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clear();
        }
    }


    

  

}

