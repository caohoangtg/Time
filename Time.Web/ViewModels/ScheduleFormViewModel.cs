using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time.Model;

namespace Time.Web.ViewModels
{
    public class ScheduleFormViewModel
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int Time { get; set; }
        public string Name { get; set; }
    }
}