using System;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Domain.Entities;
using System.Data.Entity.Validation;
using Data.EntityConfig;
using Data.Migrations;

namespace Data.Context
{
    public class AppTesteContext : DbContext, IDisposable
    {
        public AppTesteContext() : base("TesteDb")
        { }

        public DbSet<InTask> InTasks { get; set; }
        public DbSet<Status> Status { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure
                (p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new InTaskConfiguration());
            modelBuilder.Configurations.Add(new StatusConfiguration());

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppTesteContext, Configuration>());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Created") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Updated").CurrentValue = DateTime.Now;
                    entry.Property("Created").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    //entry.Property("Updated").IsModified = true;
                    entry.Property("Updated").CurrentValue = DateTime.Now;
                }
            }
            //return base.SaveChanges();
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);

            }
        }
    }
}
