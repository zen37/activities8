namespace activities8.Models
{
    public interface Stats
    {
        public int id { get; set; }
        public string name { get; set; }
        public int total { get; set; }
        public int review { get; set; }
        public int approved { get; set; }
        public int notapproved { get; set; }
        public int member { get; set; }
        public int available { get; set; }
    }
}
