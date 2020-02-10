using BLL.interfaces;
using Data;
using Data.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository repository;
        
        public StudentService(IStudentRepository _repository)
        {
            repository = _repository;
        }

        public List<Student> GetStudents()
        {
            return repository.GetStudents();
        }
    }
}
