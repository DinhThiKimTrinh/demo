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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng kí thành công");
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            frm2 = null;
            this.Show();
        }
    }
}
