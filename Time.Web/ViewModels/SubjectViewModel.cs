using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Time.Web.ViewModels
{
    public class SubjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<ScheduleViewModel> Schedules { get; set; }
    }
}