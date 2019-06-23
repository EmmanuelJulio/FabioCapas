namespace UiFabio
{
    partial class MensajePers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajePers));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.listicon = new System.Windows.Forms.ImageList(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Timer(this.components);
            this.show = new System.Windows.Forms.Timer(this.components);
            this.Botones = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // listicon
            // 
            this.listicon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listicon.ImageStream")));
            this.listicon.TransparentColor = System.Drawing.Color.Transparent;
            this.listicon.Images.SetKeyName(0, "icons8_Checkmark_96px.png");
            this.listicon.Images.SetKeyName(1, "icons8_Delete_96px_2.png");
            this.listicon.Images.SetKeyName(2, "icons8_Logout_Rounded_Up_96px_1.png");
            this.listicon.Images.SetKeyName(3, "icons8_Male_User_96px.png");
            this.listicon.Images.SetKeyName(4, "icons8_Thumbs_Up_96px.png");
            this.listicon.Images.SetKeyName(5, "icons8_Info_96px.png");
            this.listicon.Images.SetKeyName(6, "icons8_Error_96px.png");
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(121, 94);
            this.icon.Margin = new System.Windows.Forms.Padding(4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(66, 52);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.Icon_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(117, 150);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(75, 21);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Mensaje";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(51, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // hide
            // 
            this.hide.Interval = 30;
            this.hide.Tick += new System.EventHandler(this.Hide_Tick);
            // 
            // show
            // 
            this.show.Tick += new System.EventHandler(this.Show_Tick);
            // 
            // Botones
            // 
            this.Botones.Controls.Add(this.button1);
            this.Botones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Botones.Location = new System.Drawing.Point(0, 185);
            this.Botones.Name = "Botones";
            this.Botones.Size = new System.Drawing.Size(337, 60);
            this.Botones.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // MensajePers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(337, 245);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Botones);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.icon);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MensajePers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje";
            this.Load += new System.EventHandler(this.MensajePers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ImageList listicon;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Timer hide;
        public System.Windows.Forms.Timer show;
        private System.Windows.Forms.Panel Botones;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}