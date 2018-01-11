using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyHousing.Validation;

namespace MyHousing.Models
{
    public class SearchCondition
    {
        public virtual int Location { set; get; }
        public virtual int HouseType { set; get; }
        public virtual int BedroomFrom { set; get; }
        public virtual int BedroomTo { set; get; }
        public virtual int BathroomFrom { set; get; }
        public virtual int BathroomTo { set; get; }
        public virtual bool CarparkOk { get; set; }
        public virtual bool PetOk { set; get; }

        [Display(Name = "minimum price")]
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Invalid currency value")]
        public virtual decimal? PriceFrom { set; get; }

        [Display(Name = "maximum price")]
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Invalid currency value")]
        public virtual decimal? PriceTo { set; get; }

        [Display(Name = "check in date")]
        [Required(ErrorMessage = "Check in date is required")]
        // [ValidDatepicker]
        public virtual string CheckinDate { set; get; }

        [Display(Name = "check out date")]
        [Required(ErrorMessage = "Check out date is required")]
        // [ValidDatepicker]
        public virtual string CheckoutDate { set; get; }
    }
}