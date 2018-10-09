using System.ComponentModel.DataAnnotations;


namespace MovieStore.Models
{
    public class GenreModel
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}