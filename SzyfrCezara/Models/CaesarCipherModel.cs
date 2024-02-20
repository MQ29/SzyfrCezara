using System.ComponentModel.DataAnnotations;

namespace SzyfrCezara.Models
{
    public class CaesarCipherModel
    {
        [Required(ErrorMessage = "Pole nie może być puste.")]
        public string Text { get; set; }
        [Range(0,34, ErrorMessage = "Klucz musi być liczbą z przedziału 0-34.")]
        public int Shift { get; set; }
        public bool IsEncrypt { get; set; }
        public string? Result { get; set; }
    }
}
