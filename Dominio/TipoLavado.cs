using System;
using System.Collections.Generic;

namespace Dominio
{
    public class TipoLavado
    {
        public int TipoLavadoId { get; set; }        
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Lavado> Lavado { get; set; }
    }
}
