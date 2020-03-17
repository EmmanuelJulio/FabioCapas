using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CNegocio
{
    public class ClsUsuario

    {

        /// ////////////ejemplo de join en tres tablas
        /// var resultado =(from kar in db.Kardexs
        //join art in db.Articulos on kar.ArticuloID equals art.ArticuloID
        //join bod in db.Bodegas on art.BodegaID equals bod.BodegaID

        //where bod.BodegaID == busqueda
        //select kar
        //       );
        /// 
        /// 
        /// <summary>
        /// Variables globales del la propiedad
        /// </summary>
        public static USUARIOS UsuarioActual = null;
        public static bool ExisteSecion;
        
        /// <summary>
        /// Definicion de contructor
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Contraceña"></param>
        /// <returns></returns>
        /// 
        public static bool Activo (string usuario)
        {
            using (bulonera2Entities22 db = new bulonera2Entities22())
            {
                var acceso = (from x in db.USUARIOS where x.nombre_usuario == usuario select x.Activo);

                return Convert.ToBoolean(acceso);
            }
        }
        public List<MODULOS> TraerAccesosActuales(int id)
        {
            using (bulonera2Entities22 db = new bulonera2Entities22())
            {
                var _Modulos = (from x in db.USUARIOS
                               join modUs in db.MODULO_USUARIO on x.id_usuario equals modUs.ID_USUARIO
                               join mod in db.MODULOS on modUs.ID_MODULO equals mod.ID_MODULO
                               where x.id_usuario==id select mod).ToList();
                return _Modulos;
            }
        }
        public List<USUARIOS> TraerUsuarios()
        {
            using(bulonera2Entities22 db = new bulonera2Entities22())
            {
                var usuarios = (from x in db.USUARIOS select x).ToList();
                return usuarios;
            } 
        }
         public int OptenerUsuario(string nombre)
        {
            using (bulonera2Entities22 db = new bulonera2Entities22())
            {
                var usuarios = (from x in db.USUARIOS where x.nombre == nombre select x).FirstOrDefault();
                return usuarios.id_usuario;
            }
        }


        public bool EliminarUsuario(object ob)
        {
            using (bulonera2Entities22 db = new bulonera2Entities22())
            {

                using (var Transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var usua = (from x in db.USUARIOS where x.nombre == ob.ToString() select x).FirstOrDefault();
                        

                        db.USUARIOS.Remove(usua);
                        db.SaveChanges();
                        Transaction.Commit();
                        Transaction.Dispose();

                        return true;
                    }
                    catch (Exception)
                    {

                        Transaction.Rollback();
                        return false;
                    }
                }
            }

        }

        public static bool loggin(string Usuario, string Contraceña)
        
        {
            try
            {
                using (CapaDatos.bulonera2Entities22 db = new CapaDatos.bulonera2Entities22())
                {
                    UsuarioActual = (from x in db.USUARIOS where x.nombre_usuario == Usuario && x.contraseña == Contraceña select x).FirstOrDefault();
                    if (UsuarioActual != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public static bool agragar(object ob)
        {
            using (bulonera2Entities22 db = new bulonera2Entities22())
            {
                using (var Transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.USUARIOS.Add(((USUARIOS)ob));
                        db.SaveChanges();
                        Transaction.Commit();
                        Transaction.Dispose();

                        return true;
                    }
                    catch (Exception)
                    {

                        Transaction.Rollback();
                        return false;
                    }
                }
            }
        }


    }
    public class ClsPermisosUsuario 
    {
        public  bool agragar(object ob)
        {
            using (bulonera2Entities22 db = new bulonera2Entities22())
            {
                using (var Transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.USUARIOS.Add(((USUARIOS)ob));
                        db.SaveChanges();
                        Transaction.Commit();
                        Transaction.Dispose();

                        return true;
                    }
                    catch (Exception)
                    {

                        Transaction.Rollback();
                        return false;
                    }
                }
            }
        }


    }

    
}

