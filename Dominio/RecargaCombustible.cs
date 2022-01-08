using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class RecargaCombustible
    {       
        public int RecargaCombustibleId { get; set; }
        public DateTime FechaRecargaCombustible { get; set; }
        public int Cantidad { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioGalon { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoTotal { get; set; }
        public int Kilometraje { get; set; }
        public string Nota { get; set; }                
        public byte[] Comprobante { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Gasolinera Gasolinera { get; set; }
        
    }
}