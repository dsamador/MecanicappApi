using System;
using System.Collections.Generic;

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
        public DateTime FechaCreacion { get; set; }
        public byte[] FotoVehiculo { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }
        public MarcaVehiculo MarcaVehiculo { get; set; }
        public TipoCombustible TipoCombustible { get; set; }
        public ICollection<Lavado> Lavado { get; set; }
        public ICollection<Mantenimiento> Mantenimiento { get; set; }
        public ICollection<RecargaCombustible> RecargaCombustible { get; set; }
    }
}