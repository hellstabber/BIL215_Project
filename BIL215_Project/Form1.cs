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

namespace BIL215_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bIL215_ProjeDataSet.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.bIL215_ProjeDataSet.MenuItems);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;";
            string urunIsmi = txUrunIsmi.Text;
            string urunFiyat = txUrunFiyati.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO MenuItems (ItemName, BasePrice) VALUES (@ItemName, @BasePrice)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", urunIsmi);
                    command.Parameters.AddWithValue("@BasePrice", urunFiyat);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            MessageBox.Show("Ürün başarıyla kaydedildi.");
        }

        private void btnUrunSil_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;";
            string urunSil = txUrunSil.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM MenuItems WHERE ItemName = @ItemName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", urunSil);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            MessageBox.Show("Ürün başarıyla silindi.");
        }

        private void btnUrunleriYenile_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MenuItems"; 
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                //dataGridView.DataSource = dataTable;
            }
        }
    }
}
