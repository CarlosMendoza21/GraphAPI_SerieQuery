namespace GraphAPI.Models
{
    public class Serie
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public int Season{get; set;}
        public DateTime ReleaseDate{get; set;}
        public List<Platform> Platform{get; set;}
    }
}