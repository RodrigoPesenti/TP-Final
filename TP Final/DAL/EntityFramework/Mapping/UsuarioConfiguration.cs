using TP_Final.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TP_Final.DAL.EntityFramework.Mapping
{
    class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(pClient => pClient.ID);

            builder.HasAlternateKey(pClient => pClient.Nombre);

            builder.Property(pClient => pClient.Nombre)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(pCliente => pCliente.Tipo);

            builder.Property(pCliente => pCliente.TipoNotificacion);

            builder.Property(pClient => pClient.ID).ValueGeneratedOnAdd();           

            builder.Property(pClient => pClient.Contraseña)
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(pCliente => pCliente.Mail)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(pClient => pClient.Prestamos);

            builder.HasMany(pClient => pClient.Notificaciones);
        }
    }
}
