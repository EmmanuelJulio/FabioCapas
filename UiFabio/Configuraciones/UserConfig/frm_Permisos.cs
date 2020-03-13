using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiFabio.Configuraciones.UserConfig
{
    public partial class frm_Permisos : PadreFormularios
    {
        public frm_Permisos()
        {
            InitializeComponent();
        }

        private void Frm_Permisos_Load(object sender, EventArgs e)
        {
            foreach (var usuario in CNegocio.ClsUsuario.GetAllUsers())
            {
               string Nombrecompleto = utilidades.FirstCharToUpper(usuario.nombre) + " " + utilidades.FirstCharToUpper(usuario.apellido);
                //ListBoxUsuarios.Items.Add(Nombrecompleto);
            }
           
        }

        private void Lbl_texto_Click(object sender, EventArgs e)
        {

        }
    }
}
