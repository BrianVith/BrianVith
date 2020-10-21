using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public enum Level
    {
        low,
        medium,
        high
    }

    public class Amulet : Merchandise
    {
        private string design;
        private Level quality;

        public string Design
        {
            get { return design; }
            set { design = value; }
        }

        public Level Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            this.quality = quality;
            this.design = design;
        }

        public Amulet(string itemId, Level quality) :
            this (itemId, quality, "")
        {
        }
        
        public Amulet (string itemId) :
            this (itemId, Level.medium, "")
        { 
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {quality}, Design: {design}";
        }

    }
}
