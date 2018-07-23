using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time.Data.Infrastructure;
using Time.Model;

namespace Time.Data.Repositories
{
    public class ScheduleRepository : RepositoryBase<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }

    public interface IScheduleRepository : IRepository<Schedule>
    {

    }
}
