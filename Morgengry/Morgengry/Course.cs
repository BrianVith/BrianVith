using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Morgengry
{
    public class Course
    {
        private string name;

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


        public Course(string name)
        {
            this.name = name;
        }
        public Course(string name, int duration)
        {
            this.name = name;
            durationInMinutes = duration;
        }

        public override string ToString()
        {
            return $"Name: {name}, Duration in Minutes: {durationInMinutes}";
        }


    }
}
