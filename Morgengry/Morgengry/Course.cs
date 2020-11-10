using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Morgengry
{
    [Serializable]
    public class Course : IValuable
    {
        private string name;
        private static double courseHourValue = 875.0;

        public static double CourseHourValue
        {
            get { return courseHourValue; }
            set { courseHourValue = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int durationInMinutes;

        public int DurationInMinutes
        {
            get { return durationInMinutes; }
            set { durationInMinutes = value; }
        }

        public Course(string name, int duration)
        {
            this.name = name;
            durationInMinutes = duration;

        }

        public Course(string name) :
            this(name, 0)
        {
        }


        public override string ToString()
        {
            return $"Name: {name}, Duration in Minutes: {durationInMinutes}, Pris pr påbegyndt time: {GetValue()}";
        }

        public double GetValue()
        {
            int hourStarted;
            if (DurationInMinutes == 0)
            {
                hourStarted = 0;
            }
            else if (DurationInMinutes % 60 == 0)
            {
                hourStarted = DurationInMinutes / 60;
            }
            else
            {
                hourStarted = (DurationInMinutes / 60) + 1;
            }
            return hourStarted * courseHourValue;
        }

        public string SavePrep()
        {
            return $"{GetType().Name};{Name};{DurationInMinutes}";
        }

        public void LoadPrep(string[] data)
        {
            //name = data[1];
            durationInMinutes = int.Parse(data[2]);
        }
    }
}
