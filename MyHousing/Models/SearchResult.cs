using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHousing.Models
{
    public class SearchResult
    {
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
        // TODO: add price property here and in HouseState.cs    
    }
}