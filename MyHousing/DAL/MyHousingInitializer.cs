using MyHousing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyHousing.DAL
{
    public class MyHousingInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MyHousingContext>
    {
        protected override void Seed(MyHousingContext context)
        {
            var houseStates = new List<HouseState>
            {
                new HouseState
                {
                    HouseStateId= 1,
                    HouseType = 1,
                    Postcode = "0600",
                    RentRate = 1.0m,
                    MainAddress = "6/14 Ambrico Place",
                    Suburb = "New Lynn",
                    Region = "Auckland",
                    Description = "My Auckland Address",
                    Bedroom = 3,
                    Bathroom = 2,
                    CarparkOk = true,
                    PetOk = false,
                    OnMarktetFlg = true,
                    Latitude = 0,
                    Longitude = 0
                },
                new HouseState
                {
                    HouseStateId= 2,
                    HouseType = 1,
                    Postcode = "8042",
                    RentRate = 1.0m,
                    MainAddress = "26 Valiant Street",
                    Suburb = "Wigram",
                    Region = "Christchurch",
                    Description = "My Christchurch Address",
                    Bedroom = 2,
                    Bathroom = 2,
                    CarparkOk = true,
                    PetOk = false,
                    OnMarktetFlg = true,
                    Latitude = 0,
                    Longitude = 0
                },
                new HouseState
                {
                    HouseStateId= 3,
                    HouseType = 1,
                    Postcode = "6037",
                    RentRate = 1.0m,
                    MainAddress = "11 Angell St",
                    Suburb = "Johnsonville",
                    Region = "Wellington",
                    Description = "My Wellington Address",
                    Bedroom = 4,
                    Bathroom = 2,
                    CarparkOk = true,
                    PetOk = false,
                    OnMarktetFlg = true,
                    Latitude = 0,
                    Longitude = 0
                }
            };
            houseStates.ForEach(s => context.HouseStates.Add(s));
            context.SaveChanges();

            var housePictures = new List<HousePicture>
            {
                new HousePicture
                {
                    HouseStateId = 1,
                    ImagePath = "put an image path of house 1 here",
                    MainImgFlg = true
                },
                new HousePicture
                {
                    HouseStateId = 1,
                    ImagePath = "put an image path of house 1 here",
                    MainImgFlg = true
                },
                new HousePicture
                {
                    HouseStateId = 2,
                    ImagePath = "put an image path of house 2 here",
                    MainImgFlg = true
                },
                new HousePicture
                {
                    HouseStateId = 2,
                    ImagePath = "put an image path of house 2 here",
                    MainImgFlg = true
                },
                new HousePicture
                {
                    HouseStateId = 3,
                    ImagePath = "put an image path of house 3 here",
                }
            };
            housePictures.ForEach(s => context.HousePictures.Add(s));
            context.SaveChanges();

            var rentCases = new List<RentCase>
            {
                new RentCase
                {
                    HouseStateId = 1,
                    StartDate = DateTime.Parse("2017-11-01"),
                    EndDate = DateTime.Parse("2017-11-03"),
                    UserId = 1
                },
                new RentCase
                {
                    HouseStateId = 2,
                    StartDate = DateTime.Parse("2017-11-04"),
                    EndDate = DateTime.Parse("2017-11-05"),
                    UserId = 1
                },
                new RentCase
                {
                    HouseStateId = 3,
                    StartDate = DateTime.Parse("2017-11-02"),
                    EndDate = DateTime.Parse("2017-11-04"),
                    UserId = 2
                },
                new RentCase
                {
                    HouseStateId = 1,
                    StartDate = DateTime.Parse("2017-11-20"),
                    EndDate = DateTime.Parse("2017-11-25"),
                    UserId = 3
                }
            };
            rentCases.ForEach(s => context.RentCases.Add(s));
            context.SaveChanges();
        }
    }
}