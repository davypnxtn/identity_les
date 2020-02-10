using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
