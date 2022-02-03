using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Persistencia;

namespace Aplicacion.Gestion
{
    public class Editar
    {
        public class Ejecuta : IRequest
        {
            public int TipoMantenimientoId { get; set; }//necesario para editar
            public string Nombre { get; set; }
            public string Descripcion { get; set; }

        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion()
            {//Esto es fluent validation
                RuleFor(x => x.Nombre).NotEmpty();
                RuleFor(x => x.Descripcion).NotEmpty();
            }
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
                var tipoMantenimiento = await _context.TipoMantenimiento.FindAsync(request.TipoMantenimientoId);
                if(tipoMantenimiento == null)                
                    throw new Exception("El tipo de mantenimiento no existe");
                
                tipoMantenimiento.Nombre = request.Nombre ?? request.Nombre; // si no viene el nombre nuevo pues dejar lo que estaba
                tipoMantenimiento.Descripcion = request.Descripcion ?? request.Descripcion;
                
                var resultado = await _context.SaveChangesAsync();
                
                if(resultado > 0)
                    return Unit.Value;
                
                throw new Exception("No se guardaron los cambios en el tipo de mantenimiento");
            }
        }
    }
}