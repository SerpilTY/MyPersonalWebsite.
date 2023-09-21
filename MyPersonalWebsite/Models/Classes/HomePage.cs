using System.ComponentModel.DataAnnotations;


namespace MyPersonalWebsite.Models.Classes
{
    public class HomePage
    {
        [Key]
        public int Id { get; set; }
        public string Profile { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
    }
}