using System;

namespace Dominio
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }        
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }        
        public int Tanque { get; set; }
        public string NumChasis { get; set; }
        public string Vin { get; set; }
        public string Matricula { get; set; }
        public string TipoVehiculo { get; set; }//foranea
        public string Marca { get; set; }//foranea
        public DateTime FechaCreacion { get; set; }
        public byte[] FotoVehiculo { get; set; }
    }
}
