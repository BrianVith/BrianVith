//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Morgengry
//{
//    public class MerchandiseRepository
//    {
//        private List<Merchandise> merchandises;

//        public MerchandiseRepository()
//        {
//            merchandises = new List<Merchandise>();
//        }

//        public void AddMerchandise(Merchandise merchandise)
//        {
//            merchandises.Add(merchandise);
//        }

//        public Merchandise GetMerchandise(string itemId)
//        {
//            foreach (Merchandise m in merchandises)
//            {
//                if(m.ItemId == itemId)
//                {
//                    return m;
//                }
//            }

//            return null;
//        }

//        public double GetTotalValue()
//        {
//            double sum = 0;

//            foreach (Merchandise m in merchandises)
//            {
//                sum += Utility.GetValueOfMerchandise(m);
//            }

//            return sum;
//        }

//    }
//}
