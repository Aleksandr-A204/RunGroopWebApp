using System.ComponentModel.DataAnnotations;

namespace RunGroopWebApp.Models
{
    public class AppUser
    {
        [Key]
        public string Id { get; set; }
        public int? Page { get; set; }
        public int? Mileage { get; set; }
        public Address? Address { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }
    }
}
