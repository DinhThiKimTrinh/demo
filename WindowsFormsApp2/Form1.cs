using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "@Data Source=NITRO5; Initial Catalog = sale; User Id = sa; Password=17092003";
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set Name='" + tbName.Text + "' where id =" + tbld.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows[idx].Cells[1].Value= tbName.Text;
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = NITRO5; Initial Catalog = sale; User Id = sa; Password = 17092003");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }
            conn.Close();

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=NITRO5; Initial Catalog=sale; User Id=sa; Password=17092003";
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into customer values("+tbld.Text+",'"+tbName.Text+"')",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            dgvCustomer.Rows.Add(tbld.Text, tbName.Text);
        }

        private void btDetele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString="Data Source=NITRO5; Initial Catalog=sale; User Id=sa; Password=17092003";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from Customer where id = 5";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = NITRO5; Initial Catalog = sale; User Id = sa; Password = 17092003");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }
            conn.Close();
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbld.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
        }

    }
}
