namespace UiFabio
{
    partial class FormPadre
    {

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPadre));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTodo = new System.Windows.Forms.Panel();
            this.PanelTrabajo = new System.Windows.Forms.Panel();
            this.PanenlControl = new System.Windows.Forms.Panel();
            this.BtnMinimize = new System.Windows.Forms.PictureBox();
            this.BtnNormal = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlTodo.SuspendLayout();
            this.PanenlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlTodo
            // 
            this.pnlTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.pnlTodo.Controls.Add(this.PanelTrabajo);
            this.pnlTodo.Controls.Add(this.PanenlControl);
            this.pnlTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTodo.Location = new System.Drawing.Point(0, 0);
            this.pnlTodo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTodo.Name = "pnlTodo";
            this.pnlTodo.Size = new System.Drawing.Size(1067, 588);
            this.pnlTodo.TabIndex = 0;
            // 
            // PanelTrabajo
            // 
            this.PanelTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTrabajo.Location = new System.Drawing.Point(0, 30);
            this.PanelTrabajo.Name = "PanelTrabajo";
            this.PanelTrabajo.Size = new System.Drawing.Size(1067, 558);
            this.PanelTrabajo.TabIndex = 1;
            this.PanelTrabajo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTrabajo_Paint);
            // 
            // PanenlControl
            // 
            this.PanenlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.PanenlControl.Controls.Add(this.BtnMinimize);
            this.PanenlControl.Controls.Add(this.BtnNormal);
            this.PanenlControl.Controls.Add(this.btnMaximize);
            this.PanenlControl.Controls.Add(this.btnCerrar);
            this.PanenlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanenlControl.Location = new System.Drawing.Point(0, 0);
            this.PanenlControl.Name = "PanenlControl";
            this.PanenlControl.Size = new System.Drawing.Size(1067, 30);
            this.PanenlControl.TabIndex = 0;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.Location = new System.Drawing.Point(935, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(33, 30);
            this.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnNormal
            // 
            this.BtnNormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNormal.Image = ((System.Drawing.Image)(resources.GetObject("BtnNormal.Image")));
            this.BtnNormal.Location = new System.Drawing.Point(968, 0);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(33, 30);
            this.BtnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnNormal.TabIndex = 3;
            this.BtnNormal.TabStop = false;
            this.BtnNormal.Visible = false;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1001, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(33, 30);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1034, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanenlControl;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.pnlTodo);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPadre";
            this.Text = "FormPadre";
            this.pnlTodo.ResumeLayout(false);
            this.PanenlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox BtnMinimize;
        public System.Windows.Forms.PictureBox BtnNormal;
        public System.Windows.Forms.PictureBox btnMaximize;
        public System.Windows.Forms.PictureBox btnCerrar;
        public System.Windows.Forms.Panel pnlTodo;
        public System.Windows.Forms.Panel PanelTrabajo;
        public System.Windows.Forms.Panel PanenlControl;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.ComponentModel.IContainer components;
    }
}