﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTimeclock.Models
{
    public class Timesheet
    {
        public int TimesheetId { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public int DailyHours { get; set; }
        
        public virtual Employee Employee { get; set; }
    }
}