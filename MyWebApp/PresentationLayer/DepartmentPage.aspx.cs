using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWebApp.DataLayer;
using MyWebApp.BusinessLayer;

namespace MyWebApp.PresentationLayer
{
    public partial class DepartmentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Department department = new Department()
            {
                DepartmentName = txtDepartmentName.Text
            };


            DepartmentRepository repository = new DepartmentRepository();
            repository.Save(department);

            ClientScript.RegisterClientScriptBlock(this.GetType(), "Ms01", "alert('record inserted!')", true);

        }
    }
}