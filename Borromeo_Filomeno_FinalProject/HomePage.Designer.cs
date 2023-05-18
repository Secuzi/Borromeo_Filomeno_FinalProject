namespace Borromeo_Filomeno_FinalProject
{
    partial class HomePage
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
            this.panel_form = new System.Windows.Forms.Panel();
            this.panel_side = new System.Windows.Forms.Panel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.timerMainHomePage = new System.Windows.Forms.Timer(this.components);
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btn_UberVoid = new System.Windows.Forms.Button();
            this.btn_Math = new System.Windows.Forms.Button();
            this.panel_side.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_form
            // 
            this.panel_form.BackColor = System.Drawing.Color.Silver;
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Location = new System.Drawing.Point(232, 33);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(809, 647);
            this.panel_form.TabIndex = 5;
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.panel_side.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_side.Controls.Add(this.pb_logo);
            this.panel_side.Controls.Add(this.btn_UberVoid);
            this.panel_side.Controls.Add(this.btn_Math);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 33);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(232, 647);
            this.panel_side.TabIndex = 3;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Black;
            this.panel_top.Controls.Add(this.btn_Exit);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1041, 33);
            this.panel_top.TabIndex = 4;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(997, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(44, 33);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // timerMainHomePage
            // 
            this.timerMainHomePage.Enabled = true;
            this.timerMainHomePage.Interval = 20;
            this.timerMainHomePage.Tick += new System.EventHandler(this.timerMainHomePage_Tick);
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_logo.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.Compound_Games;
            this.pb_logo.Location = new System.Drawing.Point(-15, 26);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(263, 261);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 3;
            this.pb_logo.TabStop = false;
            this.pb_logo.Click += new System.EventHandler(this.pb_logo_Click);
            // 
            // btn_UberVoid
            // 
            this.btn_UberVoid.BackColor = System.Drawing.Color.Transparent;
            this.btn_UberVoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UberVoid.FlatAppearance.BorderSize = 0;
            this.btn_UberVoid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.btn_UberVoid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(94)))), ((int)(((byte)(139)))));
            this.btn_UberVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UberVoid.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UberVoid.ForeColor = System.Drawing.Color.Khaki;
            this.btn_UberVoid.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.space_invaders_24;
            this.btn_UberVoid.Location = new System.Drawing.Point(0, 370);
            this.btn_UberVoid.Name = "btn_UberVoid";
            this.btn_UberVoid.Size = new System.Drawing.Size(231, 34);
            this.btn_UberVoid.TabIndex = 2;
            this.btn_UberVoid.Text = "    Uber Void";
            this.btn_UberVoid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_UberVoid.UseVisualStyleBackColor = false;
            this.btn_UberVoid.Click += new System.EventHandler(this.btn_UberVoid_Click);
            // 
            // btn_Math
            // 
            this.btn_Math.BackColor = System.Drawing.Color.Transparent;
            this.btn_Math.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Math.FlatAppearance.BorderSize = 0;
            this.btn_Math.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.btn_Math.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(94)))), ((int)(((byte)(139)))));
            this.btn_Math.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Math.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Math.ForeColor = System.Drawing.Color.Khaki;
            this.btn_Math.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.arithmetic_24px;
            this.btn_Math.Location = new System.Drawing.Point(1, 296);
            this.btn_Math.Name = "btn_Math";
            this.btn_Math.Size = new System.Drawing.Size(231, 36);
            this.btn_Math.TabIndex = 2;
            this.btn_Math.Text = "    Math Zilla";
            this.btn_Math.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Math.UseVisualStyleBackColor = false;
            this.btn_Math.Click += new System.EventHandler(this.btn_Math_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1041, 680);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_side);
            this.Controls.Add(this.panel_top);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel_side.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_UberVoid;
        private System.Windows.Forms.Button btn_Math;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Timer timerMainHomePage;
    }
}