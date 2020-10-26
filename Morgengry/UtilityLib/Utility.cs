using System;
using System.Collections.Generic;
using System.Text;
using Morgengry;

namespace UtilityLib
{
    public static class Utility
    {
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public static double GetValueOfMerchandise(Amulet amulet)
        {
            double value = 0;

            switch (amulet.Quality)
            {
                case Level.high:
                    value = 27.5;
                    break;

                case Level.medium:
                    value = 20.0;
                    break;

                case Level.low:
                    value = 12.5;
                    break;

                default:
                    Console.WriteLine("Error, quality does not exist");
                    break;
            }

            return value;
        }

        public static double GetValueOfCourse(Course course)
        {
            int hourStarted;
            if (course.DurationInMinutes == 0)
            {
                hourStarted = 0;
            }
            else if (course.DurationInMinutes % 60 == 0)
            {
                hourStarted = course.DurationInMinutes / 60;
            }
            else
            {
                hourStarted = (course.DurationInMinutes / 60) + 1;
            }

            return hourStarted * 875.00;
        }

    }


}
