using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ado.NetDatabase.DAL;
using Ado.NetDatabase.Model;

namespace Ado.NetDatabase
{
    public partial class Form4 : Form
    {
        EmpDal empdal = new EmpDal();
        public Form4()
        {
            InitializeComponent();
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.Name = txtName.Text;
            emp.Salary = Convert.ToDouble(txtSalary.Text);
            int res = empdal.Save(emp);
            if (res == 1)
                MessageBox.Show("Inserted the record");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.Id = Convert.ToInt32(txtId.Text);
            emp.Name = txtName.Text;
            emp.Salary = Convert.ToDouble(txtSalary.Text);
            int res = empdal.Update(emp);
            if (res == 1)
                MessageBox.Show("updated the record");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int res = empdal.Delete(Convert.ToInt32(txtId.Text));
            if (res == 1)
                MessageBox.Show("deleted the record");

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataTable table = empdal.GetAllEmps();
            dataGridView1.DataSource = table;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                Emp emp = empdal.GetEmpById(Convert.ToInt32(txtId.Text));
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
