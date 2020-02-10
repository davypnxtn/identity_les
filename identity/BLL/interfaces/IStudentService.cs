using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.interfaces
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
