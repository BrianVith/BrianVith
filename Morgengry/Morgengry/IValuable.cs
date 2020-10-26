using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public interface IValuable
    {
        double GetValue();
        string SavePrep();
        void LoadPrep(string[] data);
    }

}
