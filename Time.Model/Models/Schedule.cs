using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time.Model
{
    public class Schedule
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int Time { get; set; }
        public int SubjectId { get; set; }

        
        public Subject Subject { get; set; }
    }
}
