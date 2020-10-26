using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;

namespace Morgengry
{
    public class ValuableRepository : IPersitable
    {
        private List<IValuable> valuables;

        public ValuableRepository()
        {
            valuables = new List<IValuable>();
        }

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Course course)
                {
                    if (course.Name == id)
                    {
                        return course;
                    }
                }
                else if (valuable is Merchandise merchandise)
                {
                    if (merchandise.ItemId == id)
                    {
                        return merchandise;
                    }
                }
            }
            return null;
        }

        public int Count() // skal returnere antallet af elementer i repositoriet
        {
            return valuables.Count;
        }

        public double GetTotalValue()
        {
            double sum = 0;

            foreach (IValuable valuable in valuables)
                sum += valuable.GetValue();

            return sum;
        }


        public void Save(string fileName = "ValuableRepository.txt")
        {
            
            StreamWriter writer = new StreamWriter(fileName, true);
            
            foreach (IValuable item in valuables)
            {
                writer.WriteLine(item.SavePrep());
            }
            writer.Close();
        }


        public void Load(string fileName = "ValuableRepository.txt")
        {
            StreamReader reader = new StreamReader(fileName);

            string str = reader.ReadLine();
            string[] data;

            while (str != null)
            {

                data = str.Split(new char[] { ';' }, StringSplitOptions.None);
                str = reader.ReadLine();

                Type objectType = Type.GetType("Morgengry." + data[0]);
                IValuable item = Activator.CreateInstance(objectType, data[1]) as IValuable;
                item.LoadPrep(data);
                valuables.Add(item);
            }
            reader.Close();
        }
    }
}
