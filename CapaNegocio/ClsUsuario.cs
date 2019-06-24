using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Configuration;


namespace CapaNegocios
{
    /// <summary>
    /// clase que me permite exponer la logica de los usuarios
    /// </summary>
    public class ClsUsuario

    {
        /// <summary>
        /// Variables globales del la propiedad
        /// </summary>
        public static USUARIOS UsuarioActual =null;
        public static bool ExisteSecion;
        private CapaDatos.USUARIOS Dbus;
        /// <summary>
        /// Definicion de contructor
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Contraceña"></param>
        /// <returns></returns>

        public static bool loggin(string Usuario,string Contraceña)
        {
            try
            {
                using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
                {
                    UsuarioActual = (from x in db.USUARIOS where x.nombre_usuario == Usuario && x.contraseña == Contraceña select x).FirstOrDefault();
                    if (UsuarioActual!=null)
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
        
    }
}
