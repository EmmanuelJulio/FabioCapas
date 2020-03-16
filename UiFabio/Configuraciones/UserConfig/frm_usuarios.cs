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
            metroTabControl1.SelectedTab = metroTabControl1.TabPages[0];
            Actualizar();

        }
        public void Actualizar()
        {
            ClsModulos mod = new ClsModulos();
            for (int i = 0; i < CHK_Modulos.Items.Count; i++)
            {
                CHK_Modulos.Items.Remove(i); 
            }
            foreach (CapaDatos.MODULOS _mod in mod.OptenerTodosLosModulos())
            {
                CHK_Modulos.Items.Add(_mod.NOMBRE_MOD);

            }

            ClsDiccionarios cl = new ClsDiccionarios();
            for (int i = 0; i < ComboSectores.Items.Count; i++)
            {
                ComboSectores.Items.Remove(i); 
            }
            foreach (CapaDatos.DICCIONARIO_FAB fb in cl.TraerDicFab(28))
            {
                ComboSectores.Items.Add(fb.dic_des.ToString());
            }
            ClsUsuario usu = new ClsUsuario();
            for (int i = 0; i < listUsu.Items.Count; i++)
            {
                listUsu.Items.RemoveAt(i); 
            }
            foreach (CapaDatos.USUARIOS usuar in usu.TraerUsuarios())
            {
                listUsu.Items.Add(usuar.nombre);
                listusuarios2.Items.Add(usuar.nombre);
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
                    NewUser.nombre_usuario = txbUsuario.Text;
                    if (ClsUsuario.agragar(NewUser))
                    {
                        Actualizar();
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
            Actualizar();
        }

        private void Btn_EliminarMod_Click(object sender, EventArgs e)
        {
            
            if(listUsu.SelectedItem != null)
            {
                try
                {
                    ClsUsuario cs = new ClsUsuario();
                    if (cs.EliminarUsuario(listUsu.SelectedItem.ToString()))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "se elimino el usuario " + listUsu.SelectedItem.ToString());
                        listUsu.Items.Clear();
                        ClsUsuario usu = new ClsUsuario();
                        foreach (CapaDatos.USUARIOS usuar in usu.TraerUsuarios())
                        {
                            listUsu.Items.Add(usuar.nombre);
                        }
                        Actualizar();

                    }   

                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "No se elimino el usuario " + listUsu.SelectedItem.ToString());
                }
            }
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void Listusuarios2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i=0; i < CHK_Modulos.Items.Count; i++)
            {
                CHK_Modulos.SetItemChecked(i, false);
            }
            ClsUsuario cmod = new ClsUsuario();

            if (listusuarios2.SelectedItem != null)
            {
                foreach (CapaDatos.MODULOS mod in cmod.TraerAccesosActuales(cmod.OptenerUsuario(listusuarios2.SelectedItem.ToString())))
                {

                    for (int i = 0; i < CHK_Modulos.Items.Count; i++)
                    {
                        if (CHK_Modulos.Items[i].ToString() == mod.NOMBRE_MOD)
                        {
                            CHK_Modulos.SetItemChecked(i, true);
                        }
                    }
                } 
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Seleccione un usuario valido");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsUsuario _usuario = new ClsUsuario();
            ClsModulos _mod = new ClsModulos();
            int Idusu = _usuario.OptenerUsuario(listusuarios2.SelectedItem.ToString());
           
            for (int i = 0; i < CHK_Modulos.Items.Count; i++)
            {
                if (CHK_Modulos.GetItemChecked(i))
                {
                    _mod.ArgregarPermiso(Idusu, _mod.opteneridmodulo(CHK_Modulos.Items[i].ToString())); 
                }
                else
                {
                    if (_mod.Idpermiso(Idusu, _mod.opteneridmodulo(CHK_Modulos.Items[i].ToString())) != 0)
                    {
                        int idPermiso = _mod.Idpermiso(Idusu, _mod.opteneridmodulo(CHK_Modulos.Items[i].ToString()));
                        _mod.QuitarPermiso(idPermiso);
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "No se puede esto");
                    }
                    

                    
                }
            }
        }
    }
}
