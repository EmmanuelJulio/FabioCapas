using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Dynamic;
using System.Linq.Expressions;

namespace CNegocio
{
    public class ClsDiccionarios
    {
        public List<DICCIONARIO_FAB> TraerDicFab(int cab)
        {
            using(bulonera2Entities22 db = new bulonera2Entities22())
            {
                var DicFab = (from x in db.DICCIONARIO_FAB where x.dic_cab == cab select x).ToList();
                return DicFab;
            }
        }
        public List<DiccionarioDeFabricacion> TraerDiccionario_ODFM(int cab)
        {
            using (bulonera2Entities22 db = new bulonera2Entities22())
            {
                var DicFab = (from x in db.Diccionario_odfm where x.dic_cab == cab select x).ToList();
                return DicFab;
            }
        }
        
       
    }
        
}
