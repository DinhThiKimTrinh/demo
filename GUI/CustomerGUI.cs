using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class CustomerGUI : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();
        public CustomerGUI()
        {
            InitializeComponent();
        }

        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            foreach(CustomerBEL cus in lstCus)
            {
                dgvCustomer.Rows.Add(cus.Id, cus.Name);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;

            cusBAL.NewCustomer(cus);
            dgvCustomer.Rows.Add(cus.Id, cus.Name);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;

            cusBAL.DeleteCustomer(cus);
            int index = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(index);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = (CustomerBEL)bsCus.Current;
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;

            cusBAL.EditCustomer(cus);
            DataGridViewRow row = dgvCustomer.CurrentRow;
            row.Cells[0].Value = cus.Id;
            row.Cells[1].Value = cus.Name;
        }
    }

}
