using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTimeclock.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }

        public virtual Position PositionID { get; set; }
    }
}