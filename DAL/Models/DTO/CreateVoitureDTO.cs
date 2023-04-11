using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.DTO
{
    public class CreateVoitureDTO
    {

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
        [Range(1, 1500)]
        public int Hp { get; set; }


        [MaxLength(30)]
        public string? Color { get; set; }

    }
}
