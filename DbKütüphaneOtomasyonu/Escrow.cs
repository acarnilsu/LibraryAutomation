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
    public partial class Escrow : Form
    {
        public Escrow()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");
        public void EscrowDeliveryDetailsList()
        {
            SqlCommand command = new SqlCommand("Select * From EscrowDeliveryDetails", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            EscrowDeliveryDetailsList();
        }

        string escrowID;
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblEscrow (StudentID,BookID,EscrowDate) values (@p1,@p2,@p3)", connection);
            command.Parameters.AddWithValue("@p1", cmbUserName.SelectedValue);
            command.Parameters.AddWithValue("@p2", cmbBookName.SelectedValue);
            command.Parameters.AddWithValue("@p3", DateTime.Parse(dateTimeEscrow.Text));
            command.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand command2 = new SqlCommand("select Top(1) EscrowID from TblEscrow order by EscrowID desc", connection);
            SqlDataReader dataReader = command2.ExecuteReader();
            while (dataReader.Read())
            {
                escrowID=dataReader[0].ToString();
            }
            connection.Close();

            connection.Open();
            SqlCommand command1 = new SqlCommand("insert into TblDelivery(DeliveryID,StudentID,BookID,DeliveryDate) values (@p1,@p2,@p3,@p4)", connection);
            command1.Parameters.AddWithValue("@p1", escrowID.ToString());
            command1.Parameters.AddWithValue("@p2", cmbUserName.SelectedValue);
            command1.Parameters.AddWithValue("@p3", cmbBookName.SelectedValue);
            command1.Parameters.AddWithValue("@p4", DateTime.Parse(dateTimeDelivery.Text));
            command1.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Başarıyla eklendi", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            EscrowDeliveryDetailsList();
        }

        private void Escrow_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select StudentID, StudentName+' '+StudentSurname as StudentNameSurname from TblStudent", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            cmbUserName.ValueMember = "StudentID";
            cmbUserName.DisplayMember = "StudentNameSurname";
            cmbUserName.DataSource = datatable;
            connection.Close();

            connection.Open();
            SqlCommand command1 = new SqlCommand("select * from TblBook", connection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable datatable1 = new DataTable();
            adapter1.Fill(datatable1);
            cmbBookName.ValueMember = "BookID";
            cmbBookName.DisplayMember = "BookName";
            cmbBookName.DataSource = datatable1;
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");
            connection.Open();
            SqlCommand command1 = new SqlCommand("Delete from TblDelivery Where DeliveryID = @p1", connection);
            command1.Parameters.AddWithValue("@p1", txtEscrowID.Text);
            command1.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand command = new SqlCommand("Delete from TblEscrow Where EscrowID = @p1", connection);
            command.Parameters.AddWithValue("@p1", txtEscrowID.Text);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EscrowDeliveryDetailsList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbkütüphaneOtomasyonu; User Id=sa;Password=1234;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("update TblEscrow set StudentID=@p2, BookID=@p3, EscrowDate=@p4 where EscrowID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtEscrowID.Text);
            command.Parameters.AddWithValue("@p2", cmbUserName.SelectedValue);
            command.Parameters.AddWithValue("@p3", cmbBookName.SelectedValue);
            command.Parameters.AddWithValue("@p4", DateTime.Parse(dateTimeEscrow.Text));
            command.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand command1 = new SqlCommand("update TblDelivery set StudentID=@p2, BookID=@p3, DeliveryDate=@p4 where DeliveryID=@p1", connection);
            command1.Parameters.AddWithValue("@p1", txtEscrowID.Text);
            command1.Parameters.AddWithValue("@p2", cmbUserName.SelectedValue);
            command1.Parameters.AddWithValue("@p3", cmbBookName.SelectedValue);
            command1.Parameters.AddWithValue("@p4", DateTime.Parse(dateTimeDelivery.Text));
            command1.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EscrowDeliveryDetailsList();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // tıklanan kitabın idsini alcaz
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            // soldaki textboxları doldurcaz
            txtEscrowID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            cmbUserName.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            cmbBookName.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            dateTimeEscrow.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            dateTimeDelivery.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
