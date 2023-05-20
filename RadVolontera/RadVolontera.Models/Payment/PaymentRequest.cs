﻿using RadVolontera.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadVolontera.Models.Payment
{
    public  class PaymentRequest
    {
        public string Notes { get; set; }
        public double Amount { get; set; }
        public Month Month { get; set; }
        public int Year { get; set; }
        public string StudentId { get; set; }
    }
}
