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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-07T8MF2\\MSSQLSERVER01;Initial Catalog=DbAnkaraProje;Integrated Security=True");

            //istatistik 1 müşteri sayısı
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select Count(*) From TblCustomer", connection);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                lblCustomerCount.Text = dataReader1[0].ToString();
            }
            connection.Close();

            //istatistik 2
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select Count(*) From TblDepartment", connection);
            SqlDataReader dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                lblDepartmentCount.Text = dataReader2[0].ToString();
            }
            connection.Close();

            //istatistik 3
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select Count(Distinct(CustomerCity)) From TblCustomer", connection);
            SqlDataReader dataReader3 = command3.ExecuteReader();
            while (dataReader3.Read())
            {
                lblCityCount.Text = dataReader3[0].ToString();
            }
            connection.Close();

            //istatistik 4
            //connection.Open();
            //SqlCommand command4 = new SqlCommand("Select Count(Distinct(CustomerCity)) From TblCustomer", connection);
            //SqlDataReader dataReader4 = command4.ExecuteReader();
            //while (dataReader4.Read())
            //{
            //    lblCityCount.Text = dataReader4[0].ToString();
            //}

            //istatistik 5
            connection.Open();
            SqlCommand command5 = new SqlCommand("Select Top(1) CustomerCity,Count(*) From TblCustomer Group By CustomerCity order by Count(*) desc", connection);
            SqlDataReader dataReader5 = command5.ExecuteReader();
            while (dataReader5.Read())
            {
                lblMaxCity.Text = dataReader5[0].ToString();
            }
            connection.Close();

        }
    }
}
