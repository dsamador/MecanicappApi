using System.Collections.Generic;

namespace Dominio
{
    public class MarcaVehiculo
    {
        public int MarcaVehiculoId { get; set; }        
        public string Nombre { get; set; }
        public ICollection<Vehiculo> VechiculosLista { get; set; }/* Relacion uno a muchos */
    }
}
/* Un author puede tener muchos libros y un libro le pertenece a un autor */
/* Una marcaVehiculo tiene muchos vehiculos y un vehiculo le pertenece a una marca */
/* Un curso tiene muchos comentarios un comentario esta vinculado a un solo curso */