using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradoresController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Colaborador> Get()
        {
            var colabs = new List<Colaborador>();

            colabs.Add(new Colaborador("Gabriel", 12));
            colabs.Add(new Colaborador("Marcos", 40));
            colabs.Add(new Colaborador("Rafael", 15));
            colabs.Add(new Colaborador("Henrique", 25));

            return colabs.ToArray();
        }
    }
}
