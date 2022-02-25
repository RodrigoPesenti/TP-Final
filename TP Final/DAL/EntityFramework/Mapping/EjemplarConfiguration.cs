using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework.Mapping
{
    class EjemplarConfiguration : IEntityTypeConfiguration<Ejemplar>
    {
        public void Configure(EntityTypeBuilder<Ejemplar> builder)
        {
            builder.HasKey(pEjemplar => pEjemplar.ID);

            builder.Property(pEjemplar => pEjemplar.ID).ValueGeneratedOnAdd();

            builder.HasOne(pEjemplar => pEjemplar.Libro);

            builder.HasMany(pEjemplar => pEjemplar.Prestamos);
        }
    }
}
