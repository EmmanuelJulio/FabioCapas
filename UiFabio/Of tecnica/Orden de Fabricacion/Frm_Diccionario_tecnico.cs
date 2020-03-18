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

namespace UiFabio.Of_tecnica.Orden_de_Fabricacion
{
    public partial class Frm_Diccionario_tecnico : PadreFormularios
    {
        Ayuda _ayuda = new Ayuda();
        ClsDiccionarios diccionarios = new ClsDiccionarios();
        string Cabecera;
        string Terminos;
        
        List<string> ListaAcargar = new List<string>();
        public Frm_Diccionario_tecnico()
        {
            //MetroFramework.MetroMessageBox.Show(this, "Yes/no", "¿Desea agregar un nuevo elemento padre del cual dependen sus dependencias?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
            InitializeComponent();
        }

        private void Frm_Diccionario_tecnico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bulonera2DataSet.Diccionario_odfm' Puede moverla o quitarla según sea necesario.
            this.diccionario_odfmTableAdapter.Fill(this.bulonera2DataSet.Diccionario_odfm);
            CargarCabeceras();
        }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
        private void listDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDatos.SelectedItem != null)
            {
                btn_nuevoTermino.Enabled = true;
                cargarTerminosDeDIcc();
            }
            

        }
        
        private void cargarTerminosDeDIcc()
        {
            string seleccion = listDatos.Items[listDatos.SelectedIndex].ToString();
            int largo = seleccion.Length-3;
            string abr;
            string des;
            abr = seleccion.Remove(3, largo);
            des = seleccion.Remove(0, 5);
            if(!CargarDatos(abr, des))
               MetroFramework.MetroMessageBox.Show(this,"Si / No", "¿Desea agregar un nuevo elemento padre del cual dependen sus dependencias?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)


        }

        /////////////////////////////////////////////////-----------funciones del formulario-------------------//////////////////////
        ///
        private void CargarCabeceras()
        {
            List<CapaDatos.Diccionario_odfm> Dic_odfm = diccionarios.TraerDiccionario_ODFM(0);
            ListaAcargar.Clear();
            foreach (CapaDatos.Diccionario_odfm dic in (from x in Dic_odfm where x.dic_cab == 0 select x))
            {
                ListaAcargar.Add(dic.dic_abr + " - " + dic.dic_des);
            }
            utilidades.GetUtilidades().CargarListBox(listDatos, ListaAcargar);

        }
        private bool CargarDatos(string abr ,string des)
        {
            listTerminos.Items.Clear();
            List<CapaDatos.Diccionario_odfm> datos = diccionarios.OptnerDatosDeCabecera(abr, des);
                if (datos.Any())
            {
                foreach (CapaDatos.Diccionario_odfm item in datos)
                {
                    listTerminos.Items.Add(item.dic_des);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
