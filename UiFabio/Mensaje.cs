using System;
using System.Windows.Forms;

namespace UiFabio
{
    public partial class MensajePers : Form
    {
        public MensajePers(string sms, TipoMensaje type)
        {
            InitializeComponent();
            show.Start();
            bunifuCustomLabel1.Text = sms;
            switch (type)
            {
                case TipoMensaje.Acceso:
                    icon.Image = listicon.Images[3];
                    break;
                case TipoMensaje.Error:
                    icon.Image = listicon.Images[1];
                    break;
                case TipoMensaje.Hecho:
                    icon.Image = listicon.Images[4];
                    break;
                case TipoMensaje.Informacion:
                    icon.Image = listicon.Images[5];
                    break;
                case TipoMensaje.Peligro:
                    icon.Image = listicon.Images[6];
                    break;
            }
        }

        public static void message(string _sms, TipoMensaje _type)
        {
            new MensajePers(_sms, _type).ShowDialog();

        }
        public enum TipoMensaje
        {
            Hecho, Peligro, Error, Informacion, Acceso

        }
        private void Hide_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.3;
            }
            else
            {
                Close();

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            hide.Start();
        }

        private void Show_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.2;
            }
            else
            {
                show.Stop();
            }
        }

        private void MensajePers_Load(object sender, EventArgs e)
        {

            this.Opacity = 0.1;

        }

        private void Icon_Click(object sender, EventArgs e)
        {

        }
    }
}
