using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    // A classe tem que herdar da classe DbContext que é do EntityFramework
    public class DataContext : DbContext
    {
        // Construtor definindo um DbContextOptions, configurando o contexto na classe base
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        // Mapeamento da Entidade
        public DbSet<Evento>? Eventos { get; set; }
    }
}