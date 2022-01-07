using System;

namespace Dominio
{
    public class Lavado
    {
        public int LavadoId { get; set; }
        public DateTime FechaLavado { get; set; }
        public decimal Valor { get; set; }
        public string Nota { get; set; }
        public byte[] Comprobante { get; set; }
        public TipoLavado TipoLavado { get; set; }
        public Lavadero Lavadero { get; set; }
    }
}