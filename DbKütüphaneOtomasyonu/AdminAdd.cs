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
    public partial class AdminAdd : Form
    {
        public AdminAdd()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");

        private void btnList_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TblAdmin", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblAdmin (AdminName, AdminPassword) values (@p1,@p2)", connection);
            command.Parameters.AddWithValue("@p1", txtAdminName.Text);
            command.Parameters.AddWithValue("@p2", txtAdminPassword.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Admin başarılı bir şekilde eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from TblAdmin Where AdminID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtAdminID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Admin başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            // soldaki textboxları doldurcaz
            txtAdminID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAdminName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAdminPassword.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void txtAdminName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
