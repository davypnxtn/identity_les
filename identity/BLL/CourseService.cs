using BLL.interfaces;
using Data.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class CourseService:ICourseService
    {
        private readonly ICourseRepository repository;

        public CourseService(ICourseRepository _repository)
        {
            repository = _repository;
        }

        public List<Course> GetCourses()
        {
            return repository.GetCourses();
        }
    }
}
