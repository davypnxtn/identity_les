using BLL.interfaces;
using Data.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class EnrollmentService:IEnrollmentService
    {
        private readonly IEnrollmentRepository repository;

        public EnrollmentService(IEnrollmentRepository _repository)
        {
            repository = _repository;
        }

        public List<Enrollment> GetEnrollments()
        {
            return repository.GetEnrollments();
        }
    }
}
