using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonDN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập thành công");
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            frm3 = null;
            this.Show();
        }
    }
}
