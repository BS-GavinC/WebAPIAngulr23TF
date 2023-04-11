using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DAL.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIAngulr23TF.Models;

namespace BLL.Services
{
    public class VoitureService : IVoitureService
    {

        private readonly IVoitureRepository _voitureRepository;

        public VoitureService(IVoitureRepository voitureRepository)
        {
            _voitureRepository = voitureRepository;
        }

        public Voiture? Add(CreateVoitureDTO voitureDTO)
        {
            return _voitureRepository.Add(voitureDTO.ToVoiture());
        }

        public async Task<bool> Delete(int id)
        {
            Voiture? voiture = await _voitureRepository.GetById(id);
            if (voiture is not null)
            {
                return _voitureRepository.Delete(voiture);
            }
            return false;
        }

        public IEnumerable<Voiture> GetAll()
        {
            return _voitureRepository.GetAll();
        }

        public async Task<Voiture?> GetById(int id)
        {
            return await _voitureRepository.GetById(id);
        }

        public Voiture? Update(Voiture voiture)
        {
            return _voitureRepository.Update(voiture);
        }
    }
}
