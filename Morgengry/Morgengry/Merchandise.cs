using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public abstract class Merchandise
    {
        private string itemId;

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public override string ToString()
        {
            return $"ItemId: {itemId}";
        }

    }
}
