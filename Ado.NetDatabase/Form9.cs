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
    public partial class Form9 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public Form9()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(constr);

        }
        public DataSet GetStudents()
        {
            da = new SqlDataAdapter("select * from Student", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "stud");
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ds = GetStudents();
            DataRow row = ds.Tables["stud"].NewRow();
            row["Name"] = txtName.Text;
            row["Branch"] = txtBranch.Text;
            row["Percentage"] = txtPercentage.Text;
            ds.Tables["stud"].Rows.Add(row);
            int res = da.Update(ds.Tables["stud"]);
            if (res == 1)
                MessageBox.Show("Record saved");


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds = GetStudents();
            DataRow row = ds.Tables["stud"].Rows.Find(Convert.ToInt32(txtRollNo.Text));
            if (row != null)
            {
                txtName.Text = row["Name"].ToString();
                txtBranch.Text = row["Branch"].ToString();
                txtPercentage.Text = row["Percentage"].ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            float Percentage = Convert.ToSingle(txtPercentage.Text);
            if (string.IsNullOrEmpty(txtName.Text) && Percentage > 0)
            {
                MessageBox.Show("Enter name or price should be greater than 0");
            }
            else
            {

                ds = GetStudents();
                // Find() method only work with PK col in the dataset
                DataRow row = ds.Tables["stud"].Rows.Find(Convert.ToInt32(txtRollNo.Text));
                if (row != null)
                {
                    row["Name"] = txtName.Text;
                    row["Branch"] = txtBranch.Text;
                    row["Percentage"] = txtPercentage.Text;
                    int res = da.Update(ds.Tables["stud"]);
                    if (res == 1)
                        MessageBox.Show("record updated");
                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ds = GetStudents();

            DataRow row = ds.Tables["stud"].Rows.Find(Convert.ToInt32(txtRollNo.Text));
            if (row != null)
            {
                row.Delete();
                int res = da.Update(ds.Tables["stud"]);
                if (res == 1)
                    MessageBox.Show("record deleted");
            }
            else
            {
                MessageBox.Show("Record not found");
            }

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
