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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");
        public void BookList()
        {
            SqlCommand command = new SqlCommand("Select * from TblBook where BookStock > 0", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            BookList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //önce id  text box boş mu diye kontrol etcez

            // id doluysa silme işlemi gerçekleşcek
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from TblBook Where BookID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtBookID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Ürün başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            connection.Close();
            //listeyi yapamadım.

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // tıklanan kitabın idsini alcaz
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            // soldaki textboxları doldurcaz
            txtBookID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBookName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtWriterID.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtPublisherID.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtTotalPage.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtStock.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblBook Set BookName=@p1, WriterID=@p2, PublisherID=@p3, BookTotalPage=@p4, BookStock=@p5 Where BookID=@p6", connection);
            command.Parameters.AddWithValue("@p1", txtBookName.Text);
            command.Parameters.AddWithValue("@p2", txtWriterID.Text);
            command.Parameters.AddWithValue("@p3", txtPublisherID.Text);
            command.Parameters.AddWithValue("@p4", txtTotalPage.Text);
            command.Parameters.AddWithValue("@p5", txtStock.Text);
            command.Parameters.AddWithValue("@p6", txtBookID.Text);
            command.ExecuteNonQuery();
            connection.Close();

            btnList_Click(sender, e);
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "" && txtSearch.Text != "Kitap ismi giriniz...")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from TblBook where BookName Like '" + txtSearch.Text + "%'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
            else
            {
                BookList();
            }


        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Kitap ismi giriniz...")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Kitap ismi giriniz...";
            }
        }
    }
}
