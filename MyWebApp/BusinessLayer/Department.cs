using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.BusinessLayer
{
    public class Department
    {
        public int DepartmentId { get; set; }

        private string _DepartmentName;
        public string DepartmentName
        {
            get { return _DepartmentName; }
            set
            {
                if (!(string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value)) && value.Length <= 15)
                {
                    _DepartmentName = value;
                }
                else
                {
                    throw new Exception("Invalid value for the property DepartmentName");
                }
            }
        }
    }
}