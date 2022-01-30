
namespace NewTechBookStore
{
    partial class Data_Buku
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPenulis = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.txtStok = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPenerbit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTahun = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtISBN = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(34, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 35);
            this.panel3.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(278, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "DATA BUKU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(34, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 35);
            this.panel2.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(276, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "FORM BUKU";
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.Transparent;
            this.txtCari.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtCari.BorderRadius = 10;
            this.txtCari.BorderThickness = 2;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.Parent = this.txtCari;
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.FocusedState.Parent = this.txtCari;
            this.txtCari.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.HoverState.Parent = this.txtCari;
            this.txtCari.Location = new System.Drawing.Point(480, 217);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtCari.PlaceholderText = "Cari";
            this.txtCari.SelectedText = "";
            this.txtCari.ShadowDecoration.Parent = this.txtCari;
            this.txtCari.Size = new System.Drawing.Size(215, 41);
            this.txtCari.TabIndex = 84;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.Transparent;
            this.txtNama.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtNama.BorderRadius = 10;
            this.txtNama.BorderThickness = 2;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.Parent = this.txtNama;
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.FocusedState.Parent = this.txtNama;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.HoverState.Parent = this.txtNama;
            this.txtNama.Location = new System.Drawing.Point(257, 65);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtNama.PlaceholderText = "Judul";
            this.txtNama.SelectedText = "";
            this.txtNama.ShadowDecoration.Parent = this.txtNama;
            this.txtNama.Size = new System.Drawing.Size(215, 42);
            this.txtNama.TabIndex = 82;
            // 
            // txtPenulis
            // 
            this.txtPenulis.BackColor = System.Drawing.Color.Transparent;
            this.txtPenulis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtPenulis.BorderRadius = 10;
            this.txtPenulis.BorderThickness = 2;
            this.txtPenulis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPenulis.DefaultText = "";
            this.txtPenulis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPenulis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPenulis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPenulis.DisabledState.Parent = this.txtPenulis;
            this.txtPenulis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPenulis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPenulis.FocusedState.Parent = this.txtPenulis;
            this.txtPenulis.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenulis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtPenulis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPenulis.HoverState.Parent = this.txtPenulis;
            this.txtPenulis.Location = new System.Drawing.Point(480, 65);
            this.txtPenulis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPenulis.Name = "txtPenulis";
            this.txtPenulis.PasswordChar = '\0';
            this.txtPenulis.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtPenulis.PlaceholderText = "Penulis";
            this.txtPenulis.SelectedText = "";
            this.txtPenulis.ShadowDecoration.Parent = this.txtPenulis;
            this.txtPenulis.Size = new System.Drawing.Size(215, 42);
            this.txtPenulis.TabIndex = 81;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtID.BorderRadius = 10;
            this.txtID.BorderThickness = 2;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(34, 65);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtID.PlaceholderText = "ID Pembeli";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(215, 42);
            this.txtID.TabIndex = 80;
            // 
            // dgvBuku
            // 
            this.dgvBuku.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuku.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.GridColor = System.Drawing.Color.White;
            this.dgvBuku.Location = new System.Drawing.Point(34, 314);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.Size = new System.Drawing.Size(661, 111);
            this.dgvBuku.TabIndex = 77;
            this.dgvBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuku_CellClick);
            // 
            // txtStok
            // 
            this.txtStok.BackColor = System.Drawing.Color.Transparent;
            this.txtStok.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtStok.BorderRadius = 10;
            this.txtStok.BorderThickness = 2;
            this.txtStok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStok.DefaultText = "";
            this.txtStok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStok.DisabledState.Parent = this.txtStok;
            this.txtStok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStok.FocusedState.Parent = this.txtStok;
            this.txtStok.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtStok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStok.HoverState.Parent = this.txtStok;
            this.txtStok.Location = new System.Drawing.Point(480, 165);
            this.txtStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStok.Name = "txtStok";
            this.txtStok.PasswordChar = '\0';
            this.txtStok.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtStok.PlaceholderText = "Stok";
            this.txtStok.SelectedText = "";
            this.txtStok.ShadowDecoration.Parent = this.txtStok;
            this.txtStok.Size = new System.Drawing.Size(215, 42);
            this.txtStok.TabIndex = 91;
            // 
            // txtPenerbit
            // 
            this.txtPenerbit.BackColor = System.Drawing.Color.Transparent;
            this.txtPenerbit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtPenerbit.BorderRadius = 10;
            this.txtPenerbit.BorderThickness = 2;
            this.txtPenerbit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPenerbit.DefaultText = "";
            this.txtPenerbit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPenerbit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPenerbit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPenerbit.DisabledState.Parent = this.txtPenerbit;
            this.txtPenerbit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPenerbit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPenerbit.FocusedState.Parent = this.txtPenerbit;
            this.txtPenerbit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenerbit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtPenerbit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPenerbit.HoverState.Parent = this.txtPenerbit;
            this.txtPenerbit.Location = new System.Drawing.Point(257, 115);
            this.txtPenerbit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.PasswordChar = '\0';
            this.txtPenerbit.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtPenerbit.PlaceholderText = "Penerbit";
            this.txtPenerbit.SelectedText = "";
            this.txtPenerbit.ShadowDecoration.Parent = this.txtPenerbit;
            this.txtPenerbit.Size = new System.Drawing.Size(215, 42);
            this.txtPenerbit.TabIndex = 90;
            // 
            // txtTahun
            // 
            this.txtTahun.BackColor = System.Drawing.Color.Transparent;
            this.txtTahun.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtTahun.BorderRadius = 10;
            this.txtTahun.BorderThickness = 2;
            this.txtTahun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTahun.DefaultText = "";
            this.txtTahun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTahun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTahun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahun.DisabledState.Parent = this.txtTahun;
            this.txtTahun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahun.FocusedState.Parent = this.txtTahun;
            this.txtTahun.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTahun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtTahun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahun.HoverState.Parent = this.txtTahun;
            this.txtTahun.Location = new System.Drawing.Point(34, 115);
            this.txtTahun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.PasswordChar = '\0';
            this.txtTahun.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtTahun.PlaceholderText = "Tahun";
            this.txtTahun.SelectedText = "";
            this.txtTahun.ShadowDecoration.Parent = this.txtTahun;
            this.txtTahun.Size = new System.Drawing.Size(215, 42);
            this.txtTahun.TabIndex = 89;
            // 
            // cbLevel
            // 
            this.cbLevel.BackColor = System.Drawing.Color.Transparent;
            this.cbLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.cbLevel.BorderRadius = 10;
            this.cbLevel.BorderThickness = 2;
            this.cbLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FocusedColor = System.Drawing.Color.Empty;
            this.cbLevel.FocusedState.Parent = this.cbLevel;
            this.cbLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.HoverState.Parent = this.cbLevel;
            this.cbLevel.ItemHeight = 35;
            this.cbLevel.Items.AddRange(new object[] {
            "Pilih Kategori",
            "Fiksi",
            "Non Fiksi"});
            this.cbLevel.ItemsAppearance.Parent = this.cbLevel;
            this.cbLevel.Location = new System.Drawing.Point(479, 115);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.ShadowDecoration.Parent = this.cbLevel;
            this.cbLevel.Size = new System.Drawing.Size(215, 41);
            this.cbLevel.TabIndex = 94;
            // 
            // txtHarga
            // 
            this.txtHarga.BackColor = System.Drawing.Color.Transparent;
            this.txtHarga.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtHarga.BorderRadius = 10;
            this.txtHarga.BorderThickness = 2;
            this.txtHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHarga.DefaultText = "";
            this.txtHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.DisabledState.Parent = this.txtHarga;
            this.txtHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.FocusedState.Parent = this.txtHarga;
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.HoverState.Parent = this.txtHarga;
            this.txtHarga.Location = new System.Drawing.Point(257, 164);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PasswordChar = '\0';
            this.txtHarga.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtHarga.PlaceholderText = "Harga";
            this.txtHarga.SelectedText = "";
            this.txtHarga.ShadowDecoration.Parent = this.txtHarga;
            this.txtHarga.Size = new System.Drawing.Size(215, 42);
            this.txtHarga.TabIndex = 93;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.Transparent;
            this.txtISBN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtISBN.BorderRadius = 10;
            this.txtISBN.BorderThickness = 2;
            this.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtISBN.DefaultText = "";
            this.txtISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.DisabledState.Parent = this.txtISBN;
            this.txtISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.FocusedState.Parent = this.txtISBN;
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.HoverState.Parent = this.txtISBN;
            this.txtISBN.Location = new System.Drawing.Point(34, 164);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PasswordChar = '\0';
            this.txtISBN.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtISBN.PlaceholderText = "ISBN";
            this.txtISBN.SelectedText = "";
            this.txtISBN.ShadowDecoration.Parent = this.txtISBN;
            this.txtISBN.Size = new System.Drawing.Size(215, 42);
            this.txtISBN.TabIndex = 92;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = global::NewTechBookStore.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(352, 217);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(115, 42);
            this.btnRefresh.TabIndex = 88;
            this.btnRefresh.Text = "SEGARKAN";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::NewTechBookStore.Properties.Resources.trash_can;
            this.btnDelete.Location = new System.Drawing.Point(246, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(97, 42);
            this.btnDelete.TabIndex = 87;
            this.btnDelete.Text = "HAPUS";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Image = global::NewTechBookStore.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(140, 217);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(97, 42);
            this.btnEdit.TabIndex = 86;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::NewTechBookStore.Properties.Resources.add__3_;
            this.btnAdd.Location = new System.Drawing.Point(35, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(97, 42);
            this.btnAdd.TabIndex = 85;
            this.btnAdd.Text = "TAMBAH";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Data_Buku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 456);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtPenerbit);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtPenulis);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvBuku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Data_Buku";
            this.Text = "Data_Buku";
            this.Load += new System.EventHandler(this.Data_Buku_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtPenulis;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.DataGridView dgvBuku;
        private Guna.UI2.WinForms.Guna2TextBox txtStok;
        private Guna.UI2.WinForms.Guna2TextBox txtPenerbit;
        private Guna.UI2.WinForms.Guna2TextBox txtTahun;
        private Guna.UI2.WinForms.Guna2ComboBox cbLevel;
        private Guna.UI2.WinForms.Guna2TextBox txtHarga;
        private Guna.UI2.WinForms.Guna2TextBox txtISBN;
    }
}