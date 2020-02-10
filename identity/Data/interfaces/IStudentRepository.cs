using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
    }
}
