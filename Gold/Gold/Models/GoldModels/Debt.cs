using Gold.Models.GoldModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gold.Models
{
    public class Debt
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DatePaid { get; set; }
        public double RepaymentAmount { get; set; }
        public TimePeriod TimePeriod { get; set; }
    }

    public class DebtViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Amount")]
        public string Amount { get; set; }

        [Display(Name = "RepaymentAmount")]
        public string RepaymentAmount { get; set; }
    }
}