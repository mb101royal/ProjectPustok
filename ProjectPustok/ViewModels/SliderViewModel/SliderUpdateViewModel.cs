using System.ComponentModel.DataAnnotations;

namespace ProjectPustok.ViewModels.SliderViewModel
{
    public class SliderUpdateViewModel
    {
        [Required, MaxLength(32)]
        public string Title { get; set; }

        [MinLength(3), MaxLength(64)]
        public string Text { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required, MaxLength(16)]
        public string ButtonText { get; set; }

        public byte Position { get; set; }
    }
}
