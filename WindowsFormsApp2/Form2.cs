using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
            this.ResizeEnd += Form2_ResizeEnd;
        }
        private void Form2_ResizeEnd(object sender, EventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            this.Text = width.ToString() + " - " + height.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            this.Text = width.ToString() +" - " + height.ToString();
        }
    }
}
