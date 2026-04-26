namespace PASSWORD_GENERATOR
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntGenerate = new System.Windows.Forms.Button();
            this.bntCopy = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.RichTextBox();
            this.gBPasswordlength = new System.Windows.Forms.GroupBox();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.PasswordLength = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.chkMix = new System.Windows.Forms.CheckBox();
            this.chkDigits = new System.Windows.Forms.CheckBox();
            this.chkSmall = new System.Windows.Forms.CheckBox();
            this.chkCapital = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.gBPasswordlength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(435, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "PASSWORD GENERATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(848, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "GENERATE STRONG PASSWORD AND KEEP YOUR ACCOUNT SAFE";
            // 
            // bntGenerate
            // 
            this.bntGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntGenerate.Location = new System.Drawing.Point(301, 373);
            this.bntGenerate.Name = "bntGenerate";
            this.bntGenerate.Size = new System.Drawing.Size(185, 68);
            this.bntGenerate.TabIndex = 2;
            this.bntGenerate.Text = "GENERATE";
            this.bntGenerate.UseVisualStyleBackColor = true;
            this.bntGenerate.Click += new System.EventHandler(this.bntGenerate_Click);
            // 
            // bntCopy
            // 
            this.bntCopy.Font = new System.Drawing.Font("Tahoma", 14F);
            this.bntCopy.Location = new System.Drawing.Point(671, 373);
            this.bntCopy.Name = "bntCopy";
            this.bntCopy.Size = new System.Drawing.Size(185, 68);
            this.bntCopy.TabIndex = 3;
            this.bntCopy.Text = "COPY";
            this.bntCopy.UseVisualStyleBackColor = true;
            this.bntCopy.Click += new System.EventHandler(this.bntCopy_Click);
            // 
            // bntReset
            // 
            this.bntReset.Font = new System.Drawing.Font("Tahoma", 14F);
            this.bntReset.Location = new System.Drawing.Point(1026, 373);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(185, 68);
            this.bntReset.TabIndex = 4;
            this.bntReset.Text = "RESET";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(444, 218);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(611, 55);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "";
            // 
            // gBPasswordlength
            // 
            this.gBPasswordlength.BackColor = System.Drawing.Color.Transparent;
            this.gBPasswordlength.Controls.Add(this.lblPasswordLength);
            this.gBPasswordlength.Controls.Add(this.PasswordLength);
            this.gBPasswordlength.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBPasswordlength.ForeColor = System.Drawing.Color.White;
            this.gBPasswordlength.Location = new System.Drawing.Point(275, 543);
            this.gBPasswordlength.Name = "gBPasswordlength";
            this.gBPasswordlength.Size = new System.Drawing.Size(429, 189);
            this.gBPasswordlength.TabIndex = 6;
            this.gBPasswordlength.TabStop = false;
            this.gBPasswordlength.Text = "Password Length";
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLength.Location = new System.Drawing.Point(193, 64);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(30, 32);
            this.lblPasswordLength.TabIndex = 1;
            this.lblPasswordLength.Text = "0";
            // 
            // PasswordLength
            // 
            this.PasswordLength.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PasswordLength.Location = new System.Drawing.Point(11, 123);
            this.PasswordLength.Maximum = 50;
            this.PasswordLength.Name = "PasswordLength";
            this.PasswordLength.Size = new System.Drawing.Size(412, 56);
            this.PasswordLength.TabIndex = 0;
            this.PasswordLength.Scroll += new System.EventHandler(this.PasswordLength_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkSpecial);
            this.groupBox1.Controls.Add(this.chkMix);
            this.groupBox1.Controls.Add(this.chkDigits);
            this.groupBox1.Controls.Add(this.chkSmall);
            this.groupBox1.Controls.Add(this.chkCapital);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(826, 543);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 189);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Characters";
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkSpecial.Location = new System.Drawing.Point(240, 123);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(76, 28);
            this.chkSpecial.TabIndex = 4;
            this.chkSpecial.Tag = "5";
            this.chkSpecial.Text = "@#$";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // chkMix
            // 
            this.chkMix.AutoSize = true;
            this.chkMix.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkMix.Location = new System.Drawing.Point(102, 123);
            this.chkMix.Name = "chkMix";
            this.chkMix.Size = new System.Drawing.Size(62, 28);
            this.chkMix.TabIndex = 3;
            this.chkMix.Tag = "4";
            this.chkMix.Text = "Mix";
            this.chkMix.UseVisualStyleBackColor = true;
            // 
            // chkDigits
            // 
            this.chkDigits.AutoSize = true;
            this.chkDigits.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkDigits.Location = new System.Drawing.Point(307, 69);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Size = new System.Drawing.Size(65, 28);
            this.chkDigits.TabIndex = 2;
            this.chkDigits.Tag = "3";
            this.chkDigits.Text = "123";
            this.chkDigits.UseVisualStyleBackColor = true;
            // 
            // chkSmall
            // 
            this.chkSmall.AutoSize = true;
            this.chkSmall.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkSmall.Location = new System.Drawing.Point(184, 60);
            this.chkSmall.Name = "chkSmall";
            this.chkSmall.Size = new System.Drawing.Size(63, 28);
            this.chkSmall.TabIndex = 1;
            this.chkSmall.Tag = "2";
            this.chkSmall.Text = "abc";
            this.chkSmall.UseVisualStyleBackColor = true;
            // 
            // chkCapital
            // 
            this.chkCapital.AutoSize = true;
            this.chkCapital.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkCapital.Location = new System.Drawing.Point(41, 60);
            this.chkCapital.Name = "chkCapital";
            this.chkCapital.Size = new System.Drawing.Size(68, 28);
            this.chkCapital.TabIndex = 0;
            this.chkCapital.Tag = "1";
            this.chkCapital.Text = "ABC";
            this.chkCapital.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureClose
            // 
            this.pictureClose.BackgroundImage = global::PASSWORD_GENERATOR.Properties.Resources.X;
            this.pictureClose.Image = global::PASSWORD_GENERATOR.Properties.Resources.X;
            this.pictureClose.Location = new System.Drawing.Point(1443, 9);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(41, 36);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 8;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PASSWORD_GENERATOR.Properties.Resources.Untit33led;
            this.ClientSize = new System.Drawing.Size(1496, 792);
            this.Controls.Add(this.pictureClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBPasswordlength);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.bntCopy);
            this.Controls.Add(this.bntGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBPasswordlength.ResumeLayout(false);
            this.gBPasswordlength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntGenerate;
        private System.Windows.Forms.Button bntCopy;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.RichTextBox txtPassword;
        private System.Windows.Forms.GroupBox gBPasswordlength;
        private System.Windows.Forms.TrackBar PasswordLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkSmall;
        private System.Windows.Forms.CheckBox chkCapital;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkMix;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureClose;
    }
}

