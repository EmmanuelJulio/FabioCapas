using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;
using CapaDatos;

namespace UiFabio.Configuraciones.Modulos
{
    public partial class frm_submenus : PadreFormularios
    {
        CNegocio.ClsModulos OModulo = new CNegocio.ClsModulos();
        ClsSubModulo OSubMod = new ClsSubModulo();
        ClsSubMenu OSubMenu = new ClsSubMenu();
        int IdModuloSeleccionado;
        string NombreModuloSeleccionado;
        int IdSubModSeleccionado;
      
        
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
           
        }

        private void MetroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(metroTabControl1.SelectedIndex))
            {
                case 1:
                    listBoxModulos2.Items.Clear();
                    foreach(CapaDatos.MODULOS mod in OModulo.OptenerModulos(""))
                    {
                        listBoxModulos2.Items.Add(mod.NOMBRE_MOD);
                    }
                    
                    break;
                case 2:
                    listBoxModulos3.Items.Clear();
                    listBoxSubModulos2.Items.Clear();
                    foreach (CapaDatos.MODULOS mod in OModulo.OptenerModulos(""))
                    {
                        listBoxModulos3.Items.Add(mod.NOMBRE_MOD);
                    }
                   

                    break;
            }
            
        }

        private void ListBoxModulos2_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreModuloSeleccionado = ((ListBox)sender).SelectedItem.ToString();
            if (listBoxModulos2.SelectedItem != null)
            {
                listBoxSubModulos1.Items.Clear();
                IdModuloSeleccionado = OModulo.OptenerId(NombreModuloSeleccionado);
                
                foreach (SUBMODULOS Sub in OSubMod.OptenerModulos(IdModuloSeleccionado))
                {
                    listBoxSubModulos1.Items.Add(Sub.NOMBRE_SUBMOD);
                } 
            }
            else
            {
                MensajePers.message("No Selecciono nada", MensajePers.TipoMensaje.Error);
            }


        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SUBMODULOS subMod = new SUBMODULOS();
                subMod.ID_MODULO = IdModuloSeleccionado;
                subMod.NOMBRE_SUBMOD = metroTextBox1.Text;
                subMod.SYS_NOM = NombreModuloSeleccionado;

                OSubMod.agragar(subMod);
                listBoxSubModulos1.Items.Add(metroTextBox1.Text);
                MensajePers.message("Se Agrego el modulo", MensajePers.TipoMensaje.Hecho);
                metroTextBox1.Text = "";
            }
            catch (Exception)
            {

                MensajePers.message("Algo Paso", MensajePers.TipoMensaje.Error);
            }
        }

       

        private void ListBoxModulos3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSubForms.Items.Clear();
            NombreModuloSeleccionado = ((ListBox)sender).SelectedItem.ToString();
            if (listBoxModulos3.SelectedItem != null)
            {
                listBoxSubModulos2.Items.Clear();
                IdModuloSeleccionado = OModulo.OptenerId(NombreModuloSeleccionado);

                foreach (SUBMODULOS Sub in OSubMod.OptenerModulos(IdModuloSeleccionado))
                {
                    listBoxSubModulos2.Items.Add(Sub.NOMBRE_SUBMOD);
                }
            }
            else
            {
                MensajePers.message("No Selecciono nada", MensajePers.TipoMensaje.Error);
            }
        }

        private void ListBoxSubModulos2_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreModuloSeleccionado = ((ListBox)sender).SelectedItem.ToString();
            if (listBoxSubModulos2.SelectedItem != null)
            {
                listBoxSubForms.Items.Clear();
                 IdSubModSeleccionado= OSubMod.OptenerId(NombreModuloSeleccionado);

                foreach (SUBMENU Sub in OSubMenu.TraerSubmenus(IdSubModSeleccionado))
                {
                    listBoxSubForms.Items.Add(Sub.subMenu_nombre);
                }
            }
            else
            {
                MensajePers.message("No Selecciono nada", MensajePers.TipoMensaje.Error);
            }
        }

        private void BtnAgregarForm_Click(object sender, EventArgs e)
        {
            if (TextNombreForm.Text=="" || TextNombreSysForm.Text=="")
            {
                MensajePers.message("Debe completar los campos", MensajePers.TipoMensaje.Informacion);

            }
            else
            {
                SUBMENU Smenu = new SUBMENU();
                Smenu.ID_SUBMODULO = IdSubModSeleccionado;
                //foreach (SUBMODULOS subm in OSubMod.TraerTodos(""))
                //{
                //    if(subm.ID_SUBMODULO == IdSubModSeleccionado)
                //    {

                //        Smenu.SUBMODULOS = subm;
                //    }
                //}
                
                
                Smenu.subMenu_Sys = TextNombreSysForm.Text;
                Smenu.subMenu_nombre = TextNombreForm.Text;

               if(OSubMenu.agragar(Smenu))
                {
                    listBoxSubForms.Items.Add(TextNombreForm.Text);
                    MensajePers.message("Se creo", MensajePers.TipoMensaje.Hecho);
                    TextNombreForm.Text = "";
                    TextNombreSysForm.Text = "";
                }
                else
                {
                    MensajePers.message("Algo paso", MensajePers.TipoMensaje.Error);
                }
              
            }
        }

        private void MetroTabPage1_Click(object sender, EventArgs e)
        {

        }

       

        private void Btn_agregarMod_Click(object sender, EventArgs e)
        {
            if (txtmodulo.Text != "")
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

        private void Btn_EliminarMod_Click(object sender, EventArgs e)
        {
            if (listBoxModulos1.SelectionMode!=SelectionMode.None)
            {
                if (NombreModuloSeleccionado == "")
                {
                    MensajePers.message("Debe seleccionar un modulo para elminar primero", MensajePers.TipoMensaje.Error);
                }
                else
                {
                    int IDmOD = OModulo.OptenerId(NombreModuloSeleccionado);
                    if (OModulo.eliminar(IDmOD))
                    {
                        MensajePers.message("Se elimino", MensajePers.TipoMensaje.Hecho);
                        listBoxModulos1.Items.Remove(NombreModuloSeleccionado);
                    }
                    else
                    {
                        MensajePers.message("Algo paso", MensajePers.TipoMensaje.Error);
                    }
                }
            }
            else
            {
                MensajePers.message("Ahora seleccione un modulo para eliminar", MensajePers.TipoMensaje.Informacion);
                listBoxModulos1.SelectionMode = SelectionMode.One;
                listBoxModulos1.BackColor = Color.White;
            }

        }

        private void ListBoxModulos1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxModulos1.SelectedItem!=null)
            {
                string modulo = "";
                modulo = listBoxModulos1.SelectedItem.ToString();
                NombreModuloSeleccionado = modulo; 
            }

        }
    }
}
