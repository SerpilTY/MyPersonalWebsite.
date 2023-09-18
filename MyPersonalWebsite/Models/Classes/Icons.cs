using System.ComponentModel.DataAnnotations;


namespace MyPersonalWebsite.Models.Classes
{
    public class Icons
    {
        [Key]
        public int Id { get; set; }
        public string IconName { get; set; }    
        public string Link { get; set; }
    }
}