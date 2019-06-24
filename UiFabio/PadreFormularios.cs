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
    public partial class PadreFormularios : FormPadre


    {
        public PadreFormularios()
        {
            InitializeComponent();
        }

        private void PadreFormularios_Load(object sender, EventArgs e)
        {

        }

        private void BtnDesAcoplar_Click(object sender, EventArgs e)
        {
            if (this.TopLevel == false)
            {
                this.WindowState = FormWindowState.Normal;
                this.Parent.Controls.Remove(this);
                this.TopLevel = true;
            }
        }

    }
}
