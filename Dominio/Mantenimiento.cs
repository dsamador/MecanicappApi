using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Mantenimiento
    {
        public int MantenimientoId { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        public string Nota { get; set; }
        public byte[] Comprobante { get; set; }        
        public TipoMantenimiento TipoMantenimiento { get; set; }
        public Taller Taller { get; set; }
    }
}