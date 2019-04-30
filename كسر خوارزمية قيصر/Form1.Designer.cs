namespace كسر_خوارزمية_قيصر
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
            this.groupBoxCipher = new System.Windows.Forms.GroupBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.groupBoxDecrypt = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.textBoxPlan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxCipher.SuspendLayout();
            this.groupBoxDecrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCipher
            // 
            this.groupBoxCipher.Controls.Add(this.buttonDecrypt);
            this.groupBoxCipher.Controls.Add(this.textBoxCipher);
            this.groupBoxCipher.Location = new System.Drawing.Point(1, 88);
            this.groupBoxCipher.Name = "groupBoxCipher";
            this.groupBoxCipher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxCipher.Size = new System.Drawing.Size(451, 165);
            this.groupBoxCipher.TabIndex = 0;
            this.groupBoxCipher.TabStop = false;
            this.groupBoxCipher.Text = "النص المشفر";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(198, 118);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(93, 33);
            this.buttonDecrypt.TabIndex = 1;
            this.buttonDecrypt.Text = "فك التشفير";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Location = new System.Drawing.Point(29, 23);
            this.textBoxCipher.Multiline = true;
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCipher.Size = new System.Drawing.Size(400, 86);
            this.textBoxCipher.TabIndex = 0;
            // 
            // groupBoxDecrypt
            // 
            this.groupBoxDecrypt.Controls.Add(this.label1);
            this.groupBoxDecrypt.Controls.Add(this.buttonNext);
            this.groupBoxDecrypt.Controls.Add(this.buttonPrev);
            this.groupBoxDecrypt.Controls.Add(this.textBoxPlan);
            this.groupBoxDecrypt.Location = new System.Drawing.Point(1, 259);
            this.groupBoxDecrypt.Name = "groupBoxDecrypt";
            this.groupBoxDecrypt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxDecrypt.Size = new System.Drawing.Size(451, 176);
            this.groupBoxDecrypt.TabIndex = 1;
            this.groupBoxDecrypt.TabStop = false;
            this.groupBoxDecrypt.Text = "النص الأصلي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "الخطوة";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(267, 125);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(93, 33);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "<<";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(121, 125);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(93, 33);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = ">>";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // textBoxPlan
            // 
            this.textBoxPlan.Location = new System.Drawing.Point(29, 23);
            this.textBoxPlan.Multiline = true;
            this.textBoxPlan.Name = "textBoxPlan";
            this.textBoxPlan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPlan.Size = new System.Drawing.Size(400, 86);
            this.textBoxPlan.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxDecrypt);
            this.Controls.Add(this.groupBoxCipher);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كسر خوارزمية قيصر";
            this.groupBoxCipher.ResumeLayout(false);
            this.groupBoxCipher.PerformLayout();
            this.groupBoxDecrypt.ResumeLayout(false);
            this.groupBoxDecrypt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCipher;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.GroupBox groupBoxDecrypt;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.TextBox textBoxPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

