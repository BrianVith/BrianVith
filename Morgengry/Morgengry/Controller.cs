using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public class Controller
    {
        private MerchandiseRepository merchandiseRepo;
        private CourseRepository courseRepo;

        public Controller()
        {
            merchandiseRepo = new MerchandiseRepository();
            courseRepo = new CourseRepository();
        }

        public void AddToList(Merchandise merchandise)
        {
            merchandiseRepo.AddMerchandise(merchandise);
        }

        public void AddToList(Course course)
        {
            courseRepo.AddCourse(course);
        }

    }
}
