using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time.Model;

namespace Time.Data.Configuration 
{
    public class SubjectConfiguration : EntityTypeConfiguration<Subject>
    {
        public SubjectConfiguration()
        {
            ToTable("Subjects");
            Property(g => g.Name).IsRequired().HasMaxLength(50);
        }
    }
}
