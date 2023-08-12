namespace WindowsFormsApp2
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRead = new System.Windows.Forms.Button();
            this.btDetele = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.lbma = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.tbld = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCustomer.Location = new System.Drawing.Point(38, 21);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(535, 150);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_RowEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(38, 267);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(97, 35);
            this.btRead.TabIndex = 1;
            this.btRead.Text = "Đọc dữ liệu";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btDetele
            // 
            this.btDetele.Location = new System.Drawing.Point(265, 267);
            this.btDetele.Name = "btDetele";
            this.btDetele.Size = new System.Drawing.Size(97, 35);
            this.btDetele.TabIndex = 2;
            this.btDetele.Text = "Xóa";
            this.btDetele.UseVisualStyleBackColor = true;
            this.btDetele.Click += new System.EventHandler(this.btDetele_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(471, 267);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(97, 35);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(162, 267);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(97, 35);
            this.btNew.TabIndex = 4;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(368, 267);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(97, 35);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Location = new System.Drawing.Point(35, 195);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(29, 16);
            this.lbma.TabIndex = 6;
            this.lbma.Text = "Mã ";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(35, 230);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(31, 16);
            this.lbten.TabIndex = 7;
            this.lbten.Text = "Tên";
            // 
            // tbld
            // 
            this.tbld.Location = new System.Drawing.Point(113, 192);
            this.tbld.Name = "tbld";
            this.tbld.Size = new System.Drawing.Size(127, 22);
            this.tbld.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(113, 227);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(455, 22);
            this.tbName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbld);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbma);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDetele);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btDetele;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Label lbma;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.TextBox tbld;
        private System.Windows.Forms.TextBox tbName;
    }
}

