using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Time.Web.ViewModels
{
    public class ScheduleViewModel
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int Time { get; set; }

        public int SubId { get; set; }

        public virtual SubjectViewModel Subject { get; set; }
    }
}