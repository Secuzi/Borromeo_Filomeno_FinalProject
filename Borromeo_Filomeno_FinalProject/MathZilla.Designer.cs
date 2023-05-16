namespace Borromeo_Filomeno_FinalProject
{
    partial class MathZilla
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_p2_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_p1_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Clue = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_ClueDisplay = new System.Windows.Forms.Label();
            this.lbl_p2_score = new System.Windows.Forms.Label();
            this.lbl_p1_score = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_p2_name = new System.Windows.Forms.Label();
            this.lbl_p1_Name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_Operators = new System.Windows.Forms.Panel();
            this.pbDivide = new System.Windows.Forms.PictureBox();
            this.pbMultiply = new System.Windows.Forms.PictureBox();
            this.pbSubtract = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lbl_Problem = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_Operators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDivide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_p2_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_p1_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 647);
            this.panel1.TabIndex = 1;
            // 
            // txt_p2_name
            // 
            this.txt_p2_name.Location = new System.Drawing.Point(47, 367);
            this.txt_p2_name.Name = "txt_p2_name";
            this.txt_p2_name.Size = new System.Drawing.Size(129, 20);
            this.txt_p2_name.TabIndex = 2;
            this.txt_p2_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_p2_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_p2_name_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Player 2";
            // 
            // txt_p1_name
            // 
            this.txt_p1_name.Location = new System.Drawing.Point(47, 304);
            this.txt_p1_name.Name = "txt_p1_name";
            this.txt_p1_name.Size = new System.Drawing.Size(129, 20);
            this.txt_p1_name.TabIndex = 1;
            this.txt_p1_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_p1_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_p1_name_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Zilla";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Borromeo_Filomeno_FinalProject.Properties.Resources.blue_gradient_bg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_Clue);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbl_ClueDisplay);
            this.panel2.Controls.Add(this.lbl_p2_score);
            this.panel2.Controls.Add(this.lbl_p1_score);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_p2_name);
            this.panel2.Controls.Add(this.lbl_p1_Name);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel_Operators);
            this.panel2.Controls.Add(this.lbl_Problem);
            this.panel2.Controls.Add(this.txt_Answer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(219, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 647);
            this.panel2.TabIndex = 2;
            // 
            // btn_Clue
            // 
            this.btn_Clue.BackColor = System.Drawing.Color.White;
            this.btn_Clue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clue.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Clue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clue.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clue.Location = new System.Drawing.Point(247, 477);
            this.btn_Clue.Name = "btn_Clue";
            this.btn_Clue.Size = new System.Drawing.Size(111, 40);
            this.btn_Clue.TabIndex = 4;
            this.btn_Clue.Text = "Clue";
            this.btn_Clue.UseVisualStyleBackColor = false;
            this.btn_Clue.Click += new System.EventHandler(this.btn_Clue_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(326, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Score :";
            // 
            // lbl_ClueDisplay
            // 
            this.lbl_ClueDisplay.AutoSize = true;
            this.lbl_ClueDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ClueDisplay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClueDisplay.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_ClueDisplay.Location = new System.Drawing.Point(249, 520);
            this.lbl_ClueDisplay.Name = "lbl_ClueDisplay";
            this.lbl_ClueDisplay.Size = new System.Drawing.Size(109, 23);
            this.lbl_ClueDisplay.TabIndex = 11;
            this.lbl_ClueDisplay.Text = "Clue asdasd";
            this.lbl_ClueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ClueDisplay.Visible = false;
            // 
            // lbl_p2_score
            // 
            this.lbl_p2_score.AutoSize = true;
            this.lbl_p2_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p2_score.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2_score.ForeColor = System.Drawing.Color.White;
            this.lbl_p2_score.Location = new System.Drawing.Point(409, 165);
            this.lbl_p2_score.Name = "lbl_p2_score";
            this.lbl_p2_score.Size = new System.Drawing.Size(48, 55);
            this.lbl_p2_score.TabIndex = 11;
            this.lbl_p2_score.Text = "0";
            // 
            // lbl_p1_score
            // 
            this.lbl_p1_score.AutoSize = true;
            this.lbl_p1_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p1_score.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1_score.ForeColor = System.Drawing.Color.White;
            this.lbl_p1_score.Location = new System.Drawing.Point(235, 166);
            this.lbl_p1_score.Name = "lbl_p1_score";
            this.lbl_p1_score.Size = new System.Drawing.Size(60, 55);
            this.lbl_p1_score.TabIndex = 11;
            this.lbl_p1_score.Text = "0 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(145, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Score :";
            // 
            // lbl_p2_name
            // 
            this.lbl_p2_name.AutoSize = true;
            this.lbl_p2_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p2_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2_name.ForeColor = System.Drawing.Color.White;
            this.lbl_p2_name.Location = new System.Drawing.Point(328, 166);
            this.lbl_p2_name.Name = "lbl_p2_name";
            this.lbl_p2_name.Size = new System.Drawing.Size(39, 26);
            this.lbl_p2_name.TabIndex = 11;
            this.lbl_p2_name.Text = "P2";
            // 
            // lbl_p1_Name
            // 
            this.lbl_p1_Name.AutoSize = true;
            this.lbl_p1_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p1_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_p1_Name.Location = new System.Drawing.Point(145, 165);
            this.lbl_p1_Name.Name = "lbl_p1_Name";
            this.lbl_p1_Name.Size = new System.Drawing.Size(39, 26);
            this.lbl_p1_Name.TabIndex = 11;
            this.lbl_p1_Name.Text = "P1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(186, 430);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 2);
            this.panel3.TabIndex = 10;
            // 
            // panel_Operators
            // 
            this.panel_Operators.BackColor = System.Drawing.Color.Transparent;
            this.panel_Operators.Controls.Add(this.pbDivide);
            this.panel_Operators.Controls.Add(this.pbMultiply);
            this.panel_Operators.Controls.Add(this.pbSubtract);
            this.panel_Operators.Controls.Add(this.pbAdd);
            this.panel_Operators.Location = new System.Drawing.Point(0, 35);
            this.panel_Operators.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel_Operators.Name = "panel_Operators";
            this.panel_Operators.Size = new System.Drawing.Size(628, 108);
            this.panel_Operators.TabIndex = 9;
            // 
            // pbDivide
            // 
            this.pbDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDivide.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.divide_64_white;
            this.pbDivide.Location = new System.Drawing.Point(475, 22);
            this.pbDivide.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbDivide.Name = "pbDivide";
            this.pbDivide.Size = new System.Drawing.Size(90, 75);
            this.pbDivide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDivide.TabIndex = 0;
            this.pbDivide.TabStop = false;
            this.pbDivide.Click += new System.EventHandler(this.picbox_Divide_Click);
            // 
            // pbMultiply
            // 
            this.pbMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMultiply.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.multiply_white_64;
            this.pbMultiply.Location = new System.Drawing.Point(332, 22);
            this.pbMultiply.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbMultiply.Name = "pbMultiply";
            this.pbMultiply.Size = new System.Drawing.Size(90, 75);
            this.pbMultiply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMultiply.TabIndex = 0;
            this.pbMultiply.TabStop = false;
            this.pbMultiply.Click += new System.EventHandler(this.picbox_Multiply_Click);
            // 
            // pbSubtract
            // 
            this.pbSubtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSubtract.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.subtrac_64_white;
            this.pbSubtract.Location = new System.Drawing.Point(188, 22);
            this.pbSubtract.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbSubtract.Name = "pbSubtract";
            this.pbSubtract.Size = new System.Drawing.Size(90, 75);
            this.pbSubtract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSubtract.TabIndex = 0;
            this.pbSubtract.TabStop = false;
            this.pbSubtract.Click += new System.EventHandler(this.picbox_Subtract_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.plus_white_64;
            this.pbAdd.Location = new System.Drawing.Point(41, 22);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(90, 75);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAdd.TabIndex = 0;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.picbox_Add_Click);
            // 
            // lbl_Problem
            // 
            this.lbl_Problem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Problem.AutoSize = true;
            this.lbl_Problem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Problem.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Problem.ForeColor = System.Drawing.Color.White;
            this.lbl_Problem.Location = new System.Drawing.Point(185, 254);
            this.lbl_Problem.Name = "lbl_Problem";
            this.lbl_Problem.Size = new System.Drawing.Size(240, 109);
            this.lbl_Problem.TabIndex = 0;
            this.lbl_Problem.Text = "5 x 5";
            // 
            // txt_Answer
            // 
            this.txt_Answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(217)))), ((int)(((byte)(237)))));
            this.txt_Answer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Answer.Location = new System.Drawing.Point(186, 375);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(239, 55);
            this.txt_Answer.TabIndex = 3;
            this.txt_Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Answer.Click += new System.EventHandler(this.txt_Answer_Click);
            this.txt_Answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Answer_KeyDown);
            // 
            // MathZilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MathZilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "temp";
            this.Load += new System.EventHandler(this.temp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Operators.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDivide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_p2_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_p1_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_Operators;
        private System.Windows.Forms.PictureBox pbDivide;
        private System.Windows.Forms.PictureBox pbMultiply;
        private System.Windows.Forms.PictureBox pbSubtract;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Button btn_Clue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_ClueDisplay;
        private System.Windows.Forms.Label lbl_p2_score;
        private System.Windows.Forms.Label lbl_p1_score;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_p2_name;
        private System.Windows.Forms.Label lbl_p1_Name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Problem;
        private System.Windows.Forms.TextBox txt_Answer;
    }
}