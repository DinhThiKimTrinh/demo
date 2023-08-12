using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CustomerDAL:BDConnection 
    { 
        public List<CustomerBEL> ReadCustomer()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CustomerBEL> lstCus = new List<CustomerBEL>();
            while (reader.Read())
            {
                CustomerBEL cus = new CustomerBEL();
                cus.Id = int.Parse(reader["id"].ToString() );
                cus.Name = reader["name"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void DeleteCustomer(CustomerBEL customer)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Customer where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", customer.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer values(@id, @name)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditCustomer(CustomerBEL cus) {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set Name(@id, @name)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

}
