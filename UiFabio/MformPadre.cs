using System;
using System.Windows.Forms;

namespace UiFabio
{
    public partial class MformPadre : Form

    {
        public MformPadre()
        {


            InitializeComponent();
        }

        private void MformPadre_Load(object sender, EventArgs e)
        {

        }

        private void Desacoplar_Click(object sender, EventArgs e)
        {
            if (this.TopLevel == false)
            {
                this.Parent.Controls.Remove(this);
                this.TopLevel = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            metroStyleManager1.Theme = UiFabio.MetroForms.Principal.Estilo;
            metroStyleManager1.Style = UiFabio.MetroForms.Principal.ColorEstilo;
        }

        private void Btn_MinimizeWindow_Click(object sender, EventArgs e)
        {
            btn_MaximiseWindow.Visible = true;

            WindowState = FormWindowState.Minimized;
            this.Dock = DockStyle.None;
        }

        private void Btn_MaximiseWindow_Click(object sender, EventArgs e)
        {
            btn_MaximiseWindow.Visible = false;
            btn_normalWindow.Visible = true;
            this.Dock = DockStyle.Fill;
        }

        private void Btn_CloseForm_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Btn_normalWindow_Click(object sender, EventArgs e)
        {
            btn_normalWindow.Visible = false;
            btn_MaximiseWindow.Visible = true;
            WindowState = FormWindowState.Normal;
            this.Dock = DockStyle.None;
        }


    }
}
