using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyHousing.Models
{
    public class RentCase
    {
        // Primary key
        public int RentCaseId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }

        // Foreign key 
        public int HouseStateId { get; set; }

        // Navigation property
        public virtual HouseState HouseState { get; set; }
    }
}