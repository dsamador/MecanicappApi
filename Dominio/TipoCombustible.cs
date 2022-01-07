using System.Collections.Generic;

namespace Dominio
{
    public class TipoCombustible
    {
        public int TipoCombustibleId { get; set; }        
        public string Nombre { get; set; }
        public ICollection<Vehiculo> Vehiculo { get; set; }   
    }
}