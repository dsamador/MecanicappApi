
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class GestionVehicularContext : DbContext
    {
        public GestionVehicularContext(DbContextOptions options) : base(options)
        {
            
        }

        /* Metodo que viene de DbContext y estamos sobreescribiendo */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
        }

        /* ######################## */
        /* Mapeando las clases a EF */
        /* ######################## */
        public DbSet<Gasolinera> Gasolinera { get; set; }
        public DbSet<Lavadero> Lavadero { get; set; }
        public DbSet<Lavado> Lavado { get; set; }
        public DbSet<Mantenimiento> Mantenimiento { get; set; }
        public DbSet<MarcaVehiculo> MarcaVehiculo { get; set; }
        public DbSet<RecargaCombustible> RecargaCombustible { get; set; }
        public DbSet<Taller> Taller { get; set; }
        public DbSet<TipoCombustible> TipoCombustible { get; set; }
        public DbSet<TipoLavado> TipoLavado { get; set; }
        public DbSet<TipoMantenimiento> TipoMantenimiento { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
    }
}