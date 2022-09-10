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
    public partial class WriterAdd : Form
    {
        public WriterAdd()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");

        private void btnSave_Click(object sender, EventArgs e)
        {
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblWriter (BookName, WriterID, PublisherID, BookTotalPage, BookStock) values (@p1,@p2,@p3,@p4,@p5)", connection);
            //command.Parameters.AddWithValue("@p1", txtBookName.Text);
            //command.Parameters.AddWithValue("@p2", txtWriterName.Text);
            //command.Parameters.AddWithValue("@p3", txtPublisherName.Text);
            //command.Parameters.AddWithValue("@p4", txtTotalPage.Text);
            //command.Parameters.AddWithValue("@p5", txtBookStock.Text);
            //command.ExecuteNonQuery();
            //connection.Close();
            //MessageBox.Show("Kitap başarılı bir şekilde eklendi");
        }
    }
}
