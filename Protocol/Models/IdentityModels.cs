using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Protocol.Models.Bases;
using System.Web;


namespace Protocol.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("ProtocolConnection")
        {
        }


        public System.Data.Entity.DbSet<School> Schools { get; set; }
        public System.Data.Entity.DbSet<Group> Groups { get; set; }
        public System.Data.Entity.DbSet<Student> Students { get; set; }

        /*
        public override int SaveChanges()
        {
            DateTime now = DateTime.UtcNow;
            foreach (ObjectStateEntry entry in (this as IObjectContextAdapter).ObjectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified))
            {
                if (!entry.IsRelationship)
                {
                    IHasLastModified lastModified = entry.Entity as IHasLastModified;
                    if (lastModified != null)
                        lastModified.LastModified = now;
                }
            }

            return base.SaveChanges();
        }
        */
        public override int SaveChanges()
        {

            DateTime now = DateTime.UtcNow;
            var currentUsername = HttpContext.Current != null && HttpContext.Current.User != null
                ? HttpContext.Current.User.Identity.Name
                : "Anonymous";
            var entitys = (this as IObjectContextAdapter).ObjectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified);

            foreach (ObjectStateEntry entity in entitys)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedDate = now;
                    ((BaseEntity)entity.Entity).UserCreated = currentUsername;
                }

                ((BaseEntity)entity.Entity).LastModified = now;
                ((BaseEntity)entity.Entity).UserModified = currentUsername;
            }

            return base.SaveChanges();
        }

        public System.Data.Entity.DbSet<Protocol.Models.SectionSchools> SectionSchools { get; set; }


    }
}