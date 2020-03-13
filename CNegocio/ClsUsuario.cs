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
        public List<USUARIOS> TraerUsuarios()
        {
            using(bulonera2Entities1 db = new bulonera2Entities1())
            {
                var usuarios = (from x in db.USUARIOS select x).ToList();
                return usuarios;
            } 
        }
         public int OptenerUsuario(string nombre)
        {
            using (bulonera2Entities1 db = new bulonera2Entities1())
            {
                var usuarios = (from x in db.USUARIOS where x.nombre == nombre select x).FirstOrDefault();
                return usuarios.id_usuario;
            }
        }

        public bool EliminarUsuario(object ob)
        {
            using (bulonera2Entities1 db = new bulonera2Entities1())
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
                using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
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
            using (bulonera2Entities1 db = new bulonera2Entities1())
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
            using (bulonera2Entities1 db = new bulonera2Entities1())
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

