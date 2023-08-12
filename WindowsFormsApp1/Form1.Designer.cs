namespace WindowsFormsApp1
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
            this.gbthongtin = new System.Windows.Forms.GroupBox();
            this.lbhinh = new System.Windows.Forms.Label();
            this.btFile = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.cbnam = new System.Windows.Forms.CheckBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.tbtuoi = new System.Windows.Forms.TextBox();
            this.tbten = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgEmployee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbnu = new System.Windows.Forms.CheckBox();
            this.gbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // gbthongtin
            // 
            this.gbthongtin.Controls.Add(this.lbhinh);
            this.gbthongtin.Controls.Add(this.btFile);
            this.gbthongtin.Controls.Add(this.pbImage);
            this.gbthongtin.Controls.Add(this.cbnam);
            this.gbthongtin.Controls.Add(this.cbnu);
            this.gbthongtin.Controls.Add(this.btthoat);
            this.gbthongtin.Controls.Add(this.btsua);
            this.gbthongtin.Controls.Add(this.btxoa);
            this.gbthongtin.Controls.Add(this.btthem);
            this.gbthongtin.Controls.Add(this.tbtuoi);
            this.gbthongtin.Controls.Add(this.tbten);
            this.gbthongtin.Controls.Add(this.tbid);
            this.gbthongtin.Controls.Add(this.label3);
            this.gbthongtin.Controls.Add(this.label2);
            this.gbthongtin.Controls.Add(this.label1);
            this.gbthongtin.Controls.Add(this.dvgEmployee);
            this.gbthongtin.Location = new System.Drawing.Point(23, 26);
            this.gbthongtin.Name = "gbthongtin";
            this.gbthongtin.Size = new System.Drawing.Size(1027, 468);
            this.gbthongtin.TabIndex = 0;
            this.gbthongtin.TabStop = false;
            this.gbthongtin.Text = "groupBox1";
            // 
            // lbhinh
            // 
            this.lbhinh.AutoSize = true;
            this.lbhinh.Location = new System.Drawing.Point(391, 254);
            this.lbhinh.Name = "lbhinh";
            this.lbhinh.Size = new System.Drawing.Size(53, 16);
            this.lbhinh.TabIndex = 15;
            this.lbhinh.Text = "Ảnh 3x4";
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(461, 416);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(138, 36);
            this.btFile.TabIndex = 14;
            this.btFile.Text = "Chọn hình...";
            this.btFile.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(461, 240);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(138, 150);
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // cbnam
            // 
            this.cbnam.AutoSize = true;
            this.cbnam.Location = new System.Drawing.Point(60, 362);
            this.cbnam.Name = "cbnam";
            this.cbnam.Size = new System.Drawing.Size(58, 20);
            this.cbnam.TabIndex = 12;
            this.cbnam.Text = "Nam";
            this.cbnam.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.Color.Pink;
            this.btthoat.Location = new System.Drawing.Point(290, 429);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(81, 33);
            this.btthoat.TabIndex = 10;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btsua
            // 
            this.btsua.BackColor = System.Drawing.Color.Pink;
            this.btsua.Location = new System.Drawing.Point(197, 429);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(87, 33);
            this.btsua.TabIndex = 0;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.Color.Pink;
            this.btxoa.Location = new System.Drawing.Point(108, 429);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(83, 33);
            this.btxoa.TabIndex = 9;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.Color.Pink;
            this.btthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btthem.Location = new System.Drawing.Point(17, 429);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(85, 33);
            this.btthem.TabIndex = 8;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // tbtuoi
            // 
            this.tbtuoi.Location = new System.Drawing.Point(60, 320);
            this.tbtuoi.Name = "tbtuoi";
            this.tbtuoi.Size = new System.Drawing.Size(241, 22);
            this.tbtuoi.TabIndex = 7;
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(60, 278);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(241, 22);
            this.tbten.TabIndex = 6;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(60, 234);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(241, 22);
            this.tbid.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tuổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            // 
            // dvgEmployee
            // 
            this.dvgEmployee.AllowUserToAddRows = false;
            this.dvgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.id,
            this.Column3});
            this.dvgEmployee.Location = new System.Drawing.Point(17, 21);
            this.dvgEmployee.Name = "dvgEmployee";
            this.dvgEmployee.RowHeadersWidth = 51;
            this.dvgEmployee.RowTemplate.Height = 24;
            this.dvgEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgEmployee.Size = new System.Drawing.Size(733, 202);
            this.dvgEmployee.TabIndex = 0;
            this.dvgEmployee.SelectionChanged += new System.EventHandler(this.dvgEmployee_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // id
            // 
            this.id.HeaderText = "Tuổi";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới tính (Nam)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // cbnu
            // 
            this.cbnu.AutoSize = true;
            this.cbnu.Location = new System.Drawing.Point(197, 362);
            this.cbnu.Name = "cbnu";
            this.cbnu.Size = new System.Drawing.Size(46, 20);
            this.cbnu.TabIndex = 11;
            this.cbnu.Text = "Nữ";
            this.cbnu.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 506);
            this.Controls.Add(this.gbthongtin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbthongtin.ResumeLayout(false);
            this.gbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbthongtin;
        private System.Windows.Forms.DataGridView dvgEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtuoi;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.CheckBox cbnam;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbhinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.CheckBox cbnu;
    }
}

