using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;

namespace Aplicacion.Gestion
{
    /* 32 Esta clase va a devolver la lista de entidades */
    public class Consulta
    {
        /* 32 clase que representa los datos que se van a retornar, en este caso una lista de objetos IRequest que envuelven 
        una lista de la clase TipoMantenimiento */
        public class ListaTipoMantenimiento : IRequest<List<TipoMantenimiento>>{

        }

        /* 32 Clase que representa la consulta, primero le especificamos que queremos una ListaTipoMantenimiento en el formato de List<TipoMantenimiento>  */
        public class Manejador : IRequestHandler<ListaTipoMantenimiento, List<TipoMantenimiento>>
        {
            public Task<List<TipoMantenimiento>> Handle(ListaTipoMantenimiento request, CancellationToken cancellationToken)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}