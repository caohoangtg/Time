using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time.Model;

namespace Time.Data
{
    public class TimeSeedData : DropCreateDatabaseIfModelChanges<TimeEntities>
    {
        protected override void Seed(TimeEntities context)
        {
            GetSubjects().ForEach(c => context.Subjects.Add(c));
            GetSchedules().ForEach(g => context.Schedules.Add(g));
            context.Commit();
            //base.Seed(context);
        }
        private static List<Subject> GetSubjects()
        {
            return new List<Subject>
            {
                new Subject
                {
                    Id = 1,
                    Name = "Math"
                },
                new Subject
                {
                    Id = 2,
                    Name = "History"
                },
                new Subject
                {
                    Id = 3,
                    Name = "Phys"
                },
                new Subject
                {
                    Id = 4,
                    Name = "dia ly"

                },
                new Subject
                {
                    Id = 5,
                    Name = "hoa hao"
                }
            };
        }

        private static List<Schedule> GetSchedules()
        {
            return new List<Schedule>
            {
                new Schedule
                {
                    Day = 1,
                    Time = 3,
                    SubjectId = 2
                },
                new Schedule
                {
                    Day = 3,
                    Time = 2,
                    SubjectId = 4
                },
                new Schedule
                {
                    Day = 2,
                    Time = 4,
                    SubjectId = 3
                },
                new Schedule
                {
                    Day = 3,
                    Time = 6,
                    SubjectId = 2
                },
                new Schedule
                {
                    Day = 4,
                    Time = 4,
                    SubjectId = 5
                }
            };
        }
    }
}
