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

namespace UiFabio.MetroForms
{
    public partial class Principal : MetroFramework.Forms.MetroForm
    {
        string moduloseleccionado;
        string opcionseleccionada;
        public Principal()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            Botones.Width = 240;
        }
        public void Deslizar(Panel Aesconeder, Panel Amostrar)
        {
            PanelAnimador.HideSync(Aesconeder);
            PanelAnimador.ShowSync(Amostrar);
            Amostrar.Width = 200;
        }

        private void MetroFormPadre_Load(object sender, EventArgs e)
        {
            mboxColor.SelectedIndex = 1;
            metroComboBox1.SelectedIndex = 0;
            pnlmodulos.Width = 200;
            PanelForm.Width = 0;
            PnlSubMenus.Width = 0;
            txt_usuario.Text = utilidades.FirstCharToUpper(CapaNegocios.ClsUsuario.UsuarioActual.nombre) + " " + utilidades.FirstCharToUpper(CapaNegocios.ClsUsuario.UsuarioActual.apellido);
            Txt_sector.Text = utilidades.FirstCharToUpper(CapaNegocios.ClsUsuario.UsuarioActual.sector);
            Botones.Width = 200;
            foreach (CapaDatos.MODULOS Mod in UiFabio.Modulos.OptenerModulos())
            {
                pnlmodulos.Controls.Add(boton(Mod.NOMBRE_MOD, Mod.ID_MODULO, Modulos_Click));
            }

        }
        public MetroFramework.Controls.MetroButton boton(string nombre, int id_mod, EventHandler cosa)
        {
            MetroFramework.Controls.MetroButton Boton = new MetroFramework.Controls.MetroButton();
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

        public MetroFramework.Controls.MetroButton boton2(string nombre, string FormNombre, EventHandler cosa)
        {
            MetroFramework.Controls.MetroButton Boton = new MetroFramework.Controls.MetroButton();
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
        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
            }
        }

        private void MboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(mboxColor.SelectedIndex);
        }

        private void Modulos_Click(object sender, EventArgs e)
        {
            PnlSubMenus.Controls.Clear();

            int id = Convert.ToInt32(((Button)sender).AccessibleName);
            foreach (CapaDatos.SUBMODULOS SubMod in UiFabio.SubModulos.OptenerSubModulos(id))
            {
                PnlSubMenus.Controls.Add(boton(SubMod.NOMBRE_SUBMOD, SubMod.ID_SUBMODULO, Submodulos_Click));

            }
            lbl_texto.Text = ((Button)sender).Text;
            moduloseleccionado = ((Button)sender).Text;
            Deslizar(pnlmodulos, PnlSubMenus);
            Btn_volvermodulos.Visible = true;
        }

        private void Submodulos_Click(object sender, EventArgs e)
        {
            PanelForm.Controls.Clear();
            int id = Convert.ToInt32(((Button)sender).AccessibleName);
            foreach (CapaDatos.SUBMENU SubMod in UiFabio.SubMenus.OptenerSubMenus(id))
            {
                PanelForm.Controls.Add(boton2(SubMod.subMenu_nombre, SubMod.subMenu_Sys, Submenu_Click));

            }
            opcionseleccionada = ((Button)sender).Text;
            lbl_texto.Text = ((Button)sender).Text;
            Deslizar(PnlSubMenus, PanelForm);
            Btn_volvermodulos.Visible = false;
            Btn_volveropciones.Visible = true;
        }

        private void Submenu_Click(object sender, EventArgs e)
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
            Deslizar(PnlSubMenus, pnlmodulos);
        }

        private void Btn_volveropciones_Click(object sender, EventArgs e)
        {
            lbl_texto.Text = moduloseleccionado;
            Btn_volveropciones.Visible = false;
            Btn_volvermodulos.Visible = true;
            Deslizar(PanelForm, PnlSubMenus);
        }
        public void AbrirFormHijo(object formhijo)
        {
            if (this.Contenedor.Controls.Count > 0)
            {
                this.Contenedor.Controls.RemoveAt(0);
            }

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Dock = DockStyle.Fill;
            fh.Show();


        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            Dia.Text = DateTime.Now.ToLongDateString();
            Hora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
