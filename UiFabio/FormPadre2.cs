using System;
using System.Drawing;
using System.Windows.Forms;

namespace UiFabio
{
    public partial class FormPadre2 : Form
    {
        public FormPadre2()
        {
            InitializeComponent();
        }
        //OPCION 2 CON PANELES
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.PanelTodo.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        private void Btn_MinimizeWindow_Click(object sender, EventArgs e)
        {
            btn_MaximiseWindow.Visible = true;
            this.Dock = DockStyle.None;
            WindowState = FormWindowState.Minimized;

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

        private void MetroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
