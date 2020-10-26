using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public class Controller
    {
        private ValuableRepository valuableRepo;

        //private MerchandiseRepository merchandiseRepo;
        //private CourseRepository courseRepo;

        public ValuableRepository ValuableRepo
        {
            get { return valuableRepo; }
            set { valuableRepo = value; }
        }

        public Controller()
        {
            valuableRepo = new ValuableRepository();
            
            //merchandiseRepo = new MerchandiseRepository();
            //courseRepo = new CourseRepository();
        }
        public void AddToList(IValuable valuable)
        {
            valuableRepo.AddValuable(valuable);
        }

        //public void AddToList(Merchandise merchandise)
        //{
        //    merchandiseRepo.AddMerchandise(merchandise);
        //}

        //public void AddToList(Course course)
        //{
        //    courseRepo.AddCourse(course);
        //}

    }
}
