using Data.Data;
using Data.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class EnrollmentRepository:IEnrollmentRepository
    {
        private readonly SchoolContext _context;

        public EnrollmentRepository(SchoolContext context)
        {
            _context = context;
        }

        public List<Enrollment> GetEnrollments()
        {
            return _context.Enrollments.ToList();
        }
    }
}
