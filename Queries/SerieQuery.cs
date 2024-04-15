using GraphAPI.Models;
namespace GraphAPI.Queries
{
    public class SerieQuery
    {
        public Serie GetSerie()
        {
            return new Serie
            {
                Name = "Young Sheldon",
                Season = 8,
                ReleaseDate = DateTime.UtcNow.AddDays(-10),
                Platform = new List<Platform>
                {
                    new Platform    
                    {
                        Name = "Paramaunt+",
                        Followers = 10000
                    },
                    new Platform
                    {
                        Name = "Netflix",
                        Followers = 1000
                    },
                    new Platform
                    {
                        Name = "Amazon Prime Video",
                        Followers = 1
                    }
                }
                
            }; 
        }
        public List<Serie> GetSeries()
        {
            List<Serie> series = new List<Serie>
            {
                new Serie
                {
                    Id = 1,
                    Name = "Invencible",
                    Season = 2,
                    ReleaseDate = DateTime.UtcNow.AddDays(-10),
                    Platform = new List<Platform>
                    {
                        new Platform
                        {
                            Name = "Amazon Prime Video",
                            Followers = 2000
                        },
                        new Platform
                        {
                            Name = "Netflix",
                            Followers = 100
                        }
                    }
                },
                new Serie
                {
                    Id = 2,
                    Name = "Peaky Blinders",
                    Season = 6,
                    ReleaseDate = DateTime.UtcNow.AddDays(-20),
                    Platform = new List<Platform>
                    {
                        new Platform
                        {
                            Name = "Netflix",
                            Followers = 8000
                        },
                        new Platform
                        {
                            Name = "BBC",
                            Followers = 900
                        }
                    }
                },
                new Serie
                {
                    Id = 3,
                    Name = "Fallout",
                    Season = 1,
                    ReleaseDate = DateTime.UtcNow.AddDays(-20),
                    Platform = new List<Platform>
                    {
                        new Platform
                        {
                            Name = "Amazon Prime Video",
                            Followers = 80000000
                        },
                        new Platform
                        {
                            Name = "Tv Azteca",
                            Followers = 900
                        }
                    }
                }
            };
            return series;
        }
        public Serie GetSerieById(int id)
        {
            foreach (Serie serie in GetSeries())
            {
                if (serie.Id == id)
                {
                    return serie;
                }
            }
            return null; 
        }
    }
}