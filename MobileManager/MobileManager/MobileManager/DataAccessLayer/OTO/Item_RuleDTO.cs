using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.OTO
{
    public class Item_RuleDTO
    {
        public int RuleId { get; set; }
        public int ItemId { get; set; }
        public byte IsShow { get; set; }

        public Item_RuleDTO() { }
    }
}