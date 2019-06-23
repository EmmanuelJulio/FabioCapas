using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    public class Modulos : IContrato
    {
        public static List<string> ModulosUsuario;
        
        
        public static List<CapaDatos.MODULOS> OptenerModulos()
        {
            try
            {
                using(CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
                {
                    List<CapaDatos.MODULOS> mod = (from x in db.MODULOS join a in db.MODULO_USUARIO on x.ID_MODULO equals a.ID_MODULO where a.ID_USUARIO==CapaNegocios.ClsUsuario.UsuarioActual.id_usuario select x ).ToList()  ;
                    return mod;                                               
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool agragar(object ob)
        {
           using(CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                using(var Transaction = db.Database.BeginTransaction())
                {
                    try
                    {

                        db.MODULOS.Add(((CapaDatos.MODULOS)ob));
                        db.SaveChanges();
                        Transaction.Commit();
                        Transaction.Dispose();
                    }
                    catch (Exception)
                    {

                        Transaction.Rollback();
                    }

                }
            }
            return true;
        }

        public bool eliminar(object ob)
        {
            throw new NotImplementedException();
        }

        public bool MOdificar(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> traerTodos(object ob)
        {
            throw new NotImplementedException();
        }
    }
}
