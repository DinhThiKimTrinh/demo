using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        string path = @"D:\form.xml";
        public Form3()
        {
            InitializeComponent();
        }
        private void Write(InfoWindows iw)
        {
            XmlSerializer write = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            write.Serialize(file, iw);
            file.Close();
        }


        private void Form3_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Width;
            iw.Height = this.Height;
            Write(iw);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Width;
            iw.Height = this.Height;
            Write(iw);
        }
    }
}
