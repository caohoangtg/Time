using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Time.Model;
using Time.Service;
using Time.Web.ViewModels;
using AutoMapper;
using Time.Data;

namespace Time.Web.Controllers
{
    public class HomeController : Controller
    {
        private TimeEntities db = new TimeEntities();
        private readonly ISubjectService subjectService;
        private readonly IScheduleService scheduleService;

        public HomeController(ISubjectService subjectService, IScheduleService scheduleService)
        {
            this.subjectService = subjectService;
            this.scheduleService = scheduleService;
        }

        public ActionResult Index()
        {
            IEnumerable<SubjectViewModel> viewModelSchedule;
            IEnumerable<Subject> subjects;
            subjects = subjectService.GetSubjects().ToList();
            viewModelSchedule = Mapper.Map<IEnumerable<Subject>, IEnumerable<SubjectViewModel>>(subjects);
            ViewBag.viewSubjects = viewModelSchedule;

            IEnumerable<ScheduleFormViewModel> scheduleFormViewModel;
            IEnumerable<Schedule> schedules;
            schedules = scheduleService.GetSchedules().ToList();
            scheduleFormViewModel = Mapper.Map<IEnumerable<Schedule>, IEnumerable<ScheduleFormViewModel>>(schedules);
            ViewBag.scheduleForm = scheduleFormViewModel;

            return View(scheduleFormViewModel);
        }

        public JsonResult AddSchedule(ScheduleViewModel schedule)
        {
            //db.Schedules.Add(schedule);
            //db.SaveChanges();
            //var mysche = db.Schedules.Where(b => b.Day == schedule.Day).Where(c => c.Time == schedule.Time).FirstOrDefault().Id;
            //return Json(mysche, JsonRequestBehavior.AllowGet);

            var sched = Mapper.Map<ScheduleViewModel, Schedule> (schedule);
            scheduleService.CreateSchedule(sched);
            scheduleService.SaveSchedule();
            var mysche = db.Schedules.Where(b => b.Day == schedule.Day).Where(c => c.Time == schedule.Time).FirstOrDefault().Id;
            return Json(mysche, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeleteSchedule(int id)
        {
            scheduleService.DeleteSchedule(id);
            scheduleService.SaveSchedule(); 
            //Schedule schedule = db.Schedules.Find(id);
            //db.Schedules.Remove(schedule);
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return null;
        }

    }
}