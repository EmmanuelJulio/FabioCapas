namespace UiFabio
{
    partial class FormPadre2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPadre2));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Desacoplar = new MetroFramework.Controls.MetroButton();
            this.btn_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.btn_MaximiseWindow = new System.Windows.Forms.PictureBox();
            this.btn_normalWindow = new System.Windows.Forms.PictureBox();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.PanelTodo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaximiseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            this.PanelTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.metroPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Desacoplar);
            this.metroPanel1.Controls.Add(this.btn_MinimizeWindow);
            this.metroPanel1.Controls.Add(this.btn_MaximiseWindow);
            this.metroPanel1.Controls.Add(this.btn_normalWindow);
            this.metroPanel1.Controls.Add(this.btn_CloseForm);
            this.metroPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(800, 21);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Desacoplar
            // 
            this.Desacoplar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Desacoplar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Desacoplar.Location = new System.Drawing.Point(626, 0);
            this.Desacoplar.Name = "Desacoplar";
            this.Desacoplar.Size = new System.Drawing.Size(106, 21);
            this.Desacoplar.TabIndex = 2;
            this.Desacoplar.Text = "Desacoplar";
            this.Desacoplar.UseSelectable = true;
            this.Desacoplar.Click += new System.EventHandler(this.Desacoplar_Click);
            // 
            // btn_MinimizeWindow
            // 
            this.btn_MinimizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_MinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_MinimizeWindow.Image")));
            this.btn_MinimizeWindow.Location = new System.Drawing.Point(732, 0);
            this.btn_MinimizeWindow.Name = "btn_MinimizeWindow";
            this.btn_MinimizeWindow.Size = new System.Drawing.Size(17, 21);
            this.btn_MinimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_MinimizeWindow.TabIndex = 6;
            this.btn_MinimizeWindow.TabStop = false;
            this.btn_MinimizeWindow.Click += new System.EventHandler(this.Btn_MinimizeWindow_Click);
            // 
            // btn_MaximiseWindow
            // 
            this.btn_MaximiseWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_MaximiseWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_MaximiseWindow.Image")));
            this.btn_MaximiseWindow.Location = new System.Drawing.Point(749, 0);
            this.btn_MaximiseWindow.Name = "btn_MaximiseWindow";
            this.btn_MaximiseWindow.Size = new System.Drawing.Size(17, 21);
            this.btn_MaximiseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_MaximiseWindow.TabIndex = 5;
            this.btn_MaximiseWindow.TabStop = false;
            this.btn_MaximiseWindow.Click += new System.EventHandler(this.Btn_MaximiseWindow_Click);
            // 
            // btn_normalWindow
            // 
            this.btn_normalWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_normalWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_normalWindow.Image")));
            this.btn_normalWindow.Location = new System.Drawing.Point(766, 0);
            this.btn_normalWindow.Name = "btn_normalWindow";
            this.btn_normalWindow.Size = new System.Drawing.Size(17, 21);
            this.btn_normalWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_normalWindow.TabIndex = 4;
            this.btn_normalWindow.TabStop = false;
            this.btn_normalWindow.Visible = false;
            this.btn_normalWindow.Click += new System.EventHandler(this.Btn_normalWindow_Click);
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_CloseForm.Image")));
            this.btn_CloseForm.Location = new System.Drawing.Point(783, 0);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(17, 21);
            this.btn_CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_CloseForm.TabIndex = 3;
            this.btn_CloseForm.TabStop = false;
            this.btn_CloseForm.Click += new System.EventHandler(this.Btn_CloseForm_Click);
            // 
            // PanelTodo
            // 
            this.PanelTodo.Controls.Add(this.panel1);
            this.PanelTodo.Controls.Add(this.metroPanel1);
            this.PanelTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTodo.Location = new System.Drawing.Point(0, 0);
            this.PanelTodo.Name = "PanelTodo";
            this.PanelTodo.Size = new System.Drawing.Size(800, 450);
            this.PanelTodo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 429);
            this.panel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // FormPadre2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelTodo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPadre2";
            this.Text = "FormPadre2";
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaximiseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.PanelTodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Controls.MetroButton Desacoplar;
        public System.Windows.Forms.PictureBox btn_MinimizeWindow;
        public System.Windows.Forms.PictureBox btn_MaximiseWindow;
        public System.Windows.Forms.PictureBox btn_normalWindow;
        public System.Windows.Forms.PictureBox btn_CloseForm;
        public System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Panel PanelTodo;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.Timer timer1;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}