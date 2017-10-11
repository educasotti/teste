using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class InTaskConfiguration : EntityTypeConfiguration<InTask>
    {
        public InTaskConfiguration()
        {
            HasKey(it => it.InTaskId);

            Property(it => it.InTaskId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(it => it.Description)
                .IsRequired()
                .HasMaxLength(512);

            Property(it => it.Title)
                .IsRequired()
                .HasMaxLength(100);

            Property(it => it.TaskStatusId)
                .IsRequired();

            Property(it => it.IsDeleted)                
                .IsRequired();
        }
    }
}
