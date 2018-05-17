using Gold.Models.GoldModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gold.Models
{
    public class Saving
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime DateAdded { get; set; }
        public double SavingAmount { get; set; }
        public TimePeriod TimePeriod { get; set; }
    }
}