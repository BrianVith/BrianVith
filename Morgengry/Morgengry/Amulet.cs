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
        private static double highQualityValue = 27.5;
        private static double mediumQualityValue = 20.0;
        private static double lowQualityValue = 12.5;
        private string design;
        private Level quality;

        public static double HighQualityValue
        {
            get { return highQualityValue; }
            set { highQualityValue = value; }
        }

        public static double MediumQualityValue
        {
            get { return mediumQualityValue; }
            set { mediumQualityValue = value; }
        }

        public static double LowQualityValue
        {
            get { return lowQualityValue; }
            set { lowQualityValue = value; }
        }

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

        public override double GetValue()
        {
            switch (quality)
            {
                case Level.high:
                    return HighQualityValue;

                case Level.medium:
                    return MediumQualityValue;

                case Level.low:
                    return LowQualityValue;

                default:
                    return 0;
            }
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {quality}, Design: {design}";
        }

        public override string SavePrep()
        {
            return $"{GetType().Name};{ItemId};{(int)Quality};{Design}";
        }

        public override void LoadPrep(string[] data)
        {
            //ItemId = data[1];
            quality = (Level)int.Parse(data[2]);
            design = data[3];
        }


    }
}
