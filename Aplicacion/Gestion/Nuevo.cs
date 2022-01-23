using System;
using MediatR;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.Threading;
using Persistencia;
using Dominio;

namespace Aplicacion.Gestion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {                          
            public string Nombre { get; set; }
            public string Descripcion { get; set; }     
         
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
                var tipomantenimiento = new TipoMantenimiento 
                {
                    Nombre = request.Nombre,
                    Descripcion = request.Descripcion
                };
                _context.TipoMantenimiento.Add(tipomantenimiento);
                var valor = await _context.SaveChangesAsync();
                if( valor > 0 ){
                    return Unit.Value;//si no hay error
                }
                throw new Exception("No se pudo insertar el mantenimiento");
            }
        }
    }
}