using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ado.NetDatabase.DAL;
using Ado.NetDatabase.Model;

namespace Ado.NetDatabase.DAL
{
    class ProductDal
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public ProductDal()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(constr);
        }
        public DataTable GetAllProducts()
        {
            DataTable table = new DataTable();
            string qry = "select * from Product";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            table.Load(dr);
            con.Close();
            return table;
        }

        public ProductNew GetProductNewById(int id)
        {
            ProductNew prod = new ProductNew();
            string qry = "select * from Product where Id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows) // existance of record in dr object
            {
                while (dr.Read())
                {
                    prod.Id = Convert.ToInt32(dr["Id"]);
                    prod.Name = dr["Name"].ToString();
                    prod.Price = Convert.ToInt32(dr["Price"]);
                }
            }
            con.Close();
            return prod;
        }
        public int Save(ProductNew prod)
        {

            string qry = "insert into Product values(@name,@price)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Price);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int Update(ProductNew prod)
        {

            string qry = "update Product set Name=@name,Price=@price where Id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", prod.Id);
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Price);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int Delete(int id)
        {
            string qry = "delete from Product where Id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}