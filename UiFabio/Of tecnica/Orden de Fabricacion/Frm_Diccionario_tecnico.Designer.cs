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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Diccionario_tecnico));
            this.Superior = new System.Windows.Forms.Panel();
            this.Dia = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.list_Cabeceras = new System.Windows.Forms.ListBox();
            this.Btn_agregarMod = new System.Windows.Forms.Button();
            this.List_terminos = new System.Windows.Forms.ListBox();
            this.Pnl_CrearNuevoHijo = new System.Windows.Forms.Panel();
            this.Pnl_CrearNuevaCabecera = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlTodo.SuspendLayout();
            this.PanelTrabajo.SuspendLayout();
            this.PanenlControl.SuspendLayout();
            this.Superior.SuspendLayout();
            this.Pnl_CrearNuevoHijo.SuspendLayout();
            this.Pnl_CrearNuevaCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.PanelTrabajo.Controls.Add(this.pictureBox1);
            this.PanelTrabajo.Controls.Add(this.List_terminos);
            this.PanelTrabajo.Controls.Add(this.list_Cabeceras);
            this.PanelTrabajo.Controls.Add(this.Pnl_CrearNuevoHijo);
            this.PanelTrabajo.Controls.Add(this.Superior);
            this.PanelTrabajo.Controls.SetChildIndex(this.Superior, 0);
            this.PanelTrabajo.Controls.SetChildIndex(this.Pnl_CrearNuevoHijo, 0);
            this.PanelTrabajo.Controls.SetChildIndex(this.list_Cabeceras, 0);
            this.PanelTrabajo.Controls.SetChildIndex(this.List_terminos, 0);
            this.PanelTrabajo.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // Superior
            // 
            this.Superior.Controls.Add(this.Dia);
            this.Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Superior.Location = new System.Drawing.Point(0, 0);
            this.Superior.Name = "Superior";
            this.Superior.Size = new System.Drawing.Size(1067, 33);
            this.Superior.TabIndex = 1;
            // 
            // Dia
            // 
            this.Dia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Dia.AutoSize = true;
            this.Dia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dia.ForeColor = System.Drawing.Color.Silver;
            this.Dia.Location = new System.Drawing.Point(75, 4);
            this.Dia.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(206, 20);
            this.Dia.TabIndex = 9;
            this.Dia.Text = "Lista de Terminos generales";
            this.Dia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_Cabeceras
            // 
            this.list_Cabeceras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.list_Cabeceras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_Cabeceras.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_Cabeceras.ForeColor = System.Drawing.Color.DarkGray;
            this.list_Cabeceras.FormattingEnabled = true;
            this.list_Cabeceras.ItemHeight = 17;
            this.list_Cabeceras.Location = new System.Drawing.Point(0, 33);
            this.list_Cabeceras.Name = "list_Cabeceras";
            this.list_Cabeceras.Size = new System.Drawing.Size(192, 514);
            this.list_Cabeceras.TabIndex = 6;
            this.list_Cabeceras.SelectedIndexChanged += new System.EventHandler(this.listBoxModulos1_SelectedIndexChanged);
            // 
            // Btn_agregarMod
            // 
            this.Btn_agregarMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.Btn_agregarMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.Btn_agregarMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_agregarMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.Btn_agregarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregarMod.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_agregarMod.Location = new System.Drawing.Point(181, 301);
            this.Btn_agregarMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_agregarMod.Name = "Btn_agregarMod";
            this.Btn_agregarMod.Size = new System.Drawing.Size(196, 54);
            this.Btn_agregarMod.TabIndex = 13;
            this.Btn_agregarMod.Text = "Agregar Nuevo termino padre";
            this.Btn_agregarMod.UseVisualStyleBackColor = false;
            this.Btn_agregarMod.Visible = false;
            // 
            // List_terminos
            // 
            this.List_terminos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.List_terminos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List_terminos.Dock = System.Windows.Forms.DockStyle.Right;
            this.List_terminos.ForeColor = System.Drawing.Color.DarkGray;
            this.List_terminos.FormattingEnabled = true;
            this.List_terminos.ItemHeight = 17;
            this.List_terminos.Location = new System.Drawing.Point(242, 33);
            this.List_terminos.Name = "List_terminos";
            this.List_terminos.Size = new System.Drawing.Size(192, 514);
            this.List_terminos.TabIndex = 14;
            // 
            // Pnl_CrearNuevoHijo
            // 
            this.Pnl_CrearNuevoHijo.Controls.Add(this.Pnl_CrearNuevaCabecera);
            this.Pnl_CrearNuevoHijo.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_CrearNuevoHijo.Location = new System.Drawing.Point(434, 33);
            this.Pnl_CrearNuevoHijo.Name = "Pnl_CrearNuevoHijo";
            this.Pnl_CrearNuevoHijo.Size = new System.Drawing.Size(633, 514);
            this.Pnl_CrearNuevoHijo.TabIndex = 10;
            // 
            // Pnl_CrearNuevaCabecera
            // 
            this.Pnl_CrearNuevaCabecera.Controls.Add(this.Btn_agregarMod);
            this.Pnl_CrearNuevaCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_CrearNuevaCabecera.Location = new System.Drawing.Point(0, 0);
            this.Pnl_CrearNuevaCabecera.Name = "Pnl_CrearNuevaCabecera";
            this.Pnl_CrearNuevaCabecera.Size = new System.Drawing.Size(633, 514);
            this.Pnl_CrearNuevaCabecera.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
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
            this.PanenlControl.ResumeLayout(false);
            this.Superior.ResumeLayout(false);
            this.Superior.PerformLayout();
            this.Pnl_CrearNuevoHijo.ResumeLayout(false);
            this.Pnl_CrearNuevaCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Superior;
        private System.Windows.Forms.ListBox list_Cabeceras;
        public Bunifu.Framework.UI.BunifuCustomLabel Dia;
        private System.Windows.Forms.Button Btn_agregarMod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox List_terminos;
        private System.Windows.Forms.Panel Pnl_CrearNuevoHijo;
        private System.Windows.Forms.Panel Pnl_CrearNuevaCabecera;
    }
}