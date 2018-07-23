using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time.Data.Configuration;
using Time.Model;

namespace Time.Data
{
    public class TimeEntities :DbContext
    {
        public TimeEntities() : base("TimeEntities") { }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Subject>()
            //.HasRequired(d => d.Schedules).WithRequiredDependent()
            //.WillCascadeOnDelete(true);

            //modelBuilder.Entity<Schedule>()
            //    .HasRequired(d => d.Subject).WithRequiredDependent().WillCascadeOnDelete(true);

            modelBuilder.Configurations.Add(new ScheduleConfiguration());
            modelBuilder.Configurations.Add(new SubjectConfiguration());
            
        }
    }
}
