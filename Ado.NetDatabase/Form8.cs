using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.NetDatabase
{
    public partial class Form8 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public Form8()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(constr);

        }
        public DataSet GetProducts()
        {
            da = new SqlDataAdapter("select * from Product", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "product");
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ds = GetProducts();
            DataRow row = ds.Tables["product"].NewRow();
            row["Name"] = txtProductName.Text;
            row["Price"] = txtPrice.Text;
            ds.Tables["product"].Rows.Add(row);
            int res = da.Update(ds.Tables["product"]);
            if (res == 1)
                MessageBox.Show("Record saved");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds = GetProducts();
            DataRow row = ds.Tables["product"].Rows.Find(Convert.ToInt32(txtProductId.Text));
            if (row != null)
            {
                txtProductName.Text = row["Name"].ToString();
                txtPrice.Text = row["Price"].ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          int price = Convert.ToInt32(txtPrice.Text);
            if (string.IsNullOrEmpty(txtProductName.Text) && price > 0)
            {
                MessageBox.Show("Enter name or price should be greater than 0");
            }
            else
            {

                ds = GetProducts();
                // Find() method only work with PK col in the dataset
                DataRow row = ds.Tables["product"].Rows.Find(Convert.ToInt32(txtProductId.Text));
                if (row != null)
                {
                    row["Name"] = txtProductName.Text;
                    row["Price"] = txtPrice.Text;
                    int res = da.Update(ds.Tables["product"]);
                    if (res == 1)
                        MessageBox.Show("record updated");
                }
            }
        }
           private void btnDelete_Click(object sender, EventArgs e)
        {
            ds = GetProducts();

            DataRow row = ds.Tables["product"].Rows.Find(Convert.ToInt32(txtProductId.Text));
            if (row != null)
            {
                row.Delete();
                int res = da.Update(ds.Tables["product"]);
                if (res == 1)
                    MessageBox.Show("record deleted");
            }
            else
            {
                MessageBox.Show("Record not found");
            }

        }
    }
}
