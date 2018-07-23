using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time.Data.Infrastructure;
using Time.Model;

namespace Time.Data.Repositories
{
    public class SubjectRepository : RepositoryBase<Subject>, ISubjectRepository
    {
        public SubjectRepository(IDbFactory dbFactory): base(dbFactory) { }
    }

    public interface ISubjectRepository : IRepository<Subject>
    {
        
    }
}
