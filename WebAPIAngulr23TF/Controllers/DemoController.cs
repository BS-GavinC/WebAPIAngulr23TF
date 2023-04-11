

using Microsoft.AspNetCore.Mvc;
using WebAPIAngulr23TF.Models;

namespace WebAPIAngulr23TF.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class DemoController : ControllerBase
    {

        

            /// <summary>
            /// Ma fonction fé dé truk
            /// </summary>
            /// <returns>Heu baaaah ca return un truk ossi je pens</returns>
            [HttpGet]
            [Route("{pwd:alpha:PassLenght}")]
            public ActionResult<List<Voiture>> GetAll(string pwd)
            {
                if (pwd.Length >= 8)
                {
                    return Ok(FakeDb.Voitures);
                }

                return BadRequest();

            }

            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                return Ok(id);
            }


            [HttpPost]
            public IActionResult Create()
            {
                return Ok();
            }

            [HttpPut]
            public IActionResult Update()
            {
                return Ok();
            }

            [HttpDelete]
            public IActionResult Delete()
            {


                return Ok();
            }

        }
}
