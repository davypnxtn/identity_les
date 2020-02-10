using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Enrollment
    {
        public enum Grade
        {
            A, B, C, D, F
        }

        public int EnrollmentID { get; set; }
        public Grade? grade { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
