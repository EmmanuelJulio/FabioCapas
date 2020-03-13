using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CNegocio;

namespace UiFabio.Configuraciones.UserConfig
{
    public partial class frm_usuarios : PadreFormularios
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }
        private void frm_usuarios_Load(object sender, EventArgs e)
        {
            ClsDiccionarios cl = new ClsDiccionarios();
            foreach(CapaDatos.DICCIONARIO_FAB fb in cl.TraerDicFab(28))
            {
                ComboSectores.Items.Add(fb.dic_des.ToString());
            }
        }

        private void PanelTrabajo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txbApellido.Text != ""|| txbNombre.Text != ""|| txbUsuario.Text != ""|| txbContraceña.Text != ""|| txbContraceña2.Text != "")
            {
                if (txbContraceña.Text == txbContraceña2.Text)
                {
                    CapaDatos.USUARIOS NewUser = new CapaDatos.USUARIOS();
                    NewUser.nombre = txbNombre.Text;
                    NewUser.apellido = txbApellido.Text;
                    NewUser.contraseña = txbContraceña.Text;
                    NewUser.acceso = "";
                    NewUser.sector = ComboSectores.Text;
                    if (ClsUsuario.agragar(NewUser))
                    {


                        MensajePers.message("Se cargo el usuario"+ txbUsuario.Text, MensajePers.TipoMensaje.Hecho);
                        txbApellido.Clear();
                        txbContraceña.Clear();
                        txbUsuario.Clear();
                        txbContraceña2.Clear();
                        txbNombre.Clear();
                        ComboSectores.Text = "";
                        

                      

                    }
               else
                    {

                        MensajePers.message("Corrija los campos por favor.", MensajePers.TipoMensaje.Error);
                    }
                }
               
            }
            else
            {
                MensajePers.message("El Campo nombre esta bacio ", MensajePers.TipoMensaje.Informacion);
            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
