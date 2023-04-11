using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIAngulr23TF.Models
{
    public class Voiture
    {
        public Voiture(string brand, string model, string plate, int hp, string? color)
        {
            Brand = brand;
            Model = model;
            Plate = plate;
            Hp = hp;
            Color = color;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        [Required]
        [MaxLength(100)]
        public string Plate { get; set; }

        [Required]
        [Range(1,1500)]
        public int Hp { get; set; }


        [MaxLength(30)]
        public string? Color { get; set; }

    }
}
