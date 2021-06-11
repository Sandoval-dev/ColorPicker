
namespace ColorPicker
{
    partial class UC_ColorPicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblColorSmall = new System.Windows.Forms.Label();
            this.lblRgb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.textBlue = new System.Windows.Forms.TextBox();
            this.textGreen = new System.Windows.Forms.TextBox();
            this.textRed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ColorPicker.Properties.Resources.Ekran_Alıntısı;
            this.pictureBox1.Location = new System.Drawing.Point(23, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 329);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // lblColorSmall
            // 
            this.lblColorSmall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorSmall.Location = new System.Drawing.Point(452, 508);
            this.lblColorSmall.Name = "lblColorSmall";
            this.lblColorSmall.Size = new System.Drawing.Size(106, 34);
            this.lblColorSmall.TabIndex = 21;
            this.lblColorSmall.Click += new System.EventHandler(this.lblColorSmall_Click);
            // 
            // lblRgb
            // 
            this.lblRgb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRgb.Location = new System.Drawing.Point(53, 508);
            this.lblRgb.Name = "lblRgb";
            this.lblRgb.Size = new System.Drawing.Size(215, 35);
            this.lblRgb.TabIndex = 22;
            this.lblRgb.Click += new System.EventHandler(this.lblRgb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelColor);
            this.groupBox1.Controls.Add(this.textBlue);
            this.groupBox1.Controls.Add(this.textGreen);
            this.groupBox1.Controls.Add(this.textRed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(105, 556);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 229);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(234, 36);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(141, 157);
            this.panelColor.TabIndex = 6;
            // 
            // textBlue
            // 
            this.textBlue.Location = new System.Drawing.Point(86, 145);
            this.textBlue.Name = "textBlue";
            this.textBlue.ReadOnly = true;
            this.textBlue.Size = new System.Drawing.Size(100, 22);
            this.textBlue.TabIndex = 5;
            // 
            // textGreen
            // 
            this.textGreen.Location = new System.Drawing.Point(86, 98);
            this.textGreen.Name = "textGreen";
            this.textGreen.ReadOnly = true;
            this.textGreen.Size = new System.Drawing.Size(100, 22);
            this.textGreen.TabIndex = 4;
            // 
            // textRed
            // 
            this.textRed.Location = new System.Drawing.Point(86, 50);
            this.textRed.Name = "textRed";
            this.textRed.ReadOnly = true;
            this.textRed.Size = new System.Drawing.Size(100, 22);
            this.textRed.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Red";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.Location = new System.Drawing.Point(679, 573);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 30);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UC_ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRgb);
            this.Controls.Add(this.lblColorSmall);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_ColorPicker";
            this.Size = new System.Drawing.Size(1501, 788);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblColorSmall;
        private System.Windows.Forms.Label lblRgb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.TextBox textBlue;
        private System.Windows.Forms.TextBox textGreen;
        private System.Windows.Forms.TextBox textRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
    }
}
