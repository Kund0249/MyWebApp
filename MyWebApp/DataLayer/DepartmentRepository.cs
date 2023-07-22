using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MyWebApp.BusinessLayer;

namespace MyWebApp.DataLayer
{
    public class DepartmentRepository
    {
        public int Save(Department department)
        {
            string cs = @"data source=.;database=EmployeeDB;trusted_connection=true;";
            //string query = "Insert into tblDepartment (DepartmentName) values('"+txtDepartmentName.Text+"')";
            //string query = string.Format("Insert into tblDepartment (DepartmentName) values('{0}')",txtDepartmentName.Text);
            string query = string.Format($"Insert into tblDepartment (DepartmentName) values('{department.DepartmentName}')");
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return row;
        }
    }
}