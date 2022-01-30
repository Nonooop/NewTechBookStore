
namespace NewTechBookStore
{
    partial class Data_Transaksi
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
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.cbIDBrg = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtKuantitas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbIDCust = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtUserBayangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.SuspendLayout();
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
            this.txtCari.Location = new System.Drawing.Point(481, 171);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtCari.PlaceholderText = "Cari";
            this.txtCari.SelectedText = "";
            this.txtCari.ShadowDecoration.Parent = this.txtCari;
            this.txtCari.Size = new System.Drawing.Size(215, 41);
            this.txtCari.TabIndex = 87;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(35, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 35);
            this.panel3.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(266, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "DATA TRANSAKSI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(35, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 35);
            this.panel2.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(264, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "FORM TRANSAKSI";
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.GridColor = System.Drawing.Color.White;
            this.dgvTransaksi.Location = new System.Drawing.Point(35, 266);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.Size = new System.Drawing.Size(661, 151);
            this.dgvTransaksi.TabIndex = 78;
            this.dgvTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaksi_CellClick);
            // 
            // cbIDBrg
            // 
            this.cbIDBrg.BackColor = System.Drawing.Color.Transparent;
            this.cbIDBrg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.cbIDBrg.BorderRadius = 10;
            this.cbIDBrg.BorderThickness = 2;
            this.cbIDBrg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIDBrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDBrg.FocusedColor = System.Drawing.Color.Empty;
            this.cbIDBrg.FocusedState.Parent = this.cbIDBrg;
            this.cbIDBrg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIDBrg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbIDBrg.FormattingEnabled = true;
            this.cbIDBrg.HoverState.Parent = this.cbIDBrg;
            this.cbIDBrg.ItemHeight = 35;
            this.cbIDBrg.ItemsAppearance.Parent = this.cbIDBrg;
            this.cbIDBrg.Location = new System.Drawing.Point(259, 117);
            this.cbIDBrg.Name = "cbIDBrg";
            this.cbIDBrg.ShadowDecoration.Parent = this.cbIDBrg;
            this.cbIDBrg.Size = new System.Drawing.Size(215, 41);
            this.cbIDBrg.TabIndex = 93;
            // 
            // txtKuantitas
            // 
            this.txtKuantitas.BackColor = System.Drawing.Color.Transparent;
            this.txtKuantitas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtKuantitas.BorderRadius = 10;
            this.txtKuantitas.BorderThickness = 2;
            this.txtKuantitas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKuantitas.DefaultText = "";
            this.txtKuantitas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKuantitas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKuantitas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKuantitas.DisabledState.Parent = this.txtKuantitas;
            this.txtKuantitas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKuantitas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKuantitas.FocusedState.Parent = this.txtKuantitas;
            this.txtKuantitas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKuantitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtKuantitas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKuantitas.HoverState.Parent = this.txtKuantitas;
            this.txtKuantitas.Location = new System.Drawing.Point(481, 116);
            this.txtKuantitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKuantitas.Name = "txtKuantitas";
            this.txtKuantitas.PasswordChar = '\0';
            this.txtKuantitas.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtKuantitas.PlaceholderText = "Kuantitas";
            this.txtKuantitas.SelectedText = "";
            this.txtKuantitas.ShadowDecoration.Parent = this.txtKuantitas;
            this.txtKuantitas.Size = new System.Drawing.Size(215, 42);
            this.txtKuantitas.TabIndex = 92;
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
            this.txtID.Location = new System.Drawing.Point(36, 67);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtID.PlaceholderText = "ID Transaksi";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(327, 42);
            this.txtID.TabIndex = 94;
            // 
            // cbIDCust
            // 
            this.cbIDCust.BackColor = System.Drawing.Color.Transparent;
            this.cbIDCust.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.cbIDCust.BorderRadius = 10;
            this.cbIDCust.BorderThickness = 2;
            this.cbIDCust.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIDCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDCust.FocusedColor = System.Drawing.Color.Empty;
            this.cbIDCust.FocusedState.Parent = this.cbIDCust;
            this.cbIDCust.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIDCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbIDCust.FormattingEnabled = true;
            this.cbIDCust.HoverState.Parent = this.cbIDCust;
            this.cbIDCust.ItemHeight = 35;
            this.cbIDCust.ItemsAppearance.Parent = this.cbIDCust;
            this.cbIDCust.Location = new System.Drawing.Point(35, 117);
            this.cbIDCust.Name = "cbIDCust";
            this.cbIDCust.ShadowDecoration.Parent = this.cbIDCust;
            this.cbIDCust.Size = new System.Drawing.Size(215, 41);
            this.cbIDCust.TabIndex = 97;
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
            this.btnRefresh.Location = new System.Drawing.Point(353, 170);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(115, 42);
            this.btnRefresh.TabIndex = 86;
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
            this.btnDelete.Location = new System.Drawing.Point(247, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(97, 42);
            this.btnDelete.TabIndex = 85;
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
            this.btnEdit.Location = new System.Drawing.Point(141, 170);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(97, 42);
            this.btnEdit.TabIndex = 84;
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
            this.btnAdd.Location = new System.Drawing.Point(36, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(97, 42);
            this.btnAdd.TabIndex = 82;
            this.btnAdd.Text = "TAMBAH";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUserBayangan
            // 
            this.txtUserBayangan.BackColor = System.Drawing.Color.Transparent;
            this.txtUserBayangan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtUserBayangan.BorderRadius = 10;
            this.txtUserBayangan.BorderThickness = 2;
            this.txtUserBayangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserBayangan.DefaultText = "";
            this.txtUserBayangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserBayangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserBayangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserBayangan.DisabledState.Parent = this.txtUserBayangan;
            this.txtUserBayangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserBayangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserBayangan.FocusedState.Parent = this.txtUserBayangan;
            this.txtUserBayangan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserBayangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtUserBayangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserBayangan.HoverState.Parent = this.txtUserBayangan;
            this.txtUserBayangan.Location = new System.Drawing.Point(371, 68);
            this.txtUserBayangan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserBayangan.Name = "txtUserBayangan";
            this.txtUserBayangan.PasswordChar = '\0';
            this.txtUserBayangan.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtUserBayangan.PlaceholderText = "Nama Pelayan";
            this.txtUserBayangan.ReadOnly = true;
            this.txtUserBayangan.SelectedText = "";
            this.txtUserBayangan.ShadowDecoration.Parent = this.txtUserBayangan;
            this.txtUserBayangan.Size = new System.Drawing.Size(327, 42);
            this.txtUserBayangan.TabIndex = 98;
            // 
            // txtIDUser
            // 
            this.txtIDUser.BackColor = System.Drawing.Color.Transparent;
            this.txtIDUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtIDUser.BorderRadius = 10;
            this.txtIDUser.BorderThickness = 2;
            this.txtIDUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDUser.DefaultText = "";
            this.txtIDUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDUser.DisabledState.Parent = this.txtIDUser;
            this.txtIDUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDUser.FocusedState.Parent = this.txtIDUser;
            this.txtIDUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.txtIDUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDUser.HoverState.Parent = this.txtIDUser;
            this.txtIDUser.Location = new System.Drawing.Point(371, 68);
            this.txtIDUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.PasswordChar = '\0';
            this.txtIDUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtIDUser.PlaceholderText = "Nama Pelayan";
            this.txtIDUser.ReadOnly = true;
            this.txtIDUser.SelectedText = "";
            this.txtIDUser.ShadowDecoration.Parent = this.txtIDUser;
            this.txtIDUser.Size = new System.Drawing.Size(327, 42);
            this.txtIDUser.TabIndex = 99;
            // 
            // Data_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 456);
            this.Controls.Add(this.txtIDUser);
            this.Controls.Add(this.txtUserBayangan);
            this.Controls.Add(this.cbIDCust);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cbIDBrg);
            this.Controls.Add(this.txtKuantitas);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTransaksi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Data_Transaksi";
            this.Text = "Data_Transaksi";
            this.Load += new System.EventHandler(this.Data_Transaksi_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private Guna.UI2.WinForms.Guna2ComboBox cbIDBrg;
        private Guna.UI2.WinForms.Guna2TextBox txtKuantitas;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2ComboBox cbIDCust;
        private Guna.UI2.WinForms.Guna2TextBox txtUserBayangan;
        private Guna.UI2.WinForms.Guna2TextBox txtIDUser;
    }
}