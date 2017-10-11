using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class StatusConfiguration : EntityTypeConfiguration<Status>
    {
        public StatusConfiguration()
        {
            HasKey(s => s.TaskStatusId);

            Property(s => s.TaskStatusId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(s => s.Description)
                .IsRequired()
                .HasMaxLength(512);            

            Property(s => s.IsDeleted)
                .IsRequired();
        }
    }
}
