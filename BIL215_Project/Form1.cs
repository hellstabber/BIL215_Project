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
using ClosedXML.Excel;




namespace BIL215_Project
{
    public partial class Form1 : Form
    {
        private Dictionary<int, string> menuItemsDictionary = new Dictionary<int, string>();

        public Form1()
        {
            InitializeComponent();
            btnAdisyonEkle.Click += new EventHandler(btnAdisyonEkle_Click);
            btnAdisyonSil.Click += new EventHandler(btnAdisyonSil_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateAdisyonListesi();

            //Tab isimlerini değiştir
            tabControl1.TabPages[0].Text = "Ürünler";
            tabControl1.TabPages[1].Text = "Rezervasyon";
            tabControl1.TabPages[2].Text = "Adisyonlar";
            tabControl1.TabPages[3].Text = "Yedekleme";
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

        private void btnRezervasyonEkle_Click(object sender, EventArgs e)
        {
            string connectionString =
                "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;"; // Replace with your actual database name
            string customerName = txRezervasyonMusteriIsmi.Text;
            DateTime reservationDate = DateTime.Parse(txRezervasyonMusteriTarih.Text);
            int numberOfGuests = int.Parse(txRezervasyonKisiSayisi.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                    "INSERT INTO Reservations (CustomerName, ReservationDate, NumberOfGuests) VALUES (@CustomerName, @ReservationDate, @NumberOfGuests)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@ReservationDate", reservationDate);
                    command.Parameters.AddWithValue("@NumberOfGuests", numberOfGuests);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            MessageBox.Show("Rezervasyon kaydedildi.");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRezervasyonlariYenile_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Reservations";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
                //dataGridView.DataSource = dataTable;
            }
        }

        private void btnRezervasyonSil_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;";
            string rezervasyonSil = txRezervasyonSil.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Reservations WHERE ReservationID = @ReservationID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationID", rezervasyonSil);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            MessageBox.Show("Rezervasyon başarıyla silindi.");
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;";
            int reservationID = int.Parse(txSiparisEkle.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Orders (ReservationID) VALUES (@ReservationID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationID", reservationID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            MessageBox.Show("Sipariş başarıyla oluşturuldu.");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PopulateAdisyonListesi()
        {
            string connectionString = "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MenuItemID, ItemName FROM MenuItems";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int menuItemID = (int)reader["MenuItemID"];
                            string itemName = reader["ItemName"].ToString();
                            menuItemsDictionary.Add(menuItemID, itemName);
                            clAdisyonListesi.Items.Add(itemName);
                        }
                    }

                    connection.Close();
                }
            }
        }

        private void btnAdisyonEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;";
            int reservationID = int.Parse(txAdisyonEkle.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var item in clAdisyonListesi.CheckedItems)
                {
                    string itemName = item.ToString();
                    int menuItemID = menuItemsDictionary.FirstOrDefault(x => x.Value == itemName).Key;
                    string query =
                        "INSERT INTO OrderDetails (OrderID, MenuItemID, Quantity, Price) VALUES (@OrderID, @MenuItemID, @Quantity, (SELECT BasePrice FROM MenuItems WHERE MenuItemID = @MenuItemID))";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", reservationID);
                        command.Parameters.AddWithValue("@MenuItemID", menuItemID);
                        command.Parameters.AddWithValue("@Quantity", 1);

                        command.ExecuteNonQuery();
                    }
                }

                // Update the TotalAmount in the Orders table
                string updateQuery = @"
                    UPDATE Orders
                    SET TotalAmount = (
                        SELECT SUM(Price * Quantity) FROM OrderDetails WHERE OrderID = @OrderID
                    )
                    WHERE OrderID = @OrderID";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@OrderID", reservationID);
                    updateCommand.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        private object CreateMenuItem(int menuItemID, string itemName)
        {
            return new
            {
                MenuItemID = menuItemID,
                ItemName = itemName,
                ToString = (Func<string>)(() => itemName)
            };
        }

        private void btnAdisyonYenile_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Orders";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView3.DataSource = dataTable;
                //dataGridView.DataSource = dataTable;
            }
        }

        private void btnAdisyonSil_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;";
            int orderID = int.Parse(txAdisyonSil.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Delete from OrderDetails first to maintain referential integrity
                string deleteOrderDetailsQuery = "DELETE FROM OrderDetails WHERE OrderID = @OrderID";
                using (SqlCommand deleteOrderDetailsCommand = new SqlCommand(deleteOrderDetailsQuery, connection))
                {
                    deleteOrderDetailsCommand.Parameters.AddWithValue("@OrderID", orderID);
                    deleteOrderDetailsCommand.ExecuteNonQuery();
                }

                // Delete from Orders
                string deleteOrderQuery = "DELETE FROM Orders WHERE OrderID = @OrderID";
                using (SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, connection))
                {
                    deleteOrderCommand.Parameters.AddWithValue("@OrderID", orderID);
                    deleteOrderCommand.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("Adisyon başarıyla silindi.");
        }

        private void btnYedekAl_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP\\SQLEXPRESS;Database=BIL215_Proje;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var workbook = new XLWorkbook())
                {
                    // Export MenuItems table
                    var menuItemsTable = new DataTable();
                    using (var command = new SqlCommand("SELECT * FROM MenuItems", connection))
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(menuItemsTable);
                    }

                    var menuItemsSheet = workbook.Worksheets.Add(menuItemsTable, "MenuItems");

                    // Export Reservations table
                    var reservationsTable = new DataTable();
                    using (var command = new SqlCommand("SELECT * FROM Reservations", connection))
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(reservationsTable);
                    }

                    var reservationsSheet = workbook.Worksheets.Add(reservationsTable, "Reservations");

                    // Export Orders table
                    var ordersTable = new DataTable();
                    using (var command = new SqlCommand("SELECT * FROM Orders", connection))
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(ordersTable);
                    }

                    var ordersSheet = workbook.Worksheets.Add(ordersTable, "Orders");

                    // Export OrderDetails table
                    var orderDetailsTable = new DataTable();
                    using (var command = new SqlCommand("SELECT * FROM OrderDetails", connection))
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(orderDetailsTable);
                    }

                    var orderDetailsSheet = workbook.Worksheets.Add(orderDetailsTable, "OrderDetails");

                    // Save the workbook
                    string filePath = "DatabaseExport.xlsx";
                    workbook.SaveAs(filePath);

                    MessageBox.Show("Veritabanı başarıyla Excel dosyasına aktarıldı: " + filePath);
                }

                connection.Close();
            }
        }
    }
}
