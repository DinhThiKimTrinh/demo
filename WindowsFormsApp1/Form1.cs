using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "" || tbten.Text == "" || tbtuoi.Text == "" /*|| dvgEmployee.CurrentCell == null*/)
            {
                MessageBox.Show("Bạn chưa nhập mã", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                dvgEmployee.Rows.Add(tbid.Text, tbten.Text, tbtuoi.Text, cbnam.Checked);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            }
            tbid.Text = "";
            tbten.Text = "";
            tbtuoi.Text = "";
            //cbnam.Checked = true;

        }



        private void btxoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn xóa");
            int idx = dvgEmployee.CurrentCell.RowIndex;
            dvgEmployee.Rows.RemoveAt(idx);
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát");
            Application.Exit();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "" || tbten.Text == "" || tbtuoi.Text == "" || dvgEmployee.CurrentCell == null)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int idx = dvgEmployee.CurrentCell.RowIndex;
                dvgEmployee.Rows[idx].Cells[0].Value = tbid.Text;
                dvgEmployee.Rows[idx].Cells[1].Value = tbten.Text;
                dvgEmployee.Rows[idx].Cells[2].Value = tbtuoi.Text;
                dvgEmployee.Rows[idx].Cells[3].Value = cbnam.Checked;
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dvgEmployee_SelectionChanged(object sender, EventArgs e)
        {
            index = dvgEmployee.CurrentCell.RowIndex;
            //DataTable id = (DataTable) dvgEmployee.DataSource;
            //if(index.Rows.Count > 0)
            {
                tbid.Text = dvgEmployee.Rows[index].Cells[0].Value.ToString();
                tbten.Text = dvgEmployee.Rows[index].Cells[1].Value.ToString();
                tbtuoi.Text = dvgEmployee.Rows[index].Cells[2].Value.ToString();
                //cbnam.Text = dvgEmployee.Rows[index].Cells[3].Value.ToString();
            }    
        }

        //private void dvgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
            //if (e.RowIndex > 0)
            //{
            //    DataGridViewRow row = this.dvgEmployee.Rows[e.RowIndex];
            //    string s = row.Cells[3].Value.ToString();
            //    if(s == "nam")
            //    {
            //        cbnam.Checked = true;
            //    }    
            //    else
            //        cbnam.Checked = true;
            //}   
        //}

        //private void btFile_Click(object sender, EventArgs e)
        //{
        //    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
        //    pbImage.ImageLocation = @"d:\abc.jpg";

        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.Title = "Open Image";
        //    dlg.Filter = "JPEG files (*.jpg)|*.jpg";
        //    if (dlg.ShowDialog() == DialogResult.OK)
        //    {
        //        pbImage.ImageLocation = dlg.FileName;
        //    }    
        //}
    }
}
