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
    public interface ISubjectService
    {
        IEnumerable<Subject> GetSubjects();
        void SaveSubject();
    }

    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository subjectRepository;
        private readonly IUnitOfWork unitOfWork;

        public SubjectService(ISubjectRepository subjectRepository, IUnitOfWork unitOfWork)
        {
            this.subjectRepository = subjectRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Subject> GetSubjects()
        {
            var subjects = subjectRepository.GetAll();
            return subjects;
        }
        public void SaveSubject()
        {
            unitOfWork.Commit();
        }
    }
}
