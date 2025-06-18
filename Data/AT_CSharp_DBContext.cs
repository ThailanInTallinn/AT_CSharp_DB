using AT_CSharp_DB.Models;
using Microsoft.EntityFrameworkCore;

namespace AT_CSharp_DB.Data
{
    public class AT_CSharp_DBContext : DbContext
    {
        DbSet<CidadeDestino> CidadesDestino { get; set; }   
        DbSet<Cliente> Clientes {  get; set; }
        DbSet<PacoteTuristico> PacotesTuristicos { get; set; }  
        DbSet<PaisDestino> PaisesDestino { get; set; }  
        DbSet<Reserva> Reservas { get; set; }

        public AT_CSharp_DBContext() { }

        public AT_CSharp_DBContext(DbContextOptions<AT_CSharp_DBContext> options) : base(options) { }
    }
}
