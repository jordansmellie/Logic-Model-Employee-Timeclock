using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTimeclock.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string First { get; set; }
        public string Last { get; set; }

        public virtual Position PositionID { get; set; }

        public virtual ICollection<Timesheet> Timesheets { get; set; }
    }
}