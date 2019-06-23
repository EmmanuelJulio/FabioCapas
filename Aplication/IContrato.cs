using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    public interface IContrato
    {
         bool agragar(object ob);
        bool eliminar(object ob);
       List<Object> traerTodos(object ob);
        bool MOdificar(int id);

    }
}
