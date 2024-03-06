﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    //// TABLE Employees
    //[Table("EMPLOYEES")]
    public class Employee
    {
        public Employee()
        {
            Customers = new HashSet<Customer>();
            //Employees = new HashSet<Employee>();
        }
        [Key]
        public int EmployeeNumber {  get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string OfficeCode { get; set; }

        public ICollection<Customer> Customers { get; set; }
        //public ICollection<Employee> Employees { get; set; }
        public int? ReportTo { get; set; }
        public string JobTitle { get; set; }
    }
}
