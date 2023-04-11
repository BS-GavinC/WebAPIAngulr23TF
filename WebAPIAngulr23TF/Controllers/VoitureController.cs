using BLL.Interfaces;
using DAL.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIAngulr23TF.Models;

namespace WebAPIAngulr23TF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoitureController : ControllerBase
    {
        private readonly IVoitureService _voitureService;

        public VoitureController(IVoitureService voitureService)
        {
            _voitureService = voitureService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Voiture>> GetAll()
        {
            return Ok(_voitureService.GetAll());
        }

        [HttpPost]
        public ActionResult<Voiture> Create(CreateVoitureDTO createDto)
        {
            if (ModelState.IsValid)
            {
                Voiture? voit = _voitureService.Add(createDto);
                return voit is not null ? Ok(voit) : Problem();
            }

            return BadRequest();
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Voiture>> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                Voiture? voit = await _voitureService.GetById(id);
                return voit != null ? Ok(voit) : BadRequest();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return await _voitureService.Delete(id) ? Ok() : BadRequest();
        }

        [HttpPut]
        public ActionResult<Voiture> Update(Voiture voiture)
        {
            if (ModelState.IsValid)
            {
                Voiture voit = _voitureService.Update(voiture);
                if (voit is not null)
                {
                    return Ok(voit);
                }
                return BadRequest();

            }

            return BadRequest();

            

        }

    }

}
