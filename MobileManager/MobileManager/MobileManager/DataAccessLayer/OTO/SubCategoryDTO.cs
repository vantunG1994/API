using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.OTO
{
    public class SubCategoryDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public SubCategoryDTO() { }
    }
}