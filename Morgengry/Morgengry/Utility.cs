using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public class Utility
    {
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public static double GetValueOfAmulet(Amulet amulet)
        {
            double value=0;

            switch(amulet.Quality)
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
    }


}
