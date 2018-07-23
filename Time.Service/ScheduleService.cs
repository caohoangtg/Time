using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time.Data.Infrastructure;
using Time.Data.Repositories;
using Time.Model;

namespace Time.Service
{
    public interface IScheduleService
    {
        //IEnumerable<Schedule> GetSchedules();
        IEnumerable<Schedule> GetSchedules();
        Schedule GetSchedule(int id);
        Schedule GetSchedule(int day, int time);
        void CreateSchedule(Schedule schedule);
        void SaveSchedule();
        void DeleteSchedule(int id);
    }

    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository scheduleRepository;
        private readonly IUnitOfWork unitOfWork;

        public ScheduleService(IScheduleRepository scheduleRepository, IUnitOfWork unitOfWork)
        {
            this.scheduleRepository = scheduleRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateSchedule(Schedule schedule)
        {
            scheduleRepository.Add(schedule);
        }

        public Schedule GetSchedule(int id)
        {
            var schedule = scheduleRepository.GetById(id);
            return schedule;
        }

        public Schedule GetSchedule(int day, int time)
        {
            var schedule = scheduleRepository.GetByDayTime(day, time);
            return schedule;
        }

        public IEnumerable<Schedule> GetSchedules()
        {
            var schedules = scheduleRepository.GetAll();
            return schedules; 
        }

        public void SaveSchedule()
        {
            unitOfWork.Commit();
        }
        public void DeleteSchedule(int id)
        {
            var schedule = scheduleRepository.GetById(id);
            scheduleRepository.Delete(schedule);
        }
    }
}
