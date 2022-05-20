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
    class StudentDal
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
    
    public StudentDal()
    {
        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        con = new SqlConnection(constr);
    }
        public DataTable GetAllStudents()
        {
            DataTable table = new DataTable();
            string qry = "select * from Student";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            table.Load(dr);
            con.Close();
            return table;
        }
        public StudentNew GetStudentNewByRollNo(int rollno)
        {
            StudentNew stud = new StudentNew();
            string qry = "select * from Student where RollNo=@rollno";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@rollno",rollno);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    stud.RollNo = Convert.ToInt32(dr["RollNo"]);
                    stud.Name = dr["Name"].ToString();
                    stud.Branch = dr["Branch"].ToString();
                    stud.Percentage = Convert.ToSingle(dr["Percentage"]);
                }
            }
            con.Close();
            return stud;
        }
        public int Save(StudentNew stud)
        {

            string qry = "insert into Student values(@name,@branch,@percentage)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@name",stud.Name);
            cmd.Parameters.AddWithValue("@branch", stud.Branch);
            cmd.Parameters.AddWithValue("@percentage", stud.Percentage);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int Update(StudentNew stud)
        {
            string qry = "update Student set Name=@name,Branch=@Branch,Percentage=@percentage where RollNo=@rollno";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@name", stud.Name);
            cmd.Parameters.AddWithValue("@branch", stud.Branch);
            cmd.Parameters.AddWithValue("@percentage", stud.Percentage);
            cmd.Parameters.AddWithValue("@rollno", stud.RollNo);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int Delete(int rollno)
        {
            string qry = "delete from Student where RollNo=@rollno";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@rollno", rollno);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}

