using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyHousing.Models
{
    public class HouseState
    {
        // Primary key
        [Display(Name = "HouseStateId (Manual Generated)")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HouseStateId { get; set; }

        public string HouseName { get; set; }
        public int HouseType { get; set; }
        public string Postcode { get; set; }
        public decimal RentRate { get; set; }
        public string MainAddress { get; set; }
        public string Suburb { get; set; }
        public string Region { get; set; }
        public string Description { get; set; }
        public int? Bedroom { get; set; }
        public int? Bathroom { get; set; }
        public bool? CarparkOk { get; set; }
        public bool? PetOk { get; set; }
        public bool? OnMarktetFlg { get; set; }
        public int? Latitude { get; set; }
        public int? Longitude { get; set; }

        // Navigation properties
        public virtual IList<HousePicture> HousePictures { get; set; }
        public virtual IList<RentCase> RentCases { get; set; }
    }
}