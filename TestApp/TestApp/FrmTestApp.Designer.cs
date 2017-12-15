namespace TestApp
{
    partial class FrmTestApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTestApp));
            this.LblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picOne = new System.Windows.Forms.PictureBox();
            this.picTwo = new System.Windows.Forms.PictureBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMood = new System.Windows.Forms.GroupBox();
            this.grpOther = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).BeginInit();
            this.grpMood.SuspendLayout();
            this.grpOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(46, 34);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(183, 20);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Welcome to the program";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // picOne
            // 
            this.picOne.Image = global::TestApp.Properties.Resources._59_WM;
            this.picOne.Location = new System.Drawing.Point(26, 116);
            this.picOne.Name = "picOne";
            this.picOne.Size = new System.Drawing.Size(122, 95);
            this.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOne.TabIndex = 2;
            this.picOne.TabStop = false;
            // 
            // picTwo
            // 
            this.picTwo.Image = ((System.Drawing.Image)(resources.GetObject("picTwo.Image")));
            this.picTwo.Location = new System.Drawing.Point(177, 116);
            this.picTwo.Name = "picTwo";
            this.picTwo.Size = new System.Drawing.Size(125, 95);
            this.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTwo.TabIndex = 3;
            this.picTwo.TabStop = false;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(26, 252);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 23);
            this.btnHello.TabIndex = 4;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(177, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpMood
            // 
            this.grpMood.Controls.Add(this.radioButton2);
            this.grpMood.Controls.Add(this.radioButton1);
            this.grpMood.Location = new System.Drawing.Point(323, 56);
            this.grpMood.Name = "grpMood";
            this.grpMood.Size = new System.Drawing.Size(147, 101);
            this.grpMood.TabIndex = 6;
            this.grpMood.TabStop = false;
            this.grpMood.Text = "Moods";
            // 
            // grpOther
            // 
            this.grpOther.Controls.Add(this.radioButton4);
            this.grpOther.Controls.Add(this.radioButton3);
            this.grpOther.Location = new System.Drawing.Point(323, 205);
            this.grpOther.Name = "grpOther";
            this.grpOther.Size = new System.Drawing.Size(147, 103);
            this.grpOther.TabIndex = 7;
            this.grpOther.TabStop = false;
            this.grpOther.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 31);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(17, 67);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // FrmTestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 408);
            this.Controls.Add(this.grpOther);
            this.Controls.Add(this.grpMood);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.picTwo);
            this.Controls.Add(this.picOne);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.LblTitle);
            this.Name = "FrmTestApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test App";
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).EndInit();
            this.grpMood.ResumeLayout(false);
            this.grpMood.PerformLayout();
            this.grpOther.ResumeLayout(false);
            this.grpOther.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picOne;
        private System.Windows.Forms.PictureBox picTwo;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpMood;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpOther;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

