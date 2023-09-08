namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; set; }  = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "montreal",
                    Description = "quebec",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id =1,
                            Name = "name 1",
                            Description = "description 1" 
                        },

                        new PointOfInterestDto()
                        {
                            Id =2,
                            Name = "name 2",
                            Description = "description 2"
                        }
                    }
                },

                new CityDto()
                {
                    Id = 2,
                    Name = "yaounde",
                    Description = "cameroun",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id =3,
                            Name = "name 3",
                            Description = "description 3"
                        },

                        new PointOfInterestDto()
                        {
                            Id =4,
                            Name = "name 4",
                            Description = "description 4"
                        }
                    }
                },

                new CityDto()
                {
                    Id = 3,
                    Name = "new york", 
                    Description = "usa",
                     PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id =5,
                            Name = "name 5",
                            Description = "description 5"
                        },

                        new PointOfInterestDto()
                        {
                            Id =6,
                            Name = "name 6",
                            Description = "description 6"
                        }
                    }
                }
            };
        }
    }
}
