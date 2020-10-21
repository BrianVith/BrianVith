using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public class AmuletRepository
    {
        private List<Amulet> amulets;

        public AmuletRepository()
        {
            amulets = new List<Amulet>();
        }

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            foreach (Amulet a in amulets)
            {
                if (a.ItemId == itemId)
                {
                    return a;
                }
            }

            return null;
        }

        public double GetTotalValue()
        {
            double sum = 0;

            foreach (Amulet a in amulets)
            {
                sum += Utility.GetValueOfMerchandise(a);
            }

            return sum;
        }

    }
}
