namespace UiFabio
{
    partial class MformPadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MformPadre));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Desacoplar = new MetroFramework.Controls.MetroButton();
            this.btn_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.btn_MaximiseWindow = new System.Windows.Forms.PictureBox();
            this.btn_normalWindow = new System.Windows.Forms.PictureBox();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaximiseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Desacoplar);
            this.metroPanel1.Controls.Add(this.btn_MinimizeWindow);
            this.metroPanel1.Controls.Add(this.btn_MaximiseWindow);
            this.metroPanel1.Controls.Add(this.btn_normalWindow);
            this.metroPanel1.Controls.Add(this.btn_CloseForm);
            this.metroPanel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(713, 21);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Desacoplar
            // 
            this.Desacoplar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Desacoplar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Desacoplar.Location = new System.Drawing.Point(539, 0);
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
            this.btn_MinimizeWindow.Location = new System.Drawing.Point(645, 0);
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
            this.btn_MaximiseWindow.Location = new System.Drawing.Point(662, 0);
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
            this.btn_normalWindow.Location = new System.Drawing.Point(679, 0);
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
            this.btn_CloseForm.Location = new System.Drawing.Point(696, 0);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(17, 21);
            this.btn_CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_CloseForm.TabIndex = 3;
            this.btn_CloseForm.TabStop = false;
            this.btn_CloseForm.Click += new System.EventHandler(this.Btn_CloseForm_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 51);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(713, 403);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.Tag = "Agregar modulo";
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.metroTextBox1);
            this.metroTabPage1.Controls.Add(this.listBox1);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(792, 390);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Agregar Modulo";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(236, 65);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(164, 29);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Ingresar";
            this.metroButton1.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(236, 35);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Nombre del nuevo modulo";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(164, 23);
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Nombre del nuevo modulo";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 325);
            this.listBox1.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Modulos Actuales";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 390);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Agregar Sub modulo";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroButton2);
            this.metroTabPage3.Controls.Add(this.metroTextBox2);
            this.metroTabPage3.Controls.Add(this.listBox2);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(705, 361);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Agregar Form";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(236, 84);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(164, 29);
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "Ingresar";
            this.metroButton2.UseSelectable = true;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(236, 54);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "Nombre del nuevo modulo";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(164, 23);
            this.metroTextBox2.TabIndex = 9;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "Nombre del nuevo modulo";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(8, 54);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(194, 325);
            this.listBox2.TabIndex = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 32);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Modulos Actuales";
            // 
            // MformPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 474);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MformPadre";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Load += new System.EventHandler(this.MformPadre_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaximiseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Controls.MetroButton Desacoplar;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox btn_MinimizeWindow;
        public System.Windows.Forms.PictureBox btn_MaximiseWindow;
        public System.Windows.Forms.PictureBox btn_normalWindow;
        public System.Windows.Forms.PictureBox btn_CloseForm;
        public MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private System.Windows.Forms.ListBox listBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}