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
        public string abr;
        public string des;

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
            
            abr = seleccion.Remove(3, listDatos.Items[listDatos.SelectedIndex].ToString().Length-3);
            des = seleccion.Remove(0, 5);
            if(!CargarDatos(abr, des))
            {

            }
        }
        private void Btn_agregarMod_Click(object sender, EventArgs e)
        {
            FocusCargarNuevoDiccionario();
        }

        /////////////////////////////////////////////////-----------funciones del formulario-------------------//////////////////////
        /// <summary>
        
        /// </summary>
        /// 
        private void FocusCargarNuevoDiccionario()
        {

            lbl_tipodato.Text = "Descripcion del nuevo dato";
            txb_Dato_nombreNuevo.Enabled = true;
            txb_Dato_AbrNuevo.Enabled = true;
            btn_agregarNuevoDiccionario.Visible = true;
            txb_Dato_AbrNuevo.Focus();
            gb_nuevoDato.BackColor = Color.FromArgb(39, 57, 30);
        }
        private void QuitarFocusNuevoDiccionario()
        {
            txb_Dato_nombreNuevo.Clear();
            txb_Dato_AbrNuevo.Clear();
            lbl_tipodato.Text = "Nuevo Dato";
            txb_Dato_nombreNuevo.Enabled = false;
            txb_Dato_AbrNuevo.Enabled = false;
            btn_agregarNuevoDiccionario.Visible = false;
            gb_nuevoDato.BackColor = Color.FromArgb(39, 57, 80);
        }
        private void FocusCargarNuevoDato()
        {

            lbl_tipodato.Text = "Descripcion del nuevo dato";
            txb_Dato_nombreNuevo.Enabled = true;
            txb_Dato_AbrNuevo.Enabled = true;
            btn_agregarNuevoDato.Visible = true;
            txb_Dato_AbrNuevo.Focus();
            gb_nuevoDato.BackColor = Color.FromArgb(39, 57, 30);
        }
        private void QuitarFocusNuevoDato()
        {
            txb_Dato_nombreNuevo.Clear();
            txb_Dato_AbrNuevo.Clear();
            lbl_tipodato.Text = "Nuevo Dato";
            txb_Dato_nombreNuevo.Enabled = false;
            txb_Dato_AbrNuevo.Enabled = false;
            btn_agregarNuevoDato.Visible = false;
            gb_nuevoDato.BackColor = Color.FromArgb(39, 57, 80);
        }

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
            if (diccionarios.CargarNuevoDiccionario_ODFM(txb_Dato_nombreNuevo.Text.ToUpper(), txb_Dato_AbrNuevo.Text.ToUpper()))
            {
                 MetroFramework.MetroMessageBox.Show(this, "Exito", "El diccionario " + txb_Dato_nombreNuevo + " Se cargo correctamente", MessageBoxButtons.OK, MessageBoxIcon.None);
                    QuitarFocusNuevoDiccionario();
                }
            else
                MetroFramework.MetroMessageBox.Show(this, "Se produjo un error", "El Diccionario no se cargo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo 'Codigo abreviatura' debe contener 3 caracteres OBLIGATORIAMENTE", "Reescriba los datos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_nuevoTermino_Click(object sender, EventArgs e)
        {
            FocusCargarNuevoDato();
        }

        private void btn_agregarNuevoDato_Click(object sender, EventArgs e)
        {
            try
            {
               int Cabeza = diccionarios.OptenerID_DICCIONARIO_ODFM(abr, des);
                CapaDatos.Diccionario_odfm Nuevo = new CapaDatos.Diccionario_odfm();
                if (txb_Dato_nombreNuevo.Text!=""|txb_Dato_AbrNuevo.Text.Length!=3)
                   {
                    Nuevo.dic_des = txb_Dato_nombreNuevo.Text;
                    Nuevo.dic_cab = Cabeza;
                    Nuevo.dic_abr = txb_Dato_AbrNuevo.Text;
                    Nuevo.dic_cod = diccionarios.OptenerMaximoDicCOd(0, Cabeza);
                    if (diccionarios.CargarNuevoTermino(Nuevo))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "El nuevo termino fue cargado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "El nuevo termino no fue cargado correctamente", "Algo paso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                


            }
            catch (Exception err)
            {
                string er = err.ToString();
                MetroFramework.MetroMessageBox.Show(this, "No se pudo encontrar el identificador relativo del diccionario solicitado", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
    }
}
