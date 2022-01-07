using System.Collections.Generic;

namespace Dominio
{
    public class Taller
    {
        public int TallerId { get; set; }        
        public string Nombre { get; set; }
        public string Descripcion { get; set; }     
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public ICollection<Mantenimiento> Mantenimiento { get; set; }
    }
}