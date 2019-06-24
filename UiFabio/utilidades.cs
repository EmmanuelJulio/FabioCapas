using System;
using System.Collections.Generic;
using System.Linq;

namespace UiFabio
{
    public static class utilidades
    {
        public static string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

    }
    public class Modulos
    {
        public static List<CapaDatos.MODULOS> OptenerModulos()
        {
            try
            {
                using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
                {
                    List<CapaDatos.MODULOS> mod = (from x in db.MODULOS join a in db.MODULO_USUARIO on x.ID_MODULO equals a.ID_MODULO where a.ID_USUARIO == CapaNegocios.ClsUsuario.UsuarioActual.id_usuario select x).ToList();
                    return mod;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    public class SubModulos
    {
        public static List<CapaDatos.SUBMODULOS> OptenerSubModulos(int id_modulo)
        {
            try
            {
                using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
                {
                    List<CapaDatos.SUBMODULOS> mod = (from x in db.SUBMODULOS where x.ID_MODULO == id_modulo select x).ToList();
                    return mod;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    public class SubMenus
    {
        public static List<CapaDatos.SUBMENU> OptenerSubMenus(int id_SubMod)
        {
            try
            {
                using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
                {
                    List<CapaDatos.SUBMENU> Submod = (from x in db.SUBMENU where x.ID_SUBMODULO == id_SubMod select x).ToList();
                    return Submod;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }



}
