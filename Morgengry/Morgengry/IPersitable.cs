using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Morgengry
{
    public interface IPersitable
    {
        void Save(string fileName);
        void Load(string fileName);
    }
}
