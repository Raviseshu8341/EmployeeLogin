using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeLogin.Models
{
    public class Model
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public long EmployeePhoneNo { get; set; }
        public bool IsPermenent { get; set; }
    }
}