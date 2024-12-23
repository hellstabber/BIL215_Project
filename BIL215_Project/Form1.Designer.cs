namespace BIL215_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUrunleriYenile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.txUrunSil = new System.Windows.Forms.TextBox();
            this.txUrunFiyati = new System.Windows.Forms.TextBox();
            this.txUrunIsmi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIL215_ProjeDataSet = new BIL215_Project.BIL215_ProjeDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRezervasyonSil = new System.Windows.Forms.Button();
            this.txRezervasyonSil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRezervasyonlariYenile = new System.Windows.Forms.Button();
            this.btnRezervasyonEkle = new System.Windows.Forms.Button();
            this.txRezervasyonKisiSayisi = new System.Windows.Forms.TextBox();
            this.txRezervasyonMusteriTarih = new System.Windows.Forms.TextBox();
            this.txRezervasyonMusteriIsmi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfGuestsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIL215_ProjeDataSet1 = new BIL215_Project.BIL215_ProjeDataSet1();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAdisyonSil = new System.Windows.Forms.Button();
            this.txAdisyonSil = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdisyonYenile = new System.Windows.Forms.Button();
            this.txAdisyonEkle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdisyonEkle = new System.Windows.Forms.Button();
            this.clAdisyonListesi = new System.Windows.Forms.CheckedListBox();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.txSiparisEkle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIL215_ProjeDataSet2 = new BIL215_Project.BIL215_ProjeDataSet2();
            this.menuItemsTableAdapter = new BIL215_Project.BIL215_ProjeDataSetTableAdapters.MenuItemsTableAdapter();
            this.reservationsTableAdapter = new BIL215_Project.BIL215_ProjeDataSet1TableAdapters.ReservationsTableAdapter();
            this.ordersTableAdapter = new BIL215_Project.BIL215_ProjeDataSet2TableAdapters.OrdersTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIL215_ProjeDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIL215_ProjeDataSet1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIL215_ProjeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaGreen;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnUrunleriYenile);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnUrunSil);
            this.tabPage1.Controls.Add(this.txUrunSil);
            this.tabPage1.Controls.Add(this.txUrunFiyati);
            this.tabPage1.Controls.Add(this.txUrunIsmi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnUrunEkle);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1139, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnUrunleriYenile
            // 
            this.btnUrunleriYenile.Location = new System.Drawing.Point(422, 419);
            this.btnUrunleriYenile.Name = "btnUrunleriYenile";
            this.btnUrunleriYenile.Size = new System.Drawing.Size(141, 23);
            this.btnUrunleriYenile.TabIndex = 9;
            this.btnUrunleriYenile.Text = "Ürünleri Yenile";
            this.btnUrunleriYenile.UseVisualStyleBackColor = true;
            this.btnUrunleriYenile.Click += new System.EventHandler(this.btnUrunleriYenile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(760, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Silinecek Ürün:";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(940, 55);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(75, 23);
            this.btnUrunSil.TabIndex = 7;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click_1);
            // 
            // txUrunSil
            // 
            this.txUrunSil.Location = new System.Drawing.Point(859, 6);
            this.txUrunSil.Name = "txUrunSil";
            this.txUrunSil.Size = new System.Drawing.Size(156, 22);
            this.txUrunSil.TabIndex = 6;
            // 
            // txUrunFiyati
            // 
            this.txUrunFiyati.Location = new System.Drawing.Point(509, 27);
            this.txUrunFiyati.Name = "txUrunFiyati";
            this.txUrunFiyati.Size = new System.Drawing.Size(156, 22);
            this.txUrunFiyati.TabIndex = 5;
            // 
            // txUrunIsmi
            // 
            this.txUrunIsmi.Location = new System.Drawing.Point(509, 3);
            this.txUrunIsmi.Name = "txUrunIsmi";
            this.txUrunIsmi.Size = new System.Drawing.Size(156, 22);
            this.txUrunIsmi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürünün Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürünün İsmi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(590, 55);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.basePriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menuItemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(407, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // basePriceDataGridViewTextBoxColumn
            // 
            this.basePriceDataGridViewTextBoxColumn.DataPropertyName = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.HeaderText = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.basePriceDataGridViewTextBoxColumn.Name = "basePriceDataGridViewTextBoxColumn";
            this.basePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuItemsBindingSource
            // 
            this.menuItemsBindingSource.DataMember = "MenuItems";
            this.menuItemsBindingSource.DataSource = this.bIL215_ProjeDataSet;
            // 
            // bIL215_ProjeDataSet
            // 
            this.bIL215_ProjeDataSet.DataSetName = "BIL215_ProjeDataSet";
            this.bIL215_ProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaGreen;
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.btnRezervasyonSil);
            this.tabPage2.Controls.Add(this.txRezervasyonSil);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnRezervasyonlariYenile);
            this.tabPage2.Controls.Add(this.btnRezervasyonEkle);
            this.tabPage2.Controls.Add(this.txRezervasyonKisiSayisi);
            this.tabPage2.Controls.Add(this.txRezervasyonMusteriTarih);
            this.tabPage2.Controls.Add(this.txRezervasyonMusteriIsmi);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1139, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btnRezervasyonSil
            // 
            this.btnRezervasyonSil.Location = new System.Drawing.Point(997, 55);
            this.btnRezervasyonSil.Name = "btnRezervasyonSil";
            this.btnRezervasyonSil.Size = new System.Drawing.Size(136, 23);
            this.btnRezervasyonSil.TabIndex = 11;
            this.btnRezervasyonSil.Text = "Rezervasyon Sil";
            this.btnRezervasyonSil.UseVisualStyleBackColor = true;
            this.btnRezervasyonSil.Click += new System.EventHandler(this.btnRezervasyonSil_Click);
            // 
            // txRezervasyonSil
            // 
            this.txRezervasyonSil.Location = new System.Drawing.Point(1070, 24);
            this.txRezervasyonSil.Name = "txRezervasyonSil";
            this.txRezervasyonSil.Size = new System.Drawing.Size(63, 22);
            this.txRezervasyonSil.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(958, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Rezervasyon ID:";
            // 
            // btnRezervasyonlariYenile
            // 
            this.btnRezervasyonlariYenile.Location = new System.Drawing.Point(567, 419);
            this.btnRezervasyonlariYenile.Name = "btnRezervasyonlariYenile";
            this.btnRezervasyonlariYenile.Size = new System.Drawing.Size(165, 23);
            this.btnRezervasyonlariYenile.TabIndex = 8;
            this.btnRezervasyonlariYenile.Text = "Rezarvasyonları Yenile";
            this.btnRezervasyonlariYenile.UseVisualStyleBackColor = true;
            this.btnRezervasyonlariYenile.Click += new System.EventHandler(this.btnRezervasyonlariYenile_Click);
            // 
            // btnRezervasyonEkle
            // 
            this.btnRezervasyonEkle.Location = new System.Drawing.Point(743, 118);
            this.btnRezervasyonEkle.Name = "btnRezervasyonEkle";
            this.btnRezervasyonEkle.Size = new System.Drawing.Size(136, 23);
            this.btnRezervasyonEkle.TabIndex = 7;
            this.btnRezervasyonEkle.Text = "Ekle";
            this.btnRezervasyonEkle.UseVisualStyleBackColor = true;
            this.btnRezervasyonEkle.Click += new System.EventHandler(this.btnRezervasyonEkle_Click);
            // 
            // txRezervasyonKisiSayisi
            // 
            this.txRezervasyonKisiSayisi.Location = new System.Drawing.Point(712, 80);
            this.txRezervasyonKisiSayisi.Name = "txRezervasyonKisiSayisi";
            this.txRezervasyonKisiSayisi.Size = new System.Drawing.Size(167, 22);
            this.txRezervasyonKisiSayisi.TabIndex = 6;
            this.txRezervasyonKisiSayisi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txRezervasyonMusteriTarih
            // 
            this.txRezervasyonMusteriTarih.Location = new System.Drawing.Point(712, 52);
            this.txRezervasyonMusteriTarih.Name = "txRezervasyonMusteriTarih";
            this.txRezervasyonMusteriTarih.Size = new System.Drawing.Size(167, 22);
            this.txRezervasyonMusteriTarih.TabIndex = 5;
            // 
            // txRezervasyonMusteriIsmi
            // 
            this.txRezervasyonMusteriIsmi.Location = new System.Drawing.Point(712, 24);
            this.txRezervasyonMusteriIsmi.Name = "txRezervasyonMusteriIsmi";
            this.txRezervasyonMusteriIsmi.Size = new System.Drawing.Size(167, 22);
            this.txRezervasyonMusteriIsmi.TabIndex = 4;
            this.txRezervasyonMusteriIsmi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kişi Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rezervasyon Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Müşterinin İsmi:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationID,
            this.customerNameDataGridViewTextBoxColumn,
            this.reservationDateDataGridViewTextBoxColumn,
            this.numberOfGuestsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.reservationsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(555, 436);
            this.dataGridView2.TabIndex = 0;
            // 
            // ReservationID
            // 
            this.ReservationID.DataPropertyName = "ReservationID";
            this.ReservationID.HeaderText = "ReservationID";
            this.ReservationID.MinimumWidth = 6;
            this.ReservationID.Name = "ReservationID";
            this.ReservationID.ReadOnly = true;
            this.ReservationID.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationDateDataGridViewTextBoxColumn
            // 
            this.reservationDateDataGridViewTextBoxColumn.DataPropertyName = "ReservationDate";
            this.reservationDateDataGridViewTextBoxColumn.HeaderText = "ReservationDate";
            this.reservationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationDateDataGridViewTextBoxColumn.Name = "reservationDateDataGridViewTextBoxColumn";
            this.reservationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfGuestsDataGridViewTextBoxColumn
            // 
            this.numberOfGuestsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfGuests";
            this.numberOfGuestsDataGridViewTextBoxColumn.HeaderText = "NumberOfGuests";
            this.numberOfGuestsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfGuestsDataGridViewTextBoxColumn.Name = "numberOfGuestsDataGridViewTextBoxColumn";
            this.numberOfGuestsDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "Reservations";
            this.reservationsBindingSource.DataSource = this.bIL215_ProjeDataSet1;
            // 
            // bIL215_ProjeDataSet1
            // 
            this.bIL215_ProjeDataSet1.DataSetName = "BIL215_ProjeDataSet1";
            this.bIL215_ProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SeaGreen;
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.btnAdisyonSil);
            this.tabPage3.Controls.Add(this.txAdisyonSil);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btnAdisyonYenile);
            this.tabPage3.Controls.Add(this.txAdisyonEkle);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnAdisyonEkle);
            this.tabPage3.Controls.Add(this.clAdisyonListesi);
            this.tabPage3.Controls.Add(this.btnSiparisEkle);
            this.tabPage3.Controls.Add(this.txSiparisEkle);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1139, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnAdisyonSil
            // 
            this.btnAdisyonSil.Location = new System.Drawing.Point(573, 133);
            this.btnAdisyonSil.Name = "btnAdisyonSil";
            this.btnAdisyonSil.Size = new System.Drawing.Size(188, 23);
            this.btnAdisyonSil.TabIndex = 11;
            this.btnAdisyonSil.Text = "Sipariş Sil";
            this.btnAdisyonSil.UseVisualStyleBackColor = true;
            this.btnAdisyonSil.Click += new System.EventHandler(this.btnAdisyonSil_Click);
            // 
            // txAdisyonSil
            // 
            this.txAdisyonSil.Location = new System.Drawing.Point(679, 92);
            this.txAdisyonSil.Name = "txAdisyonSil";
            this.txAdisyonSil.Size = new System.Drawing.Size(82, 22);
            this.txAdisyonSil.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(570, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "ReservationsID:";
            // 
            // btnAdisyonYenile
            // 
            this.btnAdisyonYenile.Location = new System.Drawing.Point(570, 418);
            this.btnAdisyonYenile.Name = "btnAdisyonYenile";
            this.btnAdisyonYenile.Size = new System.Drawing.Size(139, 23);
            this.btnAdisyonYenile.TabIndex = 8;
            this.btnAdisyonYenile.Text = "Adisyon Yenile";
            this.btnAdisyonYenile.UseVisualStyleBackColor = true;
            this.btnAdisyonYenile.Click += new System.EventHandler(this.btnAdisyonYenile_Click);
            // 
            // txAdisyonEkle
            // 
            this.txAdisyonEkle.Location = new System.Drawing.Point(995, 130);
            this.txAdisyonEkle.Name = "txAdisyonEkle";
            this.txAdisyonEkle.Size = new System.Drawing.Size(128, 22);
            this.txAdisyonEkle.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(929, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Order ID:";
            // 
            // btnAdisyonEkle
            // 
            this.btnAdisyonEkle.Location = new System.Drawing.Point(932, 161);
            this.btnAdisyonEkle.Name = "btnAdisyonEkle";
            this.btnAdisyonEkle.Size = new System.Drawing.Size(191, 23);
            this.btnAdisyonEkle.TabIndex = 5;
            this.btnAdisyonEkle.Text = "Adisyona Ekle";
            this.btnAdisyonEkle.UseVisualStyleBackColor = true;
            this.btnAdisyonEkle.Click += new System.EventHandler(this.btnAdisyonEkle_Click);
            // 
            // clAdisyonListesi
            // 
            this.clAdisyonListesi.FormattingEnabled = true;
            this.clAdisyonListesi.Location = new System.Drawing.Point(932, 6);
            this.clAdisyonListesi.Name = "clAdisyonListesi";
            this.clAdisyonListesi.Size = new System.Drawing.Size(191, 106);
            this.clAdisyonListesi.TabIndex = 4;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(570, 41);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(191, 23);
            this.btnSiparisEkle.TabIndex = 3;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // txSiparisEkle
            // 
            this.txSiparisEkle.Location = new System.Drawing.Point(679, 13);
            this.txSiparisEkle.Name = "txSiparisEkle";
            this.txSiparisEkle.Size = new System.Drawing.Size(82, 22);
            this.txSiparisEkle.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "ReservationsID: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.reservationIDDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.ordersBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(555, 436);
            this.dataGridView3.TabIndex = 0;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.bIL215_ProjeDataSet2;
            // 
            // bIL215_ProjeDataSet2
            // 
            this.bIL215_ProjeDataSet2.DataSetName = "BIL215_ProjeDataSet2";
            this.bIL215_ProjeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuItemsTableAdapter
            // 
            this.menuItemsTableAdapter.ClearBeforeFill = true;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BIL215_Project.Properties.Resources.backhouse1;
            this.pictureBox1.Location = new System.Drawing.Point(883, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BIL215_Project.Properties.Resources.backhouse1;
            this.pictureBox2.Location = new System.Drawing.Point(883, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BIL215_Project.Properties.Resources.backhouse1;
            this.pictureBox3.Location = new System.Drawing.Point(883, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(256, 256);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 501);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIL215_ProjeDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIL215_ProjeDataSet1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIL215_ProjeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BIL215_ProjeDataSet bIL215_ProjeDataSet;
        private System.Windows.Forms.BindingSource menuItemsBindingSource;
        private BIL215_ProjeDataSetTableAdapters.MenuItemsTableAdapter menuItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txUrunIsmi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txUrunFiyati;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.TextBox txUrunSil;
        private System.Windows.Forms.Button btnUrunleriYenile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BIL215_ProjeDataSet1 bIL215_ProjeDataSet1;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private BIL215_ProjeDataSet1TableAdapters.ReservationsTableAdapter reservationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfGuestsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRezervasyonEkle;
        private System.Windows.Forms.TextBox txRezervasyonKisiSayisi;
        private System.Windows.Forms.TextBox txRezervasyonMusteriTarih;
        private System.Windows.Forms.TextBox txRezervasyonMusteriIsmi;
        private System.Windows.Forms.Button btnRezervasyonlariYenile;
        private System.Windows.Forms.TextBox txRezervasyonSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRezervasyonSil;
        private System.Windows.Forms.DataGridView dataGridView3;
        private BIL215_ProjeDataSet2 bIL215_ProjeDataSet2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private BIL215_ProjeDataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.TextBox txSiparisEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clAdisyonListesi;
        private System.Windows.Forms.Button btnAdisyonEkle;
        private System.Windows.Forms.TextBox txAdisyonEkle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdisyonYenile;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdisyonSil;
        private System.Windows.Forms.TextBox txAdisyonSil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

