﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TimeEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public TimeEntities DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
