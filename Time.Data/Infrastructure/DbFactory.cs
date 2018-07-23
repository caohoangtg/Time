using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        TimeEntities dbContext;
        public TimeEntities Init()
        {
            return dbContext ?? (dbContext = new TimeEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
