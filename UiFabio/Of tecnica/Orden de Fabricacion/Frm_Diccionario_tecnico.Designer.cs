namespace UiFabio.Of_tecnica.Orden_de_Fabricacion
{
    partial class Frm_Diccionario_tecnico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Diccionario_tecnico));
            this.Dia = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_agregarMod = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gb_nuevoDato = new System.Windows.Forms.GroupBox();
            this.lbl_tipodato = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_guardarDatoNuevo = new System.Windows.Forms.Button();
            this.txb_Dato_AbrevNuevo = new MetroFramework.Controls.MetroTextBox();
            this.txb_Dato_nombreNuevo = new MetroFramework.Controls.MetroTextBox();
            this.listDatos = new System.Windows.Forms.ListBox();
            this.listTerminos = new System.Windows.Forms.ListBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_nuevoTermino = new System.Windows.Forms.Button();
            this.bulonera2DataSet = new UiFabio.bulonera2DataSet();
            this.diccionarioodfmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diccionario_odfmTableAdapter = new UiFabio.bulonera2DataSetTableAdapters.Diccionario_odfmTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlTodo.SuspendLayout();
            this.PanelTrabajo.SuspendLayout();
            this.PanenlControl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gb_nuevoDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bulonera2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diccionarioodfmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Location = new System.Drawing.Point(935, 0);
            // 
            // PanelTrabajo
            // 
            this.PanelTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelTrabajo.Controls.Add(this.bunifuCustomLabel1);
            this.PanelTrabajo.Controls.Add(this.listTerminos);
            this.PanelTrabajo.Controls.Add(this.listDatos);
            this.PanelTrabajo.Controls.Add(this.gb_nuevoDato);
            this.PanelTrabajo.Controls.Add(this.panel2);
            this.PanelTrabajo.Controls.Add(this.Dia);
            this.PanelTrabajo.Controls.SetChildIndex(this.Dia, 0);
            this.PanelTrabajo.Controls.SetChildIndex(this.panel2, 0);
            this.PanelTrabajo.Controls.SetChildIndex(this.gb_nuevoDato, 0);
            this.PanelTrabajo.Controls.SetChildIndex(this.listDatos, 0);
            this.PanelTrabajo.Controls.SetChildIndex(this.listTerminos, 0);
            this.PanelTrabajo.Controls.SetChildIndex(this.bunifuCustomLabel1, 0);
            // 
            // PanenlControl
            // 
            this.PanenlControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            // 
            // Dia
            // 
            this.Dia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Dia.AutoSize = true;
            this.Dia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dia.ForeColor = System.Drawing.Color.Silver;
            this.Dia.Location = new System.Drawing.Point(94, 99);
            this.Dia.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(179, 20);
            this.Dia.TabIndex = 9;
            this.Dia.Text = "Seleccione Diccionario";
            this.Dia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_nuevoTermino);
            this.panel2.Controls.Add(this.Btn_agregarMod);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.panel2.Location = new System.Drawing.Point(842, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 547);
            this.panel2.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.LightGray;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 218);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 39);
            this.button4.TabIndex = 17;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Image = global::UiFabio.Properties.Resources.icons8_Delete_File_32px_2;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 179);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 39);
            this.button3.TabIndex = 16;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Image = global::UiFabio.Properties.Resources.icons8_Available_Updates_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Image = global::UiFabio.Properties.Resources.icons8_Save_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Btn_agregarMod
            // 
            this.Btn_agregarMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.Btn_agregarMod.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_agregarMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.Btn_agregarMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_agregarMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.Btn_agregarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregarMod.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_agregarMod.Image = global::UiFabio.Properties.Resources.icons8_New_32px_1;
            this.Btn_agregarMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_agregarMod.Location = new System.Drawing.Point(0, 13);
            this.Btn_agregarMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_agregarMod.Name = "Btn_agregarMod";
            this.Btn_agregarMod.Size = new System.Drawing.Size(225, 49);
            this.Btn_agregarMod.TabIndex = 13;
            this.Btn_agregarMod.Text = "Nuevo Diccionario";
            this.Btn_agregarMod.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 13);
            this.panel3.TabIndex = 0;
            // 
            // gb_nuevoDato
            // 
            this.gb_nuevoDato.Controls.Add(this.lbl_tipodato);
            this.gb_nuevoDato.Controls.Add(this.bunifuCustomLabel2);
            this.gb_nuevoDato.Controls.Add(this.btn_guardarDatoNuevo);
            this.gb_nuevoDato.Controls.Add(this.txb_Dato_AbrevNuevo);
            this.gb_nuevoDato.Controls.Add(this.txb_Dato_nombreNuevo);
            this.gb_nuevoDato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_nuevoDato.ForeColor = System.Drawing.Color.Silver;
            this.gb_nuevoDato.Location = new System.Drawing.Point(7, 6);
            this.gb_nuevoDato.Margin = new System.Windows.Forms.Padding(0);
            this.gb_nuevoDato.Name = "gb_nuevoDato";
            this.gb_nuevoDato.Size = new System.Drawing.Size(832, 78);
            this.gb_nuevoDato.TabIndex = 11;
            this.gb_nuevoDato.TabStop = false;
            this.gb_nuevoDato.Text = "Nuevo dato";
            // 
            // lbl_tipodato
            // 
            this.lbl_tipodato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tipodato.AutoSize = true;
            this.lbl_tipodato.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipodato.ForeColor = System.Drawing.Color.Silver;
            this.lbl_tipodato.Location = new System.Drawing.Point(287, 17);
            this.lbl_tipodato.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbl_tipodato.Name = "lbl_tipodato";
            this.lbl_tipodato.Size = new System.Drawing.Size(81, 17);
            this.lbl_tipodato.TabIndex = 16;
            this.lbl_tipodato.Text = "Nuevo Dato";
            this.lbl_tipodato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(6, 17);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(129, 17);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Codigo/Abreviatura";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_guardarDatoNuevo
            // 
            this.btn_guardarDatoNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.btn_guardarDatoNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_guardarDatoNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_guardarDatoNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_guardarDatoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarDatoNuevo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_guardarDatoNuevo.Image = global::UiFabio.Properties.Resources.icons8_Save_32px;
            this.btn_guardarDatoNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardarDatoNuevo.Location = new System.Drawing.Point(601, 32);
            this.btn_guardarDatoNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_guardarDatoNuevo.Name = "btn_guardarDatoNuevo";
            this.btn_guardarDatoNuevo.Size = new System.Drawing.Size(225, 39);
            this.btn_guardarDatoNuevo.TabIndex = 14;
            this.btn_guardarDatoNuevo.Text = "Agregar";
            this.btn_guardarDatoNuevo.UseVisualStyleBackColor = false;
            this.btn_guardarDatoNuevo.Visible = false;
            // 
            // txb_Dato_AbrevNuevo
            // 
            // 
            // 
            // 
            this.txb_Dato_AbrevNuevo.CustomButton.Image = null;
            this.txb_Dato_AbrevNuevo.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txb_Dato_AbrevNuevo.CustomButton.Name = "";
            this.txb_Dato_AbrevNuevo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_Dato_AbrevNuevo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_Dato_AbrevNuevo.CustomButton.TabIndex = 1;
            this.txb_Dato_AbrevNuevo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_Dato_AbrevNuevo.CustomButton.UseSelectable = true;
            this.txb_Dato_AbrevNuevo.CustomButton.Visible = false;
            this.txb_Dato_AbrevNuevo.Enabled = false;
            this.txb_Dato_AbrevNuevo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txb_Dato_AbrevNuevo.Lines = new string[0];
            this.txb_Dato_AbrevNuevo.Location = new System.Drawing.Point(290, 41);
            this.txb_Dato_AbrevNuevo.MaxLength = 32767;
            this.txb_Dato_AbrevNuevo.Name = "txb_Dato_AbrevNuevo";
            this.txb_Dato_AbrevNuevo.PasswordChar = '\0';
            this.txb_Dato_AbrevNuevo.PromptText = "Nombre del modulo";
            this.txb_Dato_AbrevNuevo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_Dato_AbrevNuevo.SelectedText = "";
            this.txb_Dato_AbrevNuevo.SelectionLength = 0;
            this.txb_Dato_AbrevNuevo.SelectionStart = 0;
            this.txb_Dato_AbrevNuevo.ShortcutsEnabled = true;
            this.txb_Dato_AbrevNuevo.Size = new System.Drawing.Size(196, 23);
            this.txb_Dato_AbrevNuevo.TabIndex = 4;
            this.txb_Dato_AbrevNuevo.UseSelectable = true;
            this.txb_Dato_AbrevNuevo.WaterMark = "Nombre del modulo";
            this.txb_Dato_AbrevNuevo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_Dato_AbrevNuevo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_Dato_nombreNuevo
            // 
            // 
            // 
            // 
            this.txb_Dato_nombreNuevo.CustomButton.Image = null;
            this.txb_Dato_nombreNuevo.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txb_Dato_nombreNuevo.CustomButton.Name = "";
            this.txb_Dato_nombreNuevo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_Dato_nombreNuevo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_Dato_nombreNuevo.CustomButton.TabIndex = 1;
            this.txb_Dato_nombreNuevo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_Dato_nombreNuevo.CustomButton.UseSelectable = true;
            this.txb_Dato_nombreNuevo.CustomButton.Visible = false;
            this.txb_Dato_nombreNuevo.Enabled = false;
            this.txb_Dato_nombreNuevo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txb_Dato_nombreNuevo.Lines = new string[0];
            this.txb_Dato_nombreNuevo.Location = new System.Drawing.Point(10, 41);
            this.txb_Dato_nombreNuevo.MaxLength = 3;
            this.txb_Dato_nombreNuevo.Name = "txb_Dato_nombreNuevo";
            this.txb_Dato_nombreNuevo.PasswordChar = '\0';
            this.txb_Dato_nombreNuevo.PromptText = "Nombre del modulo";
            this.txb_Dato_nombreNuevo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_Dato_nombreNuevo.SelectedText = "";
            this.txb_Dato_nombreNuevo.SelectionLength = 0;
            this.txb_Dato_nombreNuevo.SelectionStart = 0;
            this.txb_Dato_nombreNuevo.ShortcutsEnabled = true;
            this.txb_Dato_nombreNuevo.Size = new System.Drawing.Size(196, 23);
            this.txb_Dato_nombreNuevo.TabIndex = 3;
            this.txb_Dato_nombreNuevo.UseSelectable = true;
            this.txb_Dato_nombreNuevo.WaterMark = "Nombre del modulo";
            this.txb_Dato_nombreNuevo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_Dato_nombreNuevo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listDatos
            // 
            this.listDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.listDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listDatos.ForeColor = System.Drawing.Color.DarkGray;
            this.listDatos.FormattingEnabled = true;
            this.listDatos.ItemHeight = 17;
            this.listDatos.Location = new System.Drawing.Point(98, 131);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(231, 410);
            this.listDatos.TabIndex = 12;
            this.listDatos.SelectedIndexChanged += new System.EventHandler(this.listDatos_SelectedIndexChanged);
            // 
            // listTerminos
            // 
            this.listTerminos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.listTerminos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listTerminos.ForeColor = System.Drawing.Color.DarkGray;
            this.listTerminos.FormattingEnabled = true;
            this.listTerminos.ItemHeight = 17;
            this.listTerminos.Location = new System.Drawing.Point(438, 131);
            this.listTerminos.Name = "listTerminos";
            this.listTerminos.Size = new System.Drawing.Size(273, 410);
            this.listTerminos.TabIndex = 13;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(434, 99);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(179, 20);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Seleccione Diccionario";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // btn_nuevoTermino
            // 
            this.btn_nuevoTermino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.btn_nuevoTermino.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nuevoTermino.Enabled = false;
            this.btn_nuevoTermino.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_nuevoTermino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_nuevoTermino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_nuevoTermino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoTermino.ForeColor = System.Drawing.Color.LightGray;
            this.btn_nuevoTermino.Image = global::UiFabio.Properties.Resources.icons8_New_32px_1;
            this.btn_nuevoTermino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevoTermino.Location = new System.Drawing.Point(0, 62);
            this.btn_nuevoTermino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_nuevoTermino.Name = "btn_nuevoTermino";
            this.btn_nuevoTermino.Size = new System.Drawing.Size(225, 39);
            this.btn_nuevoTermino.TabIndex = 18;
            this.btn_nuevoTermino.Text = "Nuevo Termino";
            this.btn_nuevoTermino.UseVisualStyleBackColor = false;
            // 
            // bulonera2DataSet
            // 
            this.bulonera2DataSet.DataSetName = "bulonera2DataSet";
            this.bulonera2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diccionarioodfmBindingSource
            // 
            this.diccionarioodfmBindingSource.DataMember = "Diccionario_odfm";
            this.diccionarioodfmBindingSource.DataSource = this.bulonera2DataSet;
            // 
            // diccionario_odfmTableAdapter
            // 
            this.diccionario_odfmTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Diccionario_tecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Frm_Diccionario_tecnico";
            this.Text = "Frm_Diccionario_tecnico";
            this.Load += new System.EventHandler(this.Frm_Diccionario_tecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlTodo.ResumeLayout(false);
            this.PanelTrabajo.ResumeLayout(false);
            this.PanelTrabajo.PerformLayout();
            this.PanenlControl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gb_nuevoDato.ResumeLayout(false);
            this.gb_nuevoDato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bulonera2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diccionarioodfmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuCustomLabel Dia;
        private System.Windows.Forms.Button Btn_agregarMod;
        private System.Windows.Forms.GroupBox gb_nuevoDato;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_guardarDatoNuevo;
        private MetroFramework.Controls.MetroTextBox txb_Dato_AbrevNuevo;
        private MetroFramework.Controls.MetroTextBox txb_Dato_nombreNuevo;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ListBox listTerminos;
        private System.Windows.Forms.ListBox listDatos;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_tipodato;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_nuevoTermino;
        private bulonera2DataSet bulonera2DataSet;
        private System.Windows.Forms.BindingSource diccionarioodfmBindingSource;
        private bulonera2DataSetTableAdapters.Diccionario_odfmTableAdapter diccionario_odfmTableAdapter;
    }
}