using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CNegocio
{
    public class ClsDiccionarios
    {
        public List<DICCIONARIO_FAB> TraerDicFab(int cab)
        {
            using(bulonera2Entities1 db = new bulonera2Entities1())
            {
                var DicFab = (from x in db.DICCIONARIO_FAB where x.dic_cab == cab select x).ToList();
                return DicFab;
            }
        }
        //public List<> TraerDicFab(int cab)
        //{
        //    using (bulonera2Entities1 db = new bulonera2Entities1())
        //    {
        //        var DicFab = (from x in db.DICCIONARIO_FAB where x.dic_cab == cab select x).ToList();
        //        return DicFab;
        //    }
        //}
    }
        
}
