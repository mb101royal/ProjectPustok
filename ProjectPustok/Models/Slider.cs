using System.ComponentModel.DataAnnotations;

namespace ProjectPustok.Models
{
    public class Slider
    {

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(32)]
        public string Title { get; set; }

        [Required, MaxLength(42)]
        public string Text { get; set; }

        [Required, MaxLength(16)]
        public string ButtonText { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public bool Position { get; set; }

    }
}
