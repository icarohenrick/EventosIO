using Eventos.IO.Domain.Eventos;
using Eventos.IO.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventos.IO.Infra.Data.Mappings
{
    public class EnderecoMapping : EntityTypeConfiguration<Endereco>
    {
        public override void Map(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar(20)");

            builder.Property(e => e.Numero)
                .HasMaxLength(20)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder
                .Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(e => e.CEP)
                .HasMaxLength(8)
                .HasColumnType("varchar(8)")
                .IsRequired();

            builder.Property(e => e.Complemento)
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder
                .Property(e => e.Cidade)
                .HasMaxLength(100)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(e => e.Estado)
                .HasMaxLength(100)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Ignore(e => e.ValidationResult);

            builder.Ignore(e => e.CascadeMode);

            builder.HasOne(e => e.Evento)
                .WithOne(o => o.Endereco)
                .HasForeignKey<Endereco>(e => e.EventoId)
                .IsRequired(false);

            builder.ToTable("Enderecos");
        }
    }
}
