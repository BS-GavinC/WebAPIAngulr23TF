using DAL.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIAngulr23TF.Models;

namespace BLL.Interfaces
{
    public interface IVoitureService
    {
        public IEnumerable<Voiture> GetAll();

        public Task<Voiture?> GetById(int id);

        public Voiture? Add(CreateVoitureDTO voitureDTO);

        public Voiture? Update(Voiture voiture);

        public Task<bool> Delete(int id);
    }
}
