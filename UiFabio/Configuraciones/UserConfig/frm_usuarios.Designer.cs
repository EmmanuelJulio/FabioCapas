namespace UiFabio.Configuraciones.UserConfig
{
    partial class frm_usuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ComboSectores = new MetroFramework.Controls.MetroComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txbContraceña2 = new MetroFramework.Controls.MetroTextBox();
            this.txbApellido = new MetroFramework.Controls.MetroTextBox();
            this.txbUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txbContraceña = new MetroFramework.Controls.MetroTextBox();
            this.txbNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.Btn_EliminarMod = new System.Windows.Forms.Button();
            this.listUsu = new System.Windows.Forms.ListBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.CHK_Modulos = new System.Windows.Forms.CheckedListBox();
            this.listusuarios2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlTodo.SuspendLayout();
            this.PanelTrabajo.SuspendLayout();
            this.PanenlControl.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Location = new System.Drawing.Point(935, 0);
            // 
            // PanelTrabajo
            // 
            this.PanelTrabajo.Controls.Add(this.metroTabControl1);
            this.PanelTrabajo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTrabajo_Paint);
            this.PanelTrabajo.Controls.SetChildIndex(this.metroTabControl1, 0);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1067, 547);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.ComboSectores);
            this.metroTabPage1.Controls.Add(this.btnAgregar);
            this.metroTabPage1.Controls.Add(this.txbContraceña2);
            this.metroTabPage1.Controls.Add(this.txbApellido);
            this.metroTabPage1.Controls.Add(this.txbUsuario);
            this.metroTabPage1.Controls.Add(this.txbContraceña);
            this.metroTabPage1.Controls.Add(this.txbNombre);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1059, 505);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Crear Usuarios";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // ComboSectores
            // 
            this.ComboSectores.FormattingEnabled = true;
            this.ComboSectores.ItemHeight = 23;
            this.ComboSectores.Location = new System.Drawing.Point(373, 120);
            this.ComboSectores.Name = "ComboSectores";
            this.ComboSectores.Size = new System.Drawing.Size(196, 29);
            this.ComboSectores.TabIndex = 5;
            this.ComboSectores.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ComboSectores.UseSelectable = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregar.Location = new System.Drawing.Point(373, 243);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(196, 28);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txbContraceña2
            // 
            // 
            // 
            // 
            this.txbContraceña2.CustomButton.Image = null;
            this.txbContraceña2.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txbContraceña2.CustomButton.Name = "";
            this.txbContraceña2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbContraceña2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbContraceña2.CustomButton.TabIndex = 1;
            this.txbContraceña2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbContraceña2.CustomButton.UseSelectable = true;
            this.txbContraceña2.CustomButton.Visible = false;
            this.txbContraceña2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbContraceña2.Lines = new string[0];
            this.txbContraceña2.Location = new System.Drawing.Point(373, 213);
            this.txbContraceña2.MaxLength = 32767;
            this.txbContraceña2.Name = "txbContraceña2";
            this.txbContraceña2.PasswordChar = '\0';
            this.txbContraceña2.WaterMark = "Repita contraceña";
            this.txbContraceña2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbContraceña2.SelectedText = "";
            this.txbContraceña2.SelectionLength = 0;
            this.txbContraceña2.SelectionStart = 0;
            this.txbContraceña2.ShortcutsEnabled = true;
            this.txbContraceña2.Size = new System.Drawing.Size(196, 23);
            this.txbContraceña2.TabIndex = 8;
            this.txbContraceña2.UseSelectable = true;
            this.txbContraceña2.WaterMark = "Repita contraceña";
            this.txbContraceña2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbContraceña2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbApellido
            // 
            // 
            // 
            // 
            this.txbApellido.CustomButton.Image = null;
            this.txbApellido.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txbApellido.CustomButton.Name = "";
            this.txbApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbApellido.CustomButton.TabIndex = 1;
            this.txbApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbApellido.CustomButton.UseSelectable = true;
            this.txbApellido.CustomButton.Visible = false;
            this.txbApellido.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbApellido.Lines = new string[0];
            this.txbApellido.Location = new System.Drawing.Point(373, 90);
            this.txbApellido.MaxLength = 32767;
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.PasswordChar = '\0';
            this.txbApellido.WaterMark = "Apellido";
            this.txbApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbApellido.SelectedText = "";
            this.txbApellido.SelectionLength = 0;
            this.txbApellido.SelectionStart = 0;
            this.txbApellido.ShortcutsEnabled = true;
            this.txbApellido.Size = new System.Drawing.Size(196, 23);
            this.txbApellido.TabIndex = 4;
            this.txbApellido.UseSelectable = true;
            this.txbApellido.WaterMark = "Apellido";
            this.txbApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbUsuario
            // 
            // 
            // 
            // 
            this.txbUsuario.CustomButton.Image = null;
            this.txbUsuario.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txbUsuario.CustomButton.Name = "";
            this.txbUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbUsuario.CustomButton.TabIndex = 1;
            this.txbUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbUsuario.CustomButton.UseSelectable = true;
            this.txbUsuario.CustomButton.Visible = false;
            this.txbUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbUsuario.Lines = new string[0];
            this.txbUsuario.Location = new System.Drawing.Point(373, 155);
            this.txbUsuario.MaxLength = 32767;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PasswordChar = '\0';
            this.txbUsuario.WaterMark = "Nombre usuario";
            this.txbUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUsuario.SelectedText = "";
            this.txbUsuario.SelectionLength = 0;
            this.txbUsuario.SelectionStart = 0;
            this.txbUsuario.ShortcutsEnabled = true;
            this.txbUsuario.Size = new System.Drawing.Size(196, 23);
            this.txbUsuario.TabIndex = 6;
            this.txbUsuario.UseSelectable = true;
            this.txbUsuario.WaterMark = "Nombre usuario";
            this.txbUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbContraceña
            // 
            // 
            // 
            // 
            this.txbContraceña.CustomButton.Image = null;
            this.txbContraceña.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txbContraceña.CustomButton.Name = "";
            this.txbContraceña.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbContraceña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbContraceña.CustomButton.TabIndex = 1;
            this.txbContraceña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbContraceña.CustomButton.UseSelectable = true;
            this.txbContraceña.CustomButton.Visible = false;
            this.txbContraceña.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbContraceña.Lines = new string[0];
            this.txbContraceña.Location = new System.Drawing.Point(373, 184);
            this.txbContraceña.MaxLength = 32767;
            this.txbContraceña.Name = "txbContraceña";
            this.txbContraceña.PasswordChar = '\0';
            this.txbContraceña.WaterMark = "Contraceña";
            this.txbContraceña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbContraceña.SelectedText = "";
            this.txbContraceña.SelectionLength = 0;
            this.txbContraceña.SelectionStart = 0;
            this.txbContraceña.ShortcutsEnabled = true;
            this.txbContraceña.Size = new System.Drawing.Size(196, 23);
            this.txbContraceña.TabIndex = 7;
            this.txbContraceña.UseSelectable = true;
            this.txbContraceña.WaterMark = "Contraceña";
            this.txbContraceña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbContraceña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbNombre
            // 
            // 
            // 
            // 
            this.txbNombre.CustomButton.Image = null;
            this.txbNombre.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txbNombre.CustomButton.Name = "";
            this.txbNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbNombre.CustomButton.TabIndex = 1;
            this.txbNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbNombre.CustomButton.UseSelectable = true;
            this.txbNombre.CustomButton.Visible = false;
            this.txbNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbNombre.Lines = new string[0];
            this.txbNombre.Location = new System.Drawing.Point(373, 61);
            this.txbNombre.MaxLength = 32767;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PasswordChar = '\0';
            this.txbNombre.WaterMark = "Nombre";
            this.txbNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNombre.SelectedText = "";
            this.txbNombre.SelectionLength = 0;
            this.txbNombre.SelectionStart = 0;
            this.txbNombre.ShortcutsEnabled = true;
            this.txbNombre.Size = new System.Drawing.Size(196, 23);
            this.txbNombre.TabIndex = 3;
            this.txbNombre.UseSelectable = true;
            this.txbNombre.WaterMark = "Nombre";
            this.txbNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.Btn_EliminarMod);
            this.metroTabPage2.Controls.Add(this.listUsu);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1059, 505);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Eliminar usuarios";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // Btn_EliminarMod
            // 
            this.Btn_EliminarMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(70)))));
            this.Btn_EliminarMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(82)))), ((int)(((byte)(70)))));
            this.Btn_EliminarMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_EliminarMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(70)))));
            this.Btn_EliminarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EliminarMod.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_EliminarMod.Location = new System.Drawing.Point(454, 226);
            this.Btn_EliminarMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_EliminarMod.Name = "Btn_EliminarMod";
            this.Btn_EliminarMod.Size = new System.Drawing.Size(196, 28);
            this.Btn_EliminarMod.TabIndex = 14;
            this.Btn_EliminarMod.Text = "Eliminar";
            this.Btn_EliminarMod.UseVisualStyleBackColor = false;
            this.Btn_EliminarMod.Click += new System.EventHandler(this.Btn_EliminarMod_Click);
            // 
            // listUsu
            // 
            this.listUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.listUsu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUsu.Dock = System.Windows.Forms.DockStyle.Left;
            this.listUsu.ForeColor = System.Drawing.Color.DarkGray;
            this.listUsu.FormattingEnabled = true;
            this.listUsu.ItemHeight = 17;
            this.listUsu.Location = new System.Drawing.Point(0, 0);
            this.listUsu.Name = "listUsu";
            this.listUsu.Size = new System.Drawing.Size(172, 505);
            this.listUsu.TabIndex = 6;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.button1);
            this.metroTabPage3.Controls.Add(this.CHK_Modulos);
            this.metroTabPage3.Controls.Add(this.listusuarios2);
            this.metroTabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1059, 505);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Asignar permisos";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            this.metroTabPage3.Click += new System.EventHandler(this.metroTabPage3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(350, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Conceder/Remover permisos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CHK_Modulos
            // 
            this.CHK_Modulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.CHK_Modulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CHK_Modulos.CheckOnClick = true;
            this.CHK_Modulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.CHK_Modulos.ForeColor = System.Drawing.Color.LightGray;
            this.CHK_Modulos.FormattingEnabled = true;
            this.CHK_Modulos.Location = new System.Drawing.Point(172, 0);
            this.CHK_Modulos.Name = "CHK_Modulos";
            this.CHK_Modulos.Size = new System.Drawing.Size(172, 505);
            this.CHK_Modulos.TabIndex = 8;
            // 
            // listusuarios2
            // 
            this.listusuarios2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.listusuarios2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listusuarios2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listusuarios2.ForeColor = System.Drawing.Color.LightGray;
            this.listusuarios2.FormattingEnabled = true;
            this.listusuarios2.ItemHeight = 17;
            this.listusuarios2.Location = new System.Drawing.Point(0, 0);
            this.listusuarios2.Name = "listusuarios2";
            this.listusuarios2.Size = new System.Drawing.Size(172, 505);
            this.listusuarios2.TabIndex = 7;
            this.listusuarios2.SelectedIndexChanged += new System.EventHandler(this.Listusuarios2_SelectedIndexChanged);
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Name = "frm_usuarios";
            this.Load += new System.EventHandler(this.frm_usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlTodo.ResumeLayout(false);
            this.PanelTrabajo.ResumeLayout(false);
            this.PanenlControl.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox txbContraceña2;
        private MetroFramework.Controls.MetroTextBox txbApellido;
        private MetroFramework.Controls.MetroTextBox txbUsuario;
        private MetroFramework.Controls.MetroTextBox txbContraceña;
        private MetroFramework.Controls.MetroTextBox txbNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listUsu;
        private System.Windows.Forms.Button Btn_EliminarMod;
        private System.Windows.Forms.ListBox listusuarios2;
        private MetroFramework.Controls.MetroComboBox ComboSectores;
        private System.Windows.Forms.CheckedListBox CHK_Modulos;
        private System.Windows.Forms.Button button1;
    }
}
