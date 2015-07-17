namespace BrailleKeyboard
{
    partial class MainWindow
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
            this.trackingImage = new System.Windows.Forms.PictureBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.depthButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fingersTextBox1 = new System.Windows.Forms.TextBox();
            this.colorImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alphabetbox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fingersTextBox2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkSameMargins = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textMarginBot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textMarginTop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMarginRight = new System.Windows.Forms.TextBox();
            this.textMarginLeft = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackingImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackingImage
            // 
            this.trackingImage.BackColor = System.Drawing.Color.Tan;
            this.trackingImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.trackingImage.Location = new System.Drawing.Point(204, 46);
            this.trackingImage.Name = "trackingImage";
            this.trackingImage.Size = new System.Drawing.Size(600, 488);
            this.trackingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trackingImage.TabIndex = 0;
            this.trackingImage.TabStop = false;
            // 
            // colorButton
            // 
            this.colorButton.AutoSize = true;
            this.colorButton.BackColor = System.Drawing.Color.GhostWhite;
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorButton.Location = new System.Drawing.Point(34, 67);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 1;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // depthButton
            // 
            this.depthButton.BackColor = System.Drawing.Color.GhostWhite;
            this.depthButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.depthButton.Location = new System.Drawing.Point(34, 110);
            this.depthButton.Name = "depthButton";
            this.depthButton.Size = new System.Drawing.Size(75, 23);
            this.depthButton.TabIndex = 2;
            this.depthButton.Text = "Depth";
            this.depthButton.UseVisualStyleBackColor = false;
            this.depthButton.Click += new System.EventHandler(this.depthButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hand 1 Fingers";
            // 
            // fingersTextBox1
            // 
            this.fingersTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fingersTextBox1.Location = new System.Drawing.Point(115, 37);
            this.fingersTextBox1.Name = "fingersTextBox1";
            this.fingersTextBox1.ReadOnly = true;
            this.fingersTextBox1.Size = new System.Drawing.Size(50, 20);
            this.fingersTextBox1.TabIndex = 11;
            this.fingersTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorImage
            // 
            this.colorImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colorImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorImage.Location = new System.Drawing.Point(818, 399);
            this.colorImage.Name = "colorImage";
            this.colorImage.Size = new System.Drawing.Size(166, 135);
            this.colorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorImage.TabIndex = 16;
            this.colorImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Braille Keyboard Tester";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.alphabetbox);
            this.groupBox1.Location = new System.Drawing.Point(814, 280);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(176, 89);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alphabet Detected";
            // 
            // alphabetbox
            // 
            this.alphabetbox.BackColor = System.Drawing.Color.Yellow;
            this.alphabetbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphabetbox.Location = new System.Drawing.Point(8, 39);
            this.alphabetbox.Name = "alphabetbox";
            this.alphabetbox.Size = new System.Drawing.Size(157, 28);
            this.alphabetbox.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.fingersTextBox2);
            this.groupBox4.Controls.Add(this.fingersTextBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(814, 155);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(176, 102);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hand Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hand 2 Fingers";
            // 
            // fingersTextBox2
            // 
            this.fingersTextBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fingersTextBox2.Location = new System.Drawing.Point(115, 67);
            this.fingersTextBox2.Name = "fingersTextBox2";
            this.fingersTextBox2.ReadOnly = true;
            this.fingersTextBox2.Size = new System.Drawing.Size(50, 20);
            this.fingersTextBox2.TabIndex = 12;
            this.fingersTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox7.Controls.Add(this.checkSameMargins);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.textMarginBot);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.textMarginTop);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.textMarginRight);
            this.groupBox7.Controls.Add(this.textMarginLeft);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(27, 262);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(150, 145);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Margins";
            // 
            // checkSameMargins
            // 
            this.checkSameMargins.AutoSize = true;
            this.checkSameMargins.Location = new System.Drawing.Point(34, 116);
            this.checkSameMargins.Margin = new System.Windows.Forms.Padding(2);
            this.checkSameMargins.Name = "checkSameMargins";
            this.checkSameMargins.Size = new System.Drawing.Size(93, 17);
            this.checkSameMargins.TabIndex = 18;
            this.checkSameMargins.Text = "Same Margins";
            this.checkSameMargins.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Margin Bot";
            // 
            // textMarginBot
            // 
            this.textMarginBot.Location = new System.Drawing.Point(92, 90);
            this.textMarginBot.Name = "textMarginBot";
            this.textMarginBot.Size = new System.Drawing.Size(42, 20);
            this.textMarginBot.TabIndex = 16;
            this.textMarginBot.TextChanged += new System.EventHandler(this.marginsChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Margin Top";
            // 
            // textMarginTop
            // 
            this.textMarginTop.Location = new System.Drawing.Point(92, 67);
            this.textMarginTop.Name = "textMarginTop";
            this.textMarginTop.Size = new System.Drawing.Size(42, 20);
            this.textMarginTop.TabIndex = 14;
            this.textMarginTop.TextChanged += new System.EventHandler(this.marginsChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Margin Right";
            // 
            // textMarginRight
            // 
            this.textMarginRight.Location = new System.Drawing.Point(92, 42);
            this.textMarginRight.Name = "textMarginRight";
            this.textMarginRight.Size = new System.Drawing.Size(42, 20);
            this.textMarginRight.TabIndex = 12;
            this.textMarginRight.TextChanged += new System.EventHandler(this.marginsChanged);
            // 
            // textMarginLeft
            // 
            this.textMarginLeft.Location = new System.Drawing.Point(92, 18);
            this.textMarginLeft.Name = "textMarginLeft";
            this.textMarginLeft.Size = new System.Drawing.Size(42, 20);
            this.textMarginLeft.TabIndex = 11;
            this.textMarginLeft.TextChanged += new System.EventHandler(this.marginsChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Margin Left";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Location = new System.Drawing.Point(874, 548);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Color Image";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.depthButton);
            this.groupBox3.Controls.Add(this.colorButton);
            this.groupBox3.Location = new System.Drawing.Point(27, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(150, 192);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Image Mode";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(27, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 86);
            this.button1.TabIndex = 23;
            this.button1.Text = "Open Notepad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::BrailleKeyboard.Properties.Resources.GT9Kj4jT4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colorImage);
            this.Controls.Add(this.trackingImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Braille Keyboard Tester";
            ((System.ComponentModel.ISupportInitialize)(this.trackingImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button depthButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fingersTextBox1;
        private System.Windows.Forms.PictureBox colorImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox trackingImage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fingersTextBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textMarginBot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMarginTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMarginRight;
        private System.Windows.Forms.TextBox textMarginLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkSameMargins;
        private System.Windows.Forms.TextBox alphabetbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}

