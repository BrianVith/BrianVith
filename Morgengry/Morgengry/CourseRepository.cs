using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Morgengry
{
    public class CourseRepository
    {
        private List<Course> courses;

        public CourseRepository()
        {
             courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            foreach (Course c in courses)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }

            return null;
        }

        public double GetTotalValue()
        {
            double sum = 0;

            foreach (Course c in courses)
            {
                sum += Utility.GetValueOfCourse(c);
            }

            return sum;
        }

    }
}
