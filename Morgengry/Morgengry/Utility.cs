using System;

namespace Morgengry
{
    public static class Utility
    {
        private static double highQualityValue;
        private static double mediumQualityValue;
        private static double lowQualityValue;
        private static double courseHourValue;
        
        public static double HighQualityValue
        {
            get { return highQualityValue; }
            set { highQualityValue = value; }
        }

        public static double MediumQualityValue
        {
            get { return mediumQualityValue; }
            set { mediumQualityValue = value; }
        }

        public static double LowQuialityValue
        {
            get { return lowQualityValue; }
            set { lowQualityValue = value; }
        }

        public static double CourseHourValue
        {
            get { return courseHourValue; }
            set { courseHourValue = value; }
        }

        static Utility()
        {
            HighQualityValue = 27.5;
            MediumQualityValue = 20.0;
            HighQualityValue = 27.5;
            CourseHourValue = 875.0;
        }

        public static double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Amulet amulet)
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
            else if (merchandise is Book book)
            {

                return book.Price;
            }
            else
            {
                return 0;
            }

        }

        //public static double GetValueOfAmulet(Amulet amulet)
        //{
        //    double value=0;

        //    switch(amulet.Quality)
        //    {
        //        case Level.high: 
        //            value = 27.5;
        //            break;

        //        case Level.medium:
        //            value = 20.0;
        //            break;

        //        case Level.low:
        //            value = 12.5;
        //            break;

        //        default:
        //            Console.WriteLine("Error, quality does not exist");
        //            break;
        //    }

        //    return value;
        //}

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




