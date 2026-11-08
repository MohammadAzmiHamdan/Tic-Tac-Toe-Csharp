namespace Tik_Tak_Toe_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(79, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 71);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn  : ";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblWinner.Location = new System.Drawing.Point(122, 388);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(272, 76);
            this.lblWinner.TabIndex = 2;
            this.lblWinner.Text = "In Progress";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(122, 246);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(202, 71);
            this.lblTurn.TabIndex = 4;
            this.lblTurn.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(79, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 71);
            this.label3.TabIndex = 3;
            this.label3.Text = "Winner :";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(572, 162);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(151, 152);
            this.btn1.TabIndex = 6;
            this.btn1.Tag = "?";
            this.btn1.Text = "  ";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(749, 162);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(151, 152);
            this.btn2.TabIndex = 7;
            this.btn2.Tag = "?";
            this.btn2.Text = "  ";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(928, 162);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(151, 152);
            this.btn3.TabIndex = 8;
            this.btn3.Tag = "?";
            this.btn3.Text = "  ";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn6.BackgroundImage")));
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(928, 347);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(151, 152);
            this.btn6.TabIndex = 11;
            this.btn6.Tag = "?";
            this.btn6.Text = "  ";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5.BackgroundImage")));
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(749, 347);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(151, 152);
            this.btn5.TabIndex = 10;
            this.btn5.Tag = "?";
            this.btn5.Text = "  ";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4.BackgroundImage")));
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(572, 347);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(151, 152);
            this.btn4.TabIndex = 9;
            this.btn4.Tag = "?";
            this.btn4.Text = "  ";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn9.BackgroundImage")));
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(928, 532);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(151, 152);
            this.btn9.TabIndex = 14;
            this.btn9.Tag = "?";
            this.btn9.Text = "  ";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn8.BackgroundImage")));
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(749, 532);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(151, 152);
            this.btn8.TabIndex = 13;
            this.btn8.Tag = "?";
            this.btn8.Text = "  ";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn7.BackgroundImage")));
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(572, 532);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(151, 152);
            this.btn7.TabIndex = 12;
            this.btn7.Tag = "?";
            this.btn7.Text = "  ";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(103, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 56);
            this.button1.TabIndex = 15;
            this.button1.Text = "Restart Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Tik_Tak_Toe_Game.Properties.Resources.tictactoe_background_4k;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 773);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tik Tak Toe Game ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button button1;
    }
}

