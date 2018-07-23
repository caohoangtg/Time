using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time.Model;

namespace Time.Data.Configuration
{
    public class ScheduleConfiguration : EntityTypeConfiguration<Schedule>
    {
        public ScheduleConfiguration()
        {
            ToTable("Schedules");
            Property(g => g.Day).IsRequired();
            Property(g => g.Time).IsRequired();
            Property(g => g.SubjectId).IsRequired();
            
        }
    }
}
