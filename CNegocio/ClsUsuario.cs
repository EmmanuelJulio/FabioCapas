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
         public USUARIOS OptenerUsuario(int id)
        {
            using (bulonera2Entities1 db = new bulonera2Entities1())
            {
                var usuarios = (from x in db.USUARIOS where x.id_usuario == id select x).FirstOrDefault();
                return usuarios;
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
                        db.USUARIOS.Remove(((USUARIOS)ob));
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
    public class ClsPermisosUsuario : IContrato2
    {
        public override bool agragar(object ob)
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

        public override bool eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public override object GetObjet(int id)
        {
            throw new NotImplementedException();
        }

        public override bool MOdificar(object id)
        {
            throw new NotImplementedException();
        }

        public override int OptenerId(string Text)
        {
            throw new NotImplementedException();
        }

        public override List<object> TraerTodos(string Text)
        {
            throw new NotImplementedException();
        }

        public override DataSet TraerTodos()
        {
            throw new NotImplementedException();
        }
    }
}

