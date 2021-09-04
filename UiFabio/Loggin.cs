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
    public partial class Loggin : Form
    {
        public Loggin()
        {
            InitializeComponent();
        }
        private void Txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnlogin.Focus();
            }
        }
        private void Txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtpass.Focus();
            }
        }
        private void Txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }
        private void Txtpass_Enter_1(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }
        private void Txtuser_Enter_1(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }
        private void Txtuser_Leave_1(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            HORA.Text = DateTime.Now.ToLongTimeString();
            Dia.Text = DateTime.Now.ToLongDateString();
            if (this.Opacity != 1)
            {
                this.Opacity +=  0.15;
            }
            
           
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            MensajeError.Visible = false;
            if (txtuser.Text == "Usuario")
            {
                MensajeError.Visible = true;
                MensajeError.Text = "Debe ingresar un usuario";

            }
            else {
                if (txtpass.Text == "Contraseña")
                {
                    MensajeError.Visible = true;
                    MensajeError.Text = "Debe ingresar una contraseña";
                    
                }
                else
                {
                    if (CNegocio.ClsUsuario.loggin(txtuser.Text, txtpass.Text))
                    {
                        this.Hide();
                        Principal Pn = new Principal();
                        Pn.Show();
                    }
                    else
                    {
                        MensajePers.message("no se econtro el usuario", MensajePers.TipoMensaje.Error);
                    }
                }
            }
           
            
        }
    }
}
