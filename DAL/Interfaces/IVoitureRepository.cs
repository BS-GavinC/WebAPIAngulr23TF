using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIAngulr23TF.Models;

namespace DAL.Interfaces
{
    public interface IVoitureRepository
    {

        public IEnumerable<Voiture> GetAll();

        public Task<Voiture?> GetById(int id);

        public Voiture? Add(Voiture voiture);

        public Voiture? Update(Voiture voiture);

        public bool Delete(Voiture voiture);

    }
}
