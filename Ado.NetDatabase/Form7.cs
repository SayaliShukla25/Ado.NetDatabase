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
    public partial class Form7 : Form
    {
        StudentDal studdal = new StudentDal();
        public Form7()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentNew stud = new StudentNew();

            stud.Name = txtName.Text;
            stud.Branch = txtBranch.Text;
            stud.Percentage = Convert.ToSingle(txtPercentage.Text);
            int res = studdal.Save(stud);
            if (res == 1)
                MessageBox.Show("Inserted the record");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

             try
            {
                StudentNew stud = studdal.GetStudentNewByRollNo(Convert.ToInt32(txtRollNo.Text));
                txtName.Text = stud.Name;
                txtBranch.Text = stud.Branch;
                txtPercentage.Text = stud.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentNew stud = new StudentNew();
            stud.RollNo = Convert.ToInt32(txtRollNo.Text);
            stud.Name = txtName.Text;
            stud.Branch = txtBranch.Text;
            stud.Percentage = Convert.ToSingle(txtPercentage.Text);
            int res = studdal.Update(stud);
            if (res == 1)
                MessageBox.Show("updated the record");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int res = studdal.Delete(Convert.ToInt32(txtRollNo.Text));
            if (res == 1)
                MessageBox.Show("deleted the record");

        }

        private void btnShowAllStudentDetails_Click(object sender, EventArgs e)
        {
            DataTable table = studdal.GetAllStudents();
            dataGridView1.DataSource = table;

        }
    }
}
