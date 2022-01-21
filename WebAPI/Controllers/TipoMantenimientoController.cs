using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Gestion;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //http://localhost:5000/api/TipoMantenimiento
    [ApiController]
    [Route("api/[controller]")]
    public class TipoMantenimientoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TipoMantenimientoController(IMediator mediator){
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<TipoMantenimiento>>> Get(){
            return await _mediator.Send(new Consulta.ListaTipoMantenimiento());
        }
    }
}