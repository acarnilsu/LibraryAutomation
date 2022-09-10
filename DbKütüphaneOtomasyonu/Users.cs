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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");

        private void btnList_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TblStudent", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from TblStudent Where StudentID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtUserID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kişi başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            connection.Close();
            //listeyi yapamadım.
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblStudent Set StudentName=@p1, StudentSurname=@p2, StudentTC=@p3, StudentPhone=@p4, AddressID=@p5 Where StudentID=@p6", connection);
            command.Parameters.AddWithValue("@p1", txtUserName.Text);
            command.Parameters.AddWithValue("@p2", txtUserSurname.Text);
            command.Parameters.AddWithValue("@p3", txtTCNo.Text);
            command.Parameters.AddWithValue("@p4", txtPhone.Text);
            command.Parameters.AddWithValue("@p5", txtAddress.Text);
            command.Parameters.AddWithValue("@p6", txtUserID.Text);
            command.ExecuteNonQuery();
            connection.Close();

            btnList_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            // soldaki textboxları doldurcaz
            txtUserID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUserName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtUserSurname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTCNo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void txtTCNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTCNo.Text.Length!=11)
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
