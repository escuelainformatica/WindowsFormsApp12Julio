using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp12Julio.basedatos
{
    public partial class BaseContexto : DbContext
    {
        public BaseContexto()
            : base("name=BaseContexto")
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
                .Property(e => e.Rut)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Apellido)
                .IsUnicode(false);
        }
    }
}
