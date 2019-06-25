using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CNegocio
{
    public abstract class IContrato
    {
        public abstract bool agragar(object ob);
        public abstract bool eliminar(int id);
        public abstract List<Object> traerTodos(string Text);
        public abstract bool MOdificar(int id);
        public abstract int OptenerId(string Text);

    }
    public abstract class IContrato2
    {
        public abstract bool agragar(object ob);
        public abstract bool eliminar(int id);
        /// <summary>
        /// Traer todos me trae contiene un operador like internamente para saber que si el 
        /// string de entrada es "" entonces me trae toda la lista
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public abstract List<object> TraerTodos(string Text);
        public abstract DataSet TraerTodos();
        public abstract bool MOdificar(Object id);
        public abstract int OptenerId(string Text);
        public abstract object GetObjet(int id);

    }
}
