using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CNegocio
{
    public class ClsModulos : IContrato
    {
        public List<MODULOS> OptenerTodosLosModulos()
        {
            using (CapaDatos.bulonera2Entities1 db = new bulonera2Entities1())
            {
                var mod = (from x in db.MODULOS select x).ToList();
                return mod;
            }
        }
        public static List<string> ModulosUsuario;


        public List<CapaDatos.MODULOS> OptenerModulos(string Text)
        {
            try
            {
                using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
                {
                    List<CapaDatos.MODULOS> mod = (from x in db.MODULOS where x.NOMBRE_MOD.Contains(Text) select x).ToList();
                    return mod;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override bool agragar(object ob)
        {
            using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                using (var Transaction = db.Database.BeginTransaction())
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

        public override bool eliminar(int Id)
        {
            using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                try
                {
                    CapaDatos.MODULOS ModuloBorrar = (from x in db.MODULOS where x.ID_MODULO == Id select x).FirstOrDefault();
                    db.MODULOS.Remove(ModuloBorrar);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }

       

        public override bool MOdificar(int id)
        {
            throw new NotImplementedException();
        }

        public override int OptenerId(string Text)
        {
            using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                int _id = Convert.ToInt32((from x in db.MODULOS where x.NOMBRE_MOD == Text select x.ID_MODULO).FirstOrDefault());
                return _id;
            }
        }

        public override List<object> traerTodos(string Text)
        {
            throw new NotImplementedException();
        }
    }
    public class ClsSubMenu : IContrato
    {
        public override bool agragar(object ob)
        {
            using(bulonera2Entities1 db = new bulonera2Entities1())
            {
                using(var Transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.SUBMENU.Add(((CapaDatos.SUBMENU)ob));
                        db.SaveChanges();
                        Transaction.Commit();
                        Transaction.Dispose();
                        
                        return true;
                    }
                    catch (Exception )
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

        public override bool MOdificar(int id)
        {
            throw new NotImplementedException();
        }

        public override int OptenerId(string Text)
        {
            using(bulonera2Entities1 db = new bulonera2Entities1())
            {
                int id = Convert.ToInt32(from x in db.SUBMENU where x.subMenu_nombre == Text select x.id_SubMenu);
                return id;
            }
        }
        public  int OptenerIdSubmod(string Text)
        {
            using (bulonera2Entities1 db = new bulonera2Entities1())
            {
                int id = Convert.ToInt32(from x in db.SUBMENU where x.subMenu_nombre == Text select x.ID_SUBMODULO);
                return id;
            }
        }

        public override List<object> traerTodos(string Text)
        {
            throw new NotImplementedException();
        }
        public  List<SUBMENU> TraerSubmenus(int id_subMod)
        {
            using(bulonera2Entities1 db = new bulonera2Entities1())
            {
                  List < SUBMENU > ListaMenus= (from x in db.SUBMENU where x.ID_SUBMODULO == id_subMod select x).ToList();
                return ListaMenus;
            }
        }
    }
    public class ClsSubModulo : IContrato
    {
        public override bool agragar(object ob)
        {
            using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                using (var transaccion = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.SUBMODULOS.Add(((CapaDatos.SUBMODULOS)ob));
                        db.SaveChanges();
                        transaccion.Commit();
                        transaccion.Dispose();
                        return true;
                    }
                    catch (Exception)
                    {

                        transaccion.Rollback();
                        return false;
                    }
                }

            }
        }

        public override bool eliminar(int id)
        {
            using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                try
                {
                    CapaDatos.SUBMODULOS ModuloBorrar = (from x in db.SUBMODULOS where x.ID_SUBMODULO == id select x).FirstOrDefault();
                    db.SUBMODULOS.Remove(ModuloBorrar);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }

        public override bool MOdificar(int id)
        {
            throw new NotImplementedException();
        }

        public override int OptenerId(string Text)
        {
            using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                int _id = Convert.ToInt32((from x in db.SUBMODULOS where x.NOMBRE_SUBMOD == Text select  x.ID_SUBMODULO ).FirstOrDefault());
                return _id;
            }
        }
        /// <summary>
        ///             Me debuelve el id del modulo que contiene al sub modulo a partir del nombre de entrada 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public int OptenerIdModulo(string Text)
        {
            using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                int _id = Convert.ToInt32((from x in db.SUBMODULOS where x.NOMBRE_SUBMOD == Text select x.ID_MODULO).FirstOrDefault());
                return _id;
            }
        }

        public override List<object> traerTodos(string Text)
        {
            throw new NotImplementedException();
        }
        public  List<SUBMODULOS> TraerTodos(string Text)
        {
            using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                List<CapaDatos.SUBMODULOS> mod = (from x in db.SUBMODULOS where x.NOMBRE_SUBMOD.Contains(Text) select x).ToList();
                return (mod);
            }
        }
        /// <summary>
        /// Me trae todos los sub modulos que pertenescan a un id modulo igual
        /// </summary>
        /// <param name="ID_modulo"></param>
        /// <returns></returns>
        public List<CapaDatos.SUBMODULOS> OptenerModulos(int ID_modulo)
        {
            try
            {
                using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
                {
                    List<CapaDatos.SUBMODULOS> mod = (from x in db.SUBMODULOS where x.ID_MODULO == ID_modulo select x).ToList();
                    return mod;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
