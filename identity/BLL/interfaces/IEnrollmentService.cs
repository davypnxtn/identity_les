using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.interfaces
{
    public interface IEnrollmentService
    {
        List<Enrollment> GetEnrollments();
    }
}
