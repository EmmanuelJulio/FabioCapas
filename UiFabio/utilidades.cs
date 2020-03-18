using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiFabio
{
    public  class utilidades
    {
        public static utilidades instans;

        private utilidades()
        {
        }
        public static utilidades GetUtilidades()
        {
            if(instans == null)
            {
                instans = new utilidades();
            }
            return instans;
        }

        public void CargarListBox (ListBox listBox, List<string> Lista)
        {
            foreach (string item in Lista)
            {
                listBox.Items.Add(item);
            }
        }

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
    public class Ayuda
    {
        public Ayuda()
        {
        }
        public void TextoInformativo(string Texto)
        {
            //foreach()
            //{
            //    if(item is Label & ((Label)item).AccessibleName == "lbl_informacion")
            //    {
            //        ((Label)item).Text = Texto;
            //    }
            //}
        }

    }
    public class Modulos
    {
        public static List<CapaDatos.MODULOS> OptenerModulos()
        {
            try
            {
                using (CapaDatos.bulonera2Entities22 db = new CapaDatos.bulonera2Entities22())
                {
                    List<CapaDatos.MODULOS> mod = (from x in db.MODULOS join a in db.MODULO_USUARIO on x.ID_MODULO equals a.ID_MODULO where a.ID_USUARIO == CNegocio.ClsUsuario.UsuarioActual.id_usuario select x).ToList();
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
                using (CapaDatos.bulonera2Entities22 db = new CapaDatos.bulonera2Entities22())
                {
                    List<CapaDatos.SUBMODULOS> mod = (from x in db.SUBMODULOS where x.ID_MODULO==id_modulo select x).ToList() ;
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
                using (CapaDatos.bulonera2Entities22 db = new CapaDatos.bulonera2Entities22())
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
