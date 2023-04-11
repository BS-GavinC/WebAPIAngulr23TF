using DAL.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIAngulr23TF.Models;

namespace DAL.Models
{
    public static class VoitureExtensions
    {

        public static Voiture ToVoiture(this CreateVoitureDTO createDTO)
        {
            return new Voiture(createDTO.Brand, createDTO.Model, createDTO.Plate, createDTO.Hp, createDTO.Color);
        }

    }
}
