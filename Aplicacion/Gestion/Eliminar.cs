using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistencia;

namespace Aplicacion.Gestion
{
    public class Eliminar : IRequest
    {
        public class Ejecuta : IRequest
        {
            public int Id { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly GestionVehicularContext _context;

            public Manejador(GestionVehicularContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var tipoMantenimiento = await _context.TipoMantenimiento.FindAsync(request.Id);

                if(tipoMantenimiento == null)                
                    throw new Exception("El tipo de mantenimiento no existe");                                                
                
                _context.TipoMantenimiento.Remove(tipoMantenimiento);

                var resultado = await _context.SaveChangesAsync();

                if(resultado > 0)
                    return Unit.Value;
                
                throw new Exception("No se pudieron guardar los cambios");
            }
        }
        
    }


}