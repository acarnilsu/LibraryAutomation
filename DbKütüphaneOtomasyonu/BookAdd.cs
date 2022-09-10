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
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();
            //cmbWriters.Items.Clear();
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblWriter", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            //foreach (DataRow item in dataTable.Rows)
            //{
            //    cmbWriters.Items.Add(new { Text = item[1] + " " + item[2], Value = item[0]});
            //}
            //cmbWriters.DataSource = dataTable.Rows;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblBook (BookName, WriterID, PublisherID, BookTotalPage, BookStock) values (@p1,@p2,@p3,@p4,@p5)", connection);
            command.Parameters.AddWithValue("@p1", txtBookName.Text);
            command.Parameters.AddWithValue("@p2", cmbWriter.SelectedValue);
            command.Parameters.AddWithValue("@p3", cmbPublisher.SelectedValue);
            command.Parameters.AddWithValue("@p4", txtTotalPage.Text);
            command.Parameters.AddWithValue("@p5", txtBookStock.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kitap başarılı bir şekilde eklendi");

            //HATALI
        }

        private void BookAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbkütüphaneOtomasyonuDataSet.TblWriter' table. You can move, or remove it, as needed.
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select WriterID, WriterName+' '+WriterSurname as WriterNameSurname from TblWriter", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            cmbWriter.ValueMember = "WriterID";
            cmbWriter.DisplayMember = "WriterNameSurname";
            cmbWriter.DataSource= datatable;
            connection.Close();

            connection.Open();
            SqlCommand command1 = new SqlCommand("select * from TblPublisher", connection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable datatable1 = new DataTable();
            adapter1.Fill(datatable1);
            cmbPublisher.ValueMember = "PublisherID";
            cmbPublisher.DisplayMember = "PublisherName";
            cmbPublisher.DataSource= datatable1;

            connection.Close();

        }

        private void BookAdd_Leave(object sender, EventArgs e)
        {
            Close();
        }
    }
}
