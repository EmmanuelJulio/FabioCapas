namespace UiFabio
{
    partial class PadreFormularios
    {
#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components =  null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PadreFormularios));
            this.btnDesAcoplar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlTodo.SuspendLayout();
            this.PanelTrabajo.SuspendLayout();
            this.PanenlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTrabajo
            // 
            this.PanelTrabajo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.PanelTrabajo.Controls.Add(this.panel1);
            this.PanelTrabajo.Dock = System.Windows.Forms.DockStyle.None;
            // 
            // PanenlControl
            // 
            this.PanenlControl.Controls.Add(this.btnDesAcoplar);
            this.PanenlControl.Controls.SetChildIndex(this.btnCerrar, 0);
            this.PanenlControl.Controls.SetChildIndex(this.btnMaximize, 0);
            this.PanenlControl.Controls.SetChildIndex(this.BtnNormal, 0);
            this.PanenlControl.Controls.SetChildIndex(this.BtnMinimize, 0);
            this.PanenlControl.Controls.SetChildIndex(this.btnDesAcoplar, 0);
            // 
            // btnDesAcoplar
            // 
            this.btnDesAcoplar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDesAcoplar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.btnDesAcoplar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(100)))));
            this.btnDesAcoplar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnDesAcoplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesAcoplar.ForeColor = System.Drawing.Color.Silver;
            this.btnDesAcoplar.Location = new System.Drawing.Point(842, 0);
            this.btnDesAcoplar.Name = "btnDesAcoplar";
            this.btnDesAcoplar.Size = new System.Drawing.Size(93, 30);
            this.btnDesAcoplar.TabIndex = 0;
            this.btnDesAcoplar.Text = "Desacoplar";
            this.btnDesAcoplar.UseVisualStyleBackColor = true;
            this.btnDesAcoplar.Click += new System.EventHandler(this.BtnDesAcoplar_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 11);
            this.panel1.TabIndex = 0;
            // 
            // PadreFormularios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PadreFormularios";
            this.Text = "PadreFormularios";
            this.Load += new System.EventHandler(this.PadreFormularios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlTodo.ResumeLayout(false);
            this.PanelTrabajo.ResumeLayout(false);
            this.PanenlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesAcoplar;
        private System.Windows.Forms.Panel panel1;
    }
}