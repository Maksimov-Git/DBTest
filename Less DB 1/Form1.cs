using System;
using System.Collections.Generic;
using System.ComponentModel;
//
using System.Data.SqlClient;
//
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Less_DB_1
{

    
    public partial  class Form1 : Form
    {
        SqlConnection Connection;
        SqlDataReader Reader;
        public Form1()
        {
            InitializeComponent();
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
            
           Connection = new SqlConnection("Data Source = tcp:tsopp.database.windows.net; Initial Catalog = TSOPPTEST; Persist Security Info = True; User ID = tsoppadmin; Password = Geirby1799");
           
           Connection.Open();

            string SQLQ = "SELECT  [AddressID],[AddressLine1],[City] FROM [SalesLT].[Address]";

            SqlCommand Comand = new SqlCommand(SQLQ, Connection);

            SqlDataReader reader = Comand.ExecuteReader();


            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(),reader[1].ToString(), reader[2].ToString());
            }

            reader.Close();

            Connection.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
} 
