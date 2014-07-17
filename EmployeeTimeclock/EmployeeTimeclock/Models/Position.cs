using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTimeclock.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string PositionTitle { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}