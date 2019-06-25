using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace UiFabio
{
    public partial class Principal : FormPadre

    {
        string moduloseleccionado;
        string opcionseleccionada;
        public void Deslizar(Panel Aesconeder, Panel Amostrar)
        {
            PanelAnimador.HideSync(Aesconeder);
            PanelAnimador.ShowSync(Amostrar);
            Amostrar.Width = 200;
        }
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            PnlModulos.Width = 200;
            PanelForm.Width = 0;
            PnlSubMenus.Width = 0;
            txt_usuario.Text = utilidades.FirstCharToUpper(CNegocio.ClsUsuario.UsuarioActual.nombre)+" " + utilidades.FirstCharToUpper(CNegocio.ClsUsuario.UsuarioActual.apellido);
            Txt_sector.Text = CNegocio.ClsUsuario.UsuarioActual.sector;
            Botones.Width = 200;
            foreach (CapaDatos.MODULOS Mod in UiFabio.Modulos.OptenerModulos() )
            { 
                PnlModulos.Controls.Add(boton(Mod.NOMBRE_MOD,Mod.ID_MODULO, Modulos_Click));
            }
        }
        public Button boton(string nombre ,int id_mod,EventHandler cosa)
        {
            Button Boton = new Button();
            Boton.Text = nombre;
            Boton.AccessibleName = (id_mod).ToString();
            Boton.Dock = DockStyle.Top;
            Boton.Height = 30;
            Boton.BackColor = Color.FromArgb(15, 112, 183);
            Boton.FlatStyle = FlatStyle.Flat;
            Boton.ForeColor = Color.FromArgb(45, 45, 48);
            Boton.Click += new EventHandler(cosa);
            Boton.BackColor = Color.FromArgb(18, 134, 219);
            Boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Boton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Boton.ForeColor = Color.Silver;
            Boton.FlatAppearance.BorderSize = 0;
            return Boton;
        }
        public Button boton2(string nombre, string FormNombre, EventHandler cosa)
        {
            Button Boton = new Button();
            Boton.Text = nombre;
            Boton.AccessibleName = FormNombre;
            Boton.Dock = DockStyle.Top;
            Boton.Height = 30;
            Boton.BackColor = Color.FromArgb(15, 112, 183);
            Boton.FlatStyle = FlatStyle.Flat;
            Boton.ForeColor = Color.FromArgb(45, 45, 48);
            Boton.Click += new EventHandler(cosa);
            Boton.BackColor = Color.FromArgb(18, 134, 219);
            Boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Boton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Boton.ForeColor = Color.Silver;
            Boton.FlatAppearance.BorderSize = 0;
            return Boton;
        }
        private void Hora_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            Dia.Text = DateTime.Now.ToLongDateString();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            CNegocio.ClsUsuario.UsuarioActual = null;
            this.Hide();
            Loggin lg = new Loggin();
            lg.Show();
            

        }

        private void Modulos_Click(object sender, EventArgs e)
        {
            PnlSubMenus.Controls.Clear();


            int id = Convert.ToInt32(((Button)sender).AccessibleName);
            foreach (CapaDatos.SUBMODULOS SubMod in UiFabio.SubModulos.OptenerSubModulos(id))
            {
                PnlSubMenus.Controls.Add(boton(SubMod.NOMBRE_SUBMOD, SubMod.ID_SUBMODULO, SubModulos_Click));

            }
            lbl_texto.Text = ((Button)sender).Text;
            moduloseleccionado= ((Button)sender).Text;
            Deslizar(PnlModulos, PnlSubMenus);
            Btn_volvermodulos.Visible = true;
            
        }

        private void SubModulos_Click(object sender, EventArgs e)
        {
            PanelForm.Controls.Clear();
            int id = Convert.ToInt32(((Button)sender).AccessibleName);
            foreach (CapaDatos.SUBMENU SubMod in UiFabio.SubMenus.OptenerSubMenus(id))
            {
                PanelForm.Controls.Add(boton2(SubMod.subMenu_nombre, SubMod.subMenu_Sys, SubMenu_Click));

            }
            opcionseleccionada = ((Button)sender).Text;
            lbl_texto.Text = ((Button)sender).Text;
            Deslizar(PnlSubMenus, PanelForm);
            Btn_volvermodulos.Visible = false;
            Btn_volveropciones.Visible = true;
        }

        private void SubMenu_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_texto.Text = ((Button)sender).Text;
                string NameSpace = "UiFabio" + "." + moduloseleccionado + "." + opcionseleccionada;
                string NombreForm = ((Button)sender).AccessibleName;
                while (NameSpace.Contains(" "))
                {
                    NameSpace.Remove(8, 1);
                }
                Assembly asm = Assembly.GetEntryAssembly();
                Type formtype = asm.GetType(string.Format("{0}.{1}", NameSpace, NombreForm));

                Form f = (Form)Activator.CreateInstance(formtype);

                AbrirFormHijo(f);
            }
            catch (Exception)
            {

                MensajePers.message("No se encontro el form", MensajePers.TipoMensaje.Error);
                
            }
        }

        private void Btn_volvermodulos_Click(object sender, EventArgs e)
        {
            lbl_texto.Text = "Modulos";
            Btn_volvermodulos.Visible = false;
            Deslizar(PnlSubMenus, PnlModulos);
        }

        private void Btn_volveropciones_Click(object sender, EventArgs e)
        {
            lbl_texto.Text = moduloseleccionado;
            Btn_volveropciones.Visible = false;
            Btn_volvermodulos.Visible = true;
            Deslizar(PanelForm, PnlSubMenus);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void AbrirFormHijo(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Dock = DockStyle.Fill;
            fh.Show();


        }
    }
}
