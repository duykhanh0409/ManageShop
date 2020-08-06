namespace Shop_Project_WinForm
{
    partial class UserDanhMucSP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDanhMucSP));
            this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.dtg1 = new Guna.UI.WinForms.GunaDataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtennhom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txmanhom = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton11 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton10 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton9 = new Guna.UI.WinForms.GunaButton();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button12
            // 
            this.guna2Button12.BorderRadius = 13;
            this.guna2Button12.CheckedState.Parent = this.guna2Button12;
            this.guna2Button12.CustomImages.Parent = this.guna2Button12;
            this.guna2Button12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.guna2Button12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button12.ForeColor = System.Drawing.Color.White;
            this.guna2Button12.HoverState.Parent = this.guna2Button12;
            this.guna2Button12.Location = new System.Drawing.Point(193, 2);
            this.guna2Button12.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button12.Name = "guna2Button12";
            this.guna2Button12.ShadowDecoration.Parent = this.guna2Button12;
            this.guna2Button12.Size = new System.Drawing.Size(346, 49);
            this.guna2Button12.TabIndex = 22;
            this.guna2Button12.Text = "Danh Mục Sản Phẩm";
            // 
            // dtg1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtg1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg1.BackgroundColor = System.Drawing.Color.White;
            this.dtg1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg1.ColumnHeadersHeight = 44;
            this.dtg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.TenNhom});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg1.EnableHeadersVisualStyles = false;
            this.dtg1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg1.Location = new System.Drawing.Point(11, 276);
            this.dtg1.Margin = new System.Windows.Forms.Padding(2);
            this.dtg1.Name = "dtg1";
            this.dtg1.ReadOnly = true;
            this.dtg1.RowHeadersVisible = false;
            this.dtg1.RowHeadersWidth = 51;
            this.dtg1.RowTemplate.Height = 45;
            this.dtg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg1.Size = new System.Drawing.Size(806, 175);
            this.dtg1.TabIndex = 23;
            this.dtg1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtg1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtg1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtg1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtg1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtg1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtg1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtg1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtg1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg1.ThemeStyle.HeaderStyle.Height = 44;
            this.dtg1.ThemeStyle.ReadOnly = true;
            this.dtg1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg1.ThemeStyle.RowsStyle.Height = 45;
            this.dtg1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg1_CellClick);
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã Nhóm";
            this.MaNhom.MinimumWidth = 6;
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.ReadOnly = true;
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Tên Nhóm";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.ReadOnly = true;
            // 
            // txtennhom
            // 
            this.txtennhom.BorderRadius = 15;
            this.txtennhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtennhom.DefaultText = "";
            this.txtennhom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtennhom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtennhom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtennhom.DisabledState.Parent = this.txtennhom;
            this.txtennhom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtennhom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtennhom.FocusedState.Parent = this.txtennhom;
            this.txtennhom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtennhom.HoverState.Parent = this.txtennhom;
            this.txtennhom.Location = new System.Drawing.Point(111, 153);
            this.txtennhom.Name = "txtennhom";
            this.txtennhom.PasswordChar = '\0';
            this.txtennhom.PlaceholderText = "tên nhóm";
            this.txtennhom.SelectedText = "";
            this.txtennhom.ShadowDecoration.Parent = this.txtennhom;
            this.txtennhom.Size = new System.Drawing.Size(231, 25);
            this.txtennhom.TabIndex = 27;
            // 
            // txmanhom
            // 
            this.txmanhom.BorderRadius = 15;
            this.txmanhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txmanhom.DefaultText = "";
            this.txmanhom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txmanhom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txmanhom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txmanhom.DisabledState.Parent = this.txmanhom;
            this.txmanhom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txmanhom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txmanhom.FocusedState.Parent = this.txmanhom;
            this.txmanhom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txmanhom.HoverState.Parent = this.txmanhom;
            this.txmanhom.Location = new System.Drawing.Point(111, 114);
            this.txmanhom.Name = "txmanhom";
            this.txmanhom.PasswordChar = '\0';
            this.txmanhom.PlaceholderText = "mã nhóm";
            this.txmanhom.SelectedText = "";
            this.txmanhom.ShadowDecoration.Parent = this.txmanhom;
            this.txmanhom.Size = new System.Drawing.Size(231, 25);
            this.txmanhom.TabIndex = 26;
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel14.Location = new System.Drawing.Point(28, 159);
            this.gunaLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(63, 15);
            this.gunaLabel14.TabIndex = 25;
            this.gunaLabel14.Text = "Tên Nhóm";
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel13.Location = new System.Drawing.Point(28, 115);
            this.gunaLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel13.TabIndex = 24;
            this.gunaLabel13.Text = "Mã Nhóm";
            // 
            // gunaButton11
            // 
            this.gunaButton11.AnimationHoverSpeed = 0.07F;
            this.gunaButton11.AnimationSpeed = 0.03F;
            this.gunaButton11.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.gunaButton11.BorderColor = System.Drawing.Color.Black;
            this.gunaButton11.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaButton11.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton11.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton11.ForeColor = System.Drawing.Color.White;
            this.gunaButton11.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton11.Image")));
            this.gunaButton11.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaButton11.Location = new System.Drawing.Point(613, 100);
            this.gunaButton11.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton11.Name = "gunaButton11";
            this.gunaButton11.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaButton11.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton11.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton11.OnHoverImage = null;
            this.gunaButton11.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton11.Radius = 10;
            this.gunaButton11.Size = new System.Drawing.Size(182, 39);
            this.gunaButton11.TabIndex = 32;
            this.gunaButton11.Text = "XÓA";
            this.gunaButton11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton11.Click += new System.EventHandler(this.gunaButton11_Click);
            // 
            // gunaButton10
            // 
            this.gunaButton10.AnimationHoverSpeed = 0.07F;
            this.gunaButton10.AnimationSpeed = 0.03F;
            this.gunaButton10.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton10.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.gunaButton10.BorderColor = System.Drawing.Color.Black;
            this.gunaButton10.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaButton10.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton10.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton10.ForeColor = System.Drawing.Color.White;
            this.gunaButton10.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton10.Image")));
            this.gunaButton10.ImageSize = new System.Drawing.Size(45, 45);
            this.gunaButton10.Location = new System.Drawing.Point(409, 100);
            this.gunaButton10.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton10.Name = "gunaButton10";
            this.gunaButton10.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaButton10.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton10.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton10.OnHoverImage = null;
            this.gunaButton10.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton10.Radius = 10;
            this.gunaButton10.Size = new System.Drawing.Size(182, 39);
            this.gunaButton10.TabIndex = 31;
            this.gunaButton10.Text = "THÊM";
            this.gunaButton10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton10.Click += new System.EventHandler(this.gunaButton10_Click);
            // 
            // gunaButton9
            // 
            this.gunaButton9.AnimationHoverSpeed = 0.07F;
            this.gunaButton9.AnimationSpeed = 0.03F;
            this.gunaButton9.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.gunaButton9.BorderColor = System.Drawing.Color.Black;
            this.gunaButton9.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaButton9.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton9.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton9.ForeColor = System.Drawing.Color.White;
            this.gunaButton9.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton9.Image")));
            this.gunaButton9.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaButton9.Location = new System.Drawing.Point(409, 165);
            this.gunaButton9.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton9.Name = "gunaButton9";
            this.gunaButton9.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaButton9.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton9.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton9.OnHoverImage = null;
            this.gunaButton9.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton9.Radius = 10;
            this.gunaButton9.Size = new System.Drawing.Size(182, 39);
            this.gunaButton9.TabIndex = 30;
            this.gunaButton9.Text = "SỬA";
            this.gunaButton9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton9.Click += new System.EventHandler(this.gunaButton9_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(380, 62);
            this.guna2VSeparator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(8, 187);
            this.guna2VSeparator1.TabIndex = 28;
            this.guna2VSeparator1.Click += new System.EventHandler(this.guna2VSeparator1_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaButton1.Location = new System.Drawing.Point(613, 165);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(182, 39);
            this.gunaButton1.TabIndex = 33;
            this.gunaButton1.Text = "LƯU";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(409, 72);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(108, 10);
            this.gunaSeparator1.TabIndex = 69;
            this.gunaSeparator1.Thickness = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Chức năng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(661, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // UserDanhMucSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaButton11);
            this.Controls.Add(this.gunaButton10);
            this.Controls.Add(this.gunaButton9);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.txtennhom);
            this.Controls.Add(this.txmanhom);
            this.Controls.Add(this.gunaLabel14);
            this.Controls.Add(this.gunaLabel13);
            this.Controls.Add(this.dtg1);
            this.Controls.Add(this.guna2Button12);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserDanhMucSP";
            this.Size = new System.Drawing.Size(837, 470);
            this.Load += new System.EventHandler(this.UserDanhMucSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button12;
        private Guna.UI.WinForms.GunaDataGridView dtg1;
        private Guna.UI2.WinForms.Guna2TextBox txtennhom;
        private Guna.UI2.WinForms.Guna2TextBox txmanhom;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaButton gunaButton11;
        private Guna.UI.WinForms.GunaButton gunaButton10;
        private Guna.UI.WinForms.GunaButton gunaButton9;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
