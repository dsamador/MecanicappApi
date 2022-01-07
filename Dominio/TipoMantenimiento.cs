using System.Collections.Generic;

namespace Dominio
{
    public class TipoMantenimiento
    {
        public int TipoMantenimientoId { get; set; }        
        public string Nombre { get; set; }
        public string Descripcion { get; set; }     
        public ICollection<Mantenimiento> Mantenimiento { get; set; }
    }
}