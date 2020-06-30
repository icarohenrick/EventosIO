using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Eventos;
using Eventos.IO.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventos.IO.Infra.Data.Mappings
{
    public class StoredEventMap : EntityTypeConfiguration<StoredEvent>
    {
        public override void Map(EntityTypeBuilder<StoredEvent> builder)
        {
            builder.Property(e => e.MessageType)
                .HasColumnName("Action")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.ToTable("StoredEvent");
        }
    }
}
