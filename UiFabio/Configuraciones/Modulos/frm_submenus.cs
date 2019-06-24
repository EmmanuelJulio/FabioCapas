using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiFabio.Configuraciones.Modulos
{
    public partial class frm_submenus : PadreFormularios
    {
        CNegocio.ClsModulos OModulo = new CNegocio.ClsModulos();
        public frm_submenus()
        {
            InitializeComponent();
        }

        private void Frm_submenus_Load(object sender, EventArgs e)
        {
            
            foreach (CapaDatos.MODULOS item in OModulo.OptenerModulos(""))
            {
                listBoxModulos1.Items.Add(item.NOMBRE_MOD);
            }
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_agregarmodulo_Click(object sender, EventArgs e)
        {
            if (txtmodulo.Text!="")
            {
                try
                {
                    CapaDatos.MODULOS NuevoMod = new CapaDatos.MODULOS();
                    NuevoMod.NOMBRE_MOD = txtmodulo.Text;
                    NuevoMod.COD_MOD = "Btn" + txtmodulo.Text;
                    OModulo.agragar(NuevoMod);
                    listBoxModulos1.Items.Add(txtmodulo.Text);
                    MensajePers.message("Se Cargo", MensajePers.TipoMensaje.Hecho);
                    
                }
                catch (Exception)
                {

                    MensajePers.message("Algo paso", MensajePers.TipoMensaje.Error);
                }
            }
            else
            {
                MensajePers.message("El Campo nombre esta bacio ", MensajePers.TipoMensaje.Informacion);
            }
        }

        private void MetroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch(metroTabControl1.SelectedIndex):
            //case
        }
    }
}
