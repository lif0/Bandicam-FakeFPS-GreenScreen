namespace FakeFPS
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.chckBoxHideBackground = new System.Windows.Forms.CheckBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerCoords = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chckBoxOnTop = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "820";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 411);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "925";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 411);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Повторений";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(243, 411);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Скорость(в мс)";
            // 
            // chckBoxHideBackground
            // 
            this.chckBoxHideBackground.AutoSize = true;
            this.chckBoxHideBackground.Location = new System.Drawing.Point(335, 413);
            this.chckBoxHideBackground.Name = "chckBoxHideBackground";
            this.chckBoxHideBackground.Size = new System.Drawing.Size(166, 17);
            this.chckBoxHideBackground.TabIndex = 5;
            this.chckBoxHideBackground.Text = "Сделать форму прозрачной";
            this.chckBoxHideBackground.UseVisualStyleBackColor = true;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(29, 437);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(35, 20);
            this.txtX.TabIndex = 7;
            this.txtX.Text = "-1";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(29, 461);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(35, 20);
            this.txtY.TabIndex = 8;
            this.txtY.Text = "-1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y:";
            // 
            // timerCoords
            // 
            this.timerCoords.Enabled = true;
            this.timerCoords.Interval = 50;
            this.timerCoords.Tick += new System.EventHandler(this.timerCoords_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Размер цифр";
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Location = new System.Drawing.Point(93, 456);
            this.trackBarZoom.Maximum = -1;
            this.trackBarZoom.Minimum = -5;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(404, 45);
            this.trackBarZoom.TabIndex = 13;
            this.trackBarZoom.Value = -1;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FakeFPS.Properties.Resources._9;
            this.pictureBox2.Location = new System.Drawing.Point(21, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FakeFPS.Properties.Resources._9;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FakeFPS.Properties.Resources._9;
            this.pictureBox3.Location = new System.Drawing.Point(37, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // chckBoxOnTop
            // 
            this.chckBoxOnTop.AutoSize = true;
            this.chckBoxOnTop.Location = new System.Drawing.Point(335, 433);
            this.chckBoxOnTop.Name = "chckBoxOnTop";
            this.chckBoxOnTop.Size = new System.Drawing.Size(116, 17);
            this.chckBoxOnTop.TabIndex = 16;
            this.chckBoxOnTop.Text = "Поверх всех окон";
            this.chckBoxOnTop.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 153);
            this.panel1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(575, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chckBoxOnTop);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trackBarZoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.chckBoxHideBackground);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox chckBoxHideBackground;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerCoords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chckBoxOnTop;
        private System.Windows.Forms.Panel panel1;
    }
}

