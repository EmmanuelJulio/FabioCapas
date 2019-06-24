using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public interface IContrato
    {
         bool agragar(object ob);
        bool eliminar(object ob);
       List<CapaDatos.bulonera2Entities1> traerTodos(object ob);
        bool MOdificar(int id);

    }
}
