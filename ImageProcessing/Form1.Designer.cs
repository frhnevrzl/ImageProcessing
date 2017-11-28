namespace ImageProcessing
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
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btngray = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginal
            // 
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picOriginal.Location = new System.Drawing.Point(20, 23);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(320, 209);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picResult.Location = new System.Drawing.Point(359, 23);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(339, 209);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 1;
            this.picResult.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(730, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(66, 27);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btngray
            // 
            this.btngray.Location = new System.Drawing.Point(730, 141);
            this.btngray.Name = "btngray";
            this.btngray.Size = new System.Drawing.Size(66, 27);
            this.btngray.TabIndex = 3;
            this.btngray.Text = "Grayscale";
            this.btngray.UseVisualStyleBackColor = true;
            this.btngray.Click += new System.EventHandler(this.btngray_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(815, 141);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(66, 27);
            this.btnNegative.TabIndex = 4;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(815, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(730, 187);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(151, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rotate:";
            // 
            // btnOriginal
            // 
            this.btnOriginal.Location = new System.Drawing.Point(730, 108);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(66, 27);
            this.btnOriginal.TabIndex = 8;
            this.btnOriginal.Text = "Original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(730, 88);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(151, 17);
            this.hScrollBar1.TabIndex = 9;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Threshold:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(730, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Original Image:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Brightness:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Result Image:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btngray);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picOriginal);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btngray;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

