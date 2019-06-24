using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public  abstract class IContrato

    {
        abstract public int OptenerId(String Text);
       abstract public  bool agragar(object ob);
        abstract public  bool eliminar(int id);
        abstract public  DataSet traerTodos(string Text);
        abstract public  bool MOdificar(int id);


    }
    public interface Icontrato2
    {
       // List<object?> OpetenerTabla();
    }
}
