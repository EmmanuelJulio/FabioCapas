namespace UiFabio.Configuraciones.Modulos
{
    partial class frm_submenus
    {
#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva

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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_submenus));
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.listBoxModulos1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_agregarmodulo = new MetroFramework.Controls.MetroButton();
            this.txtmodulo = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.lbl_texto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.listBoxModulos2 = new System.Windows.Forms.ListBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.listBoxSubModulos1 = new System.Windows.Forms.ListBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlTodo.SuspendLayout();
            this.PanelTrabajo.SuspendLayout();
            this.PanenlControl.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_modulo
            // 
            this.animator1.SetDecoration(this.txt_modulo, BunifuAnimatorNS.DecorationType.None);
            this.txt_modulo.Size = new System.Drawing.Size(108, 18);
            this.txt_modulo.Text = "Agregar Menus";
            // 
            // BtnMinimize
            // 
            this.animator1.SetDecoration(this.BtnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.BtnMinimize.Location = new System.Drawing.Point(971, 0);
            this.BtnMinimize.Size = new System.Drawing.Size(24, 24);
            // 
            // BtnNormal
            // 
            this.animator1.SetDecoration(this.BtnNormal, BunifuAnimatorNS.DecorationType.None);
            this.BtnNormal.Location = new System.Drawing.Point(995, 0);
            this.BtnNormal.Size = new System.Drawing.Size(24, 24);
            // 
            // btnMaximize
            // 
            this.animator1.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximize.Location = new System.Drawing.Point(1019, 0);
            this.btnMaximize.Size = new System.Drawing.Size(24, 24);
            // 
            // btnCerrar
            // 
            this.animator1.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Location = new System.Drawing.Point(1043, 0);
            this.btnCerrar.Size = new System.Drawing.Size(24, 24);
            // 
            // pnlTodo
            // 
            this.animator1.SetDecoration(this.pnlTodo, BunifuAnimatorNS.DecorationType.None);
            // 
            // PanelTrabajo
            // 
            this.PanelTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelTrabajo.Controls.Add(this.metroTabControl1);
            this.animator1.SetDecoration(this.PanelTrabajo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTrabajo.Location = new System.Drawing.Point(0, 24);
            this.PanelTrabajo.Size = new System.Drawing.Size(1067, 564);
            this.PanelTrabajo.Controls.SetChildIndex(this.metroTabControl1, 0);
            // 
            // PanenlControl
            // 
            this.animator1.SetDecoration(this.PanenlControl, BunifuAnimatorNS.DecorationType.None);
            this.PanenlControl.Size = new System.Drawing.Size(1067, 24);
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.animator1.SetDecoration(this.metroTabControl1, BunifuAnimatorNS.DecorationType.None);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1067, 534);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.listBoxModulos1);
            this.metroTabPage1.Controls.Add(this.panel2);
            this.metroTabPage1.Controls.Add(this.btn_agregarmodulo);
            this.metroTabPage1.Controls.Add(this.txtmodulo);
            this.animator1.SetDecoration(this.metroTabPage1, BunifuAnimatorNS.DecorationType.None);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1059, 492);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Agregar Menu";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // listBoxModulos1
            // 
            this.listBoxModulos1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animator1.SetDecoration(this.listBoxModulos1, BunifuAnimatorNS.DecorationType.None);
            this.listBoxModulos1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxModulos1.FormattingEnabled = true;
            this.listBoxModulos1.ItemHeight = 17;
            this.listBoxModulos1.Location = new System.Drawing.Point(0, 30);
            this.listBoxModulos1.Name = "listBoxModulos1";
            this.listBoxModulos1.Size = new System.Drawing.Size(172, 462);
            this.listBoxModulos1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.lbl_texto);
            this.animator1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 30);
            this.panel2.TabIndex = 4;
            // 
            // btn_agregarmodulo
            // 
            this.animator1.SetDecoration(this.btn_agregarmodulo, BunifuAnimatorNS.DecorationType.None);
            this.btn_agregarmodulo.Location = new System.Drawing.Point(178, 65);
            this.btn_agregarmodulo.Name = "btn_agregarmodulo";
            this.btn_agregarmodulo.Size = new System.Drawing.Size(196, 23);
            this.btn_agregarmodulo.TabIndex = 3;
            this.btn_agregarmodulo.Text = "Agregar";
            this.btn_agregarmodulo.UseSelectable = true;
            this.btn_agregarmodulo.Click += new System.EventHandler(this.Btn_agregarmodulo_Click);
            // 
            // txtmodulo
            // 
            // 
            // 
            // 
            this.txtmodulo.CustomButton.Image = null;
            this.txtmodulo.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtmodulo.CustomButton.Name = "";
            this.txtmodulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtmodulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmodulo.CustomButton.TabIndex = 1;
            this.txtmodulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmodulo.CustomButton.UseSelectable = true;
            this.txtmodulo.CustomButton.Visible = false;
            this.animator1.SetDecoration(this.txtmodulo, BunifuAnimatorNS.DecorationType.None);
            this.txtmodulo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtmodulo.Lines = new string[0];
            this.txtmodulo.Location = new System.Drawing.Point(178, 36);
            this.txtmodulo.MaxLength = 32767;
            this.txtmodulo.Name = "txtmodulo";
            this.txtmodulo.PasswordChar = '\0';
            this.txtmodulo.PromptText = "Nombre del modulo";
            this.txtmodulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmodulo.SelectedText = "";
            this.txtmodulo.SelectionLength = 0;
            this.txtmodulo.SelectionStart = 0;
            this.txtmodulo.ShortcutsEnabled = true;
            this.txtmodulo.Size = new System.Drawing.Size(196, 23);
            this.txtmodulo.TabIndex = 2;
            this.txtmodulo.UseSelectable = true;
            this.txtmodulo.WaterMark = "Nombre del modulo";
            this.txtmodulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmodulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.listBoxSubModulos1);
            this.metroTabPage2.Controls.Add(this.listBoxModulos2);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.metroTextBox1);
            this.metroTabPage2.Controls.Add(this.panel3);
            this.animator1.SetDecoration(this.metroTabPage2, BunifuAnimatorNS.DecorationType.None);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1059, 492);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Agregar Sub Menu";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.animator1.SetDecoration(this.metroTabPage3, BunifuAnimatorNS.DecorationType.None);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1059, 492);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Agregar Form";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.animator1.SetDecoration(this.lbl_texto, BunifuAnimatorNS.DecorationType.None);
            this.lbl_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto.ForeColor = System.Drawing.Color.Silver;
            this.lbl_texto.Location = new System.Drawing.Point(8, 8);
            this.lbl_texto.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(66, 18);
            this.lbl_texto.TabIndex = 6;
            this.lbl_texto.Text = "Modulos";
            this.lbl_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.animator1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 30);
            this.panel3.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(8, 8);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 18);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Modulos";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxModulos2
            // 
            this.listBoxModulos2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animator1.SetDecoration(this.listBoxModulos2, BunifuAnimatorNS.DecorationType.None);
            this.listBoxModulos2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxModulos2.FormattingEnabled = true;
            this.listBoxModulos2.ItemHeight = 17;
            this.listBoxModulos2.Location = new System.Drawing.Point(0, 30);
            this.listBoxModulos2.Name = "listBoxModulos2";
            this.listBoxModulos2.Size = new System.Drawing.Size(172, 462);
            this.listBoxModulos2.TabIndex = 8;
            // 
            // metroButton1
            // 
            this.animator1.SetDecoration(this.metroButton1, BunifuAnimatorNS.DecorationType.None);
            this.metroButton1.Location = new System.Drawing.Point(350, 65);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(196, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Agregar";
            this.metroButton1.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.animator1.SetDecoration(this.metroTextBox1, BunifuAnimatorNS.DecorationType.None);
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(350, 36);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Nombre del modulo";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(196, 23);
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Nombre del modulo";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listBoxSubModulos1
            // 
            this.listBoxSubModulos1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animator1.SetDecoration(this.listBoxSubModulos1, BunifuAnimatorNS.DecorationType.None);
            this.listBoxSubModulos1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxSubModulos1.FormattingEnabled = true;
            this.listBoxSubModulos1.ItemHeight = 17;
            this.listBoxSubModulos1.Location = new System.Drawing.Point(172, 30);
            this.listBoxSubModulos1.Name = "listBoxSubModulos1";
            this.listBoxSubModulos1.Size = new System.Drawing.Size(172, 462);
            this.listBoxSubModulos1.TabIndex = 9;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(169, 8);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(96, 18);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Sub Modulos";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_submenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm_submenus";
            this.Text = "frm_submenus";
            this.Load += new System.EventHandler(this.Frm_submenus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlTodo.ResumeLayout(false);
            this.PanelTrabajo.ResumeLayout(false);
            this.PanenlControl.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.Animator animator1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton btn_agregarmodulo;
        private MetroFramework.Controls.MetroTextBox txtmodulo;
        private System.Windows.Forms.ListBox listBoxModulos1;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_texto;
        private System.Windows.Forms.ListBox listBoxSubModulos1;
        private System.Windows.Forms.ListBox listBoxModulos2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Panel panel3;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}