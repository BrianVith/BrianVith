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

        public static double LowQualityValue
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
            lowQualityValue = 12.5;
            mediumQualityValue = 20.0;
            highQualityValue = 27.5;
            courseHourValue = 875.0;
        }

        public static double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Amulet amulet)
            {
                switch (amulet.Quality)
                {
                    case Level.high:
                        return HighQualityValue; 

                    case Level.medium:
                        return MediumQualityValue;  

                    case Level.low:
                        return LowQualityValue;

                    default:
                        return 0; 
                }     
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
            return hourStarted * courseHourValue;
        }
    }
}




