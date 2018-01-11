using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyHousing.Models
{
    public class HousePicture
    {
        // Primary key
        public int HousePictureId { get; set; }

        public string ImagePath { get; set; }
        public bool? MainImgFlg { get; set; }

        // Foreign key 
        public int HouseStateId { get; set; }

        // Navigation property
        public virtual HouseState HouseState { get; set; }
    }
}