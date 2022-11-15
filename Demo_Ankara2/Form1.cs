using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Ankara2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAnkaraProjeDataSet.TblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.dbAnkaraProjeDataSet.TblCustomer);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Data Source=DESKTOP-07T8MF2\MSSQLSERVER01;Initial Catalog=DbAnkaraProje;Integrated Security=True
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-07T8MF2\\MSSQLSERVER01;Initial Catalog=DbAnkaraProje;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblCustomer (CustomerName,CustomerSurname) values (@p1,@p2)", connection);
            command.Parameters.AddWithValue("@p1", txtCustomerName.Text);
            command.Parameters.AddWithValue("@p2", txtCustomerSurname.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Müşteri başarılı bir şekilde sisteme eklendi");
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-07T8MF2\\MSSQLSERVER01;Initial Catalog=DbAnkaraProje;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From TblCustomer Where CustomerID=@p1", connection);
            command.Parameters.AddWithValue("@p1",txtCustomerID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarılı bir şekilde silindi");
        }
    }
}
