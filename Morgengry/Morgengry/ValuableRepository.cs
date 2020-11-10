using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                foreach (IValuable item in valuables)
                {
                    writer.WriteLine(item.SavePrep());
                }
            }
        }


        public void Load(string fileName = "ValuableRepository.txt")
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string str = reader.ReadLine();
                string[] data;

                while (str != null)
                {
                    data = str.Split(new char[] { ';' }, StringSplitOptions.None);
                    str = reader.ReadLine();

                    Type objectType = Type.GetType(GetType().Namespace + "." + data[0]);
                    IValuable item = Activator.CreateInstance(objectType, data[1]) as IValuable;
                    item.LoadPrep(data);
                    valuables.Add(item);
                }
            }
        }

        public void SaveSerializable(string fileName = "Serialization.txt")
        {
            using (StreamWriter write = new StreamWriter(fileName, false))
            {
                foreach (IValuable item in valuables)
                {
                    MemoryStream memStream = new MemoryStream();
                    BinaryFormatter binForm = new BinaryFormatter();
                    binForm.Serialize(memStream, item);
                    string line = System.Convert.ToBase64String(memStream.ToArray());
                    write.WriteLine(line);
                }
            }
        }

        public void LoadDeserializable(string fileName = "Serialization.txt")
        {
            //seralization -> fra c# til fil
            //deseralization -> fra fil til c#
            //Martin Fowler -> læs om ham!!!

            using (StreamReader read = new StreamReader(fileName))
            {
                while (!read.EndOfStream)
                {
                    //Read one line at a time
                    string line = read.ReadLine();
                    //Convert the Base64 string into byte array
                    byte[] memorydata = Convert.FromBase64String(line);
                    MemoryStream memStream = new MemoryStream(memorydata);
                    BinaryFormatter binForm = new BinaryFormatter();
                    //Create object using BinaryFormatter
                    IValuable item = (IValuable)binForm.Deserialize(memStream);
                    valuables.Add(item);
                    //Do somthing with your object
                }
            }
        }
    }
}
