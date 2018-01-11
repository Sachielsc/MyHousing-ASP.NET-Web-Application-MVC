using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHousing.Models
{
    public class SearchOption
    {
        public int SearchOptionId { get; set; }
        public string GroupName { get; set; }
        public int ItemValue { get; set; }
        public string ItemName { get; set; }
    }
}