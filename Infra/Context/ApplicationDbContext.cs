using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Context
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<AluguelEntity> Aluguel { get; set; }
        public DbSet<VendaEntity> Venda { get; set; }
        public DbSet<JogoEntity> Jogo { get; set; }
		public DbSet<RequisitoEntity> RequisitoSistema { get; set; }
        public DbSet<ImagemJogoEntity> ImagemJogo { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string cnnString = _configuration.GetConnectionString("cnnLoja").ToString();
                optionsBuilder.UseSqlServer(cnnString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
