using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.OTO
{
    public class WeekdayItem_RuleDTO
    {
        public int Id { get; set; }
        public int RuleId { get; set; }
        public int Day { get; set; }

        public WeekdayItem_RuleDTO() { }
    }
}