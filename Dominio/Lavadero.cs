using System.Collections.Generic;

namespace Dominio
{
    public class Lavadero
    {
        public int LavaderoId { get; set; }        
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }   
        public ICollection<Lavado> Lavado { get; set; }
    }
}