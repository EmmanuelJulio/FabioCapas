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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_submenus));
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.txtmodulo = new MetroFramework.Controls.MetroTextBox();
            this.btn_agregarmodulo = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlTodo.SuspendLayout();
            this.PanelTrabajo.SuspendLayout();
            this.PanenlControl.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
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
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation2;
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
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1067, 534);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
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
            // metroTabPage2
            // 
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
            this.txtmodulo.Location = new System.Drawing.Point(30, 79);
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
            // btn_agregarmodulo
            // 
            this.animator1.SetDecoration(this.btn_agregarmodulo, BunifuAnimatorNS.DecorationType.None);
            this.btn_agregarmodulo.Location = new System.Drawing.Point(30, 121);
            this.btn_agregarmodulo.Name = "btn_agregarmodulo";
            this.btn_agregarmodulo.Size = new System.Drawing.Size(151, 23);
            this.btn_agregarmodulo.TabIndex = 3;
            this.btn_agregarmodulo.Text = "Agregar";
            this.btn_agregarmodulo.UseSelectable = true;
            this.btn_agregarmodulo.Click += new System.EventHandler(this.Btn_agregarmodulo_Click);
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
    }
}