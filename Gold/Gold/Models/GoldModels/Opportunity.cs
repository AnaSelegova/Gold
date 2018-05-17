using Gold.Models.GoldModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gold.Models
{
    public class Opportunity
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public double Interest { get; set; }
        public double Risk { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Profit { get; set; }
        public TimePeriod TimePeriod { get; set; }
    }
}