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
            {
                if(MetroFramework.MetroMessageBox.Show(this, "Decea cargar un nuevo termino ? ", "No se encuentran terminos en este diccionario de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                }
            }
               


        }
        private void Btn_agregarMod_Click(object sender, EventArgs e)
        { 

                txb_Dato_nombreNuevo.Enabled = true;
                txb_Dato_AbrNuevo.Enabled = true;
                btn_guardarDatoNuevo.Visible = true;
                txb_Dato_AbrNuevo.Focus();
            gb_nuevoDato.BackColor = Color.FromArgb(39, 57, 30);
        }

        /////////////////////////////////////////////////-----------funciones del formulario-------------------//////////////////////
        ///
        private void CargarCabeceras()
        {
            List<CapaDatos.Diccionario_odfm> Dic_odfm =  diccionarios.TraerDiccionario_ODFM(0);
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

        private void Btn_guardarDatoNuevo_Click(object sender, EventArgs e)
        {
        if (txb_Dato_AbrNuevo.Text.Length == 3)
        {
            if (diccionarios.CargarNuevoTermino_ODFM(txb_Dato_nombreNuevo.Text.ToUpper(), txb_Dato_AbrNuevo.Text.ToUpper()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Exito", "El diccionario " + txb_Dato_nombreNuevo + " Se cargo correctamente", MessageBoxButtons.OK, MessageBoxIcon.None);
                txb_Dato_nombreNuevo.Clear();
                txb_Dato_AbrNuevo.Clear();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Se produjo un error", "El Diccionario no se cargo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo 'Codigo abreviatura' debe contener 3 caracteres OBLIGATORIAMENTE", "Reescriba los datos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
