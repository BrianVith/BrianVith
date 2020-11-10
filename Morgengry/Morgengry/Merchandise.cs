using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    [Serializable]
    public abstract class Merchandise : IValuable
    {
        private string itemId;

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public abstract double GetValue();
        public abstract string SavePrep();
        public abstract void LoadPrep(string[] data);


        public override string ToString()
        {
            return $"ItemId: {itemId}";
        }

    }
}
