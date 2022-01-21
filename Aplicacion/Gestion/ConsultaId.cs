using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Persistencia;

namespace Aplicacion.Gestion
{
    public class ConsultaId
    {
        public class TipoMantenimientoUnico : IRequest<TipoMantenimiento>{
            public int Id { get; set; }
        }

        public class Manejador : IRequestHandler<TipoMantenimientoUnico, TipoMantenimiento>
        {

            private readonly GestionVehicularContext _context;
            public Manejador(GestionVehicularContext context)
            {
                _context = context;
            }            

            public async Task<TipoMantenimiento> Handle(TipoMantenimientoUnico request, CancellationToken cancellationToken)
            {
                var tipoMantenimiento = await _context.TipoMantenimiento.FindAsync(request.Id);
                return tipoMantenimiento;
            }
        }
    }
}