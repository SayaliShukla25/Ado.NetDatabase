using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ado.NetDatabase.DAL;
using Ado.NetDatabase.Model;

namespace Ado.NetDatabase
{
    public partial class Form6 : Form
    {
       
        ProductDal proddal = new ProductDal();
        public Form6()
        {
            InitializeComponent();
        }
       private void btnSave_Click(object sender, EventArgs e)
        {
            ProductNew prod = new ProductNew();
            prod.Name = txtProductName.Text;
            prod.Price = Convert.ToInt32(txtPrice.Text);
            int res = proddal.Save(prod);
            if (res == 1)
                MessageBox.Show("Inserted the record"); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductNew prod = new ProductNew();
            prod.Id = Convert.ToInt32(txtProductId.Text);
            prod.Name = txtProductName.Text;
            prod.Price = Convert.ToInt32(txtPrice.Text);
            int res = proddal.Update(prod);
            if (res == 1)
                MessageBox.Show("updated the record");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int res = proddal.Delete(Convert.ToInt32(txtProductId.Text));
            if (res == 1)
                MessageBox.Show("deleted the record");
        }

        private void btnShowAllProducts_Click(object sender, EventArgs e)
        {
            DataTable table = proddal.GetAllProducts();
            dataGridView1.DataSource = table;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ProductNew prod = proddal.GetProductNewById(Convert.ToInt32(txtProductId.Text));
                txtProductName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
