﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class Payment
    {
        // TABLE Payments

        // TODO : Foreign Key que apunta a CustomerNumeber en la TABEL Customers
        //private int CustomerNumber { get; set; }

        public string CheckNumber {  get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}