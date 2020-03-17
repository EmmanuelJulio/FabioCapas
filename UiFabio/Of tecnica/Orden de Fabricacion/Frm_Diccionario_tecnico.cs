using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiFabio.Of_tecnica.Orden_de_Fabricacion
{
    public partial class Frm_Diccionario_tecnico : PadreFormularios
    {
        Ayuda _ayuda = new Ayuda();
        string Cabecera;
        string Terminos;
        public Frm_Diccionario_tecnico()
        {
            InitializeComponent();
        }

        private void Frm_Diccionario_tecnico_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_MouseHover(object sender, EventArgs e)
        {
            _ayuda.TextoInformativo("la informacion se tendria que estar viendo si hago esto");
        }

        private void Btn_agregarMod_Click(object sender, EventArgs e)
        {

        }

        private void listBoxModulos1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cabecera = list_Cabeceras.SelectedItem.ToString();
            if (MetroFramework.MetroMessageBox.Show(this, "Yes/no", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Pnl_CrearNuevaCabecera.Visible = true;
            }
        }
    }
}
