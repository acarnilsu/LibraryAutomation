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

namespace DbKütüphaneOtomasyonu
{
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserTc.Text.Length == 11)
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("insert into TblStudent (StudentName, StudentSurname, StudentTC, StudentPhone) values (@p1,@p2,@p3,@p4)", connection);
                command.Parameters.AddWithValue("@p1", txtUserName.Text);
                command.Parameters.AddWithValue("@p2", txtUserSurname.Text);
                command.Parameters.AddWithValue("@p3", txtUserTc.Text);
                command.Parameters.AddWithValue("@p4", txtUserPhone.Text);

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Üye başarılı bir şekilde eklendi");
            }
        }

        private void txtUserTc_TextChanged(object sender, EventArgs e)
        {
            if (txtUserTc.Text.Length != 11)
            {
                lbltc.Text = "11 karakter olmalı!";
                lbltc.ForeColor = Color.Red;
            }
            else
            {
                lbltc.Text = "";
            }
        }
    }
}
