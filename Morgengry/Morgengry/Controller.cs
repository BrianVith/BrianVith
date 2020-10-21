using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public class Controller
    {
        private MerchandiseRepository merchandiseRepo;
        private CourseRepository courseRepo;

        //private List<Book> books;
        //private List<Amulet> amulets;
        //private List<Course> courses;


        //public List<Book> Books
        //{
        //    get { return books; }
        //    set { books = value; }
        //}

        //public List<Amulet> Amulets
        //{
        //    get { return amulets; }
        //    set { amulets = value; }
        //}

        //public List<Course> Courses
        //{
        //    get { return courses; }
        //    set { courses = value; }
        //}


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
