using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio
{
    abstract class InterfazGeneral
    {
        public abstract void GetAll();
        public abstract object Find();
        public abstract void Save();
        public abstract void Edit();
    }
}
