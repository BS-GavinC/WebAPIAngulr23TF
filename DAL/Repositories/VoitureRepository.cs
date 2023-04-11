using DAL.Context;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIAngulr23TF.Models;

namespace DAL.Repositories
{
    public class VoitureRepository : IVoitureRepository
    {

        private readonly DatabaseContext _context;

        public VoitureRepository(DatabaseContext databaseContext)
        {
            _context = databaseContext;
        }

        public Voiture? Add(Voiture voiture)
        {
            try
            {
                _context.Voitures.Add(voiture);
                _context.SaveChanges();
                return voiture;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public bool Delete(Voiture voiture)
        {
            try
            {
                _context.Voitures.Remove(voiture);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public IEnumerable<Voiture> GetAll()
        {
            return _context.Voitures.ToList();
        }

        public async Task<Voiture?> GetById(int id)
        {
            try
            {

                return await _context.Voitures.FindAsync(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Voiture? Update(Voiture voiture)
        {
            try
            {
                _context.Voitures.Update(voiture);
                _context.SaveChanges();
                return voiture;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
