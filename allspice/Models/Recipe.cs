namespace allspice.Models
{
    public class Recipe
    {
        public int Picture { get; set; }
        public string Title { get; set; }
        public string Subtitle  { get; set; }
        public string Category { get; set; }
        public string CreatorId { get; set; }
        public Account Creator{ get; set; }
    }
}