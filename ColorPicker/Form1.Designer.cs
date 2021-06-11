
namespace ColorPicker
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Bvalue2 = new System.Windows.Forms.Label();
            this.Gvalue2 = new System.Windows.Forms.Label();
            this.Rvalue2 = new System.Windows.Forms.Label();
            this.Avalue2 = new System.Windows.Forms.Label();
            this.Bkey2 = new System.Windows.Forms.Label();
            this.Gkey2 = new System.Windows.Forms.Label();
            this.Rkey2 = new System.Windows.Forms.Label();
            this.Akey2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.BValue = new System.Windows.Forms.Label();
            this.GValue = new System.Windows.Forms.Label();
            this.Rvalue = new System.Windows.Forms.Label();
            this.Avalue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uC_ColorPicker1 = new ColorPicker.UC_ColorPicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1049, 321);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown_1);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove_1);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.Bvalue2);
            this.groupBox3.Controls.Add(this.Gvalue2);
            this.groupBox3.Controls.Add(this.Rvalue2);
            this.groupBox3.Controls.Add(this.Avalue2);
            this.groupBox3.Controls.Add(this.Bkey2);
            this.groupBox3.Controls.Add(this.Gkey2);
            this.groupBox3.Controls.Add(this.Rkey2);
            this.groupBox3.Controls.Add(this.Akey2);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Location = new System.Drawing.Point(1102, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 222);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // Bvalue2
            // 
            this.Bvalue2.AutoSize = true;
            this.Bvalue2.Location = new System.Drawing.Point(215, 103);
            this.Bvalue2.Name = "Bvalue2";
            this.Bvalue2.Size = new System.Drawing.Size(16, 17);
            this.Bvalue2.TabIndex = 15;
            this.Bvalue2.Text = "0";
            // 
            // Gvalue2
            // 
            this.Gvalue2.AutoSize = true;
            this.Gvalue2.Location = new System.Drawing.Point(215, 67);
            this.Gvalue2.Name = "Gvalue2";
            this.Gvalue2.Size = new System.Drawing.Size(16, 17);
            this.Gvalue2.TabIndex = 14;
            this.Gvalue2.Text = "0";
            // 
            // Rvalue2
            // 
            this.Rvalue2.AutoSize = true;
            this.Rvalue2.Location = new System.Drawing.Point(215, 34);
            this.Rvalue2.Name = "Rvalue2";
            this.Rvalue2.Size = new System.Drawing.Size(16, 17);
            this.Rvalue2.TabIndex = 13;
            this.Rvalue2.Text = "0";
            // 
            // Avalue2
            // 
            this.Avalue2.AutoSize = true;
            this.Avalue2.Location = new System.Drawing.Point(215, 5);
            this.Avalue2.Name = "Avalue2";
            this.Avalue2.Size = new System.Drawing.Size(16, 17);
            this.Avalue2.TabIndex = 12;
            this.Avalue2.Text = "0";
            // 
            // Bkey2
            // 
            this.Bkey2.AutoSize = true;
            this.Bkey2.Location = new System.Drawing.Point(136, 103);
            this.Bkey2.Name = "Bkey2";
            this.Bkey2.Size = new System.Drawing.Size(17, 17);
            this.Bkey2.TabIndex = 11;
            this.Bkey2.Text = "B";
            // 
            // Gkey2
            // 
            this.Gkey2.AutoSize = true;
            this.Gkey2.Location = new System.Drawing.Point(136, 67);
            this.Gkey2.Name = "Gkey2";
            this.Gkey2.Size = new System.Drawing.Size(19, 17);
            this.Gkey2.TabIndex = 10;
            this.Gkey2.Text = "G";
            // 
            // Rkey2
            // 
            this.Rkey2.AutoSize = true;
            this.Rkey2.Location = new System.Drawing.Point(136, 34);
            this.Rkey2.Name = "Rkey2";
            this.Rkey2.Size = new System.Drawing.Size(18, 17);
            this.Rkey2.TabIndex = 9;
            this.Rkey2.Text = "R";
            // 
            // Akey2
            // 
            this.Akey2.AutoSize = true;
            this.Akey2.Location = new System.Drawing.Point(136, 5);
            this.Akey2.Name = "Akey2";
            this.Akey2.Size = new System.Drawing.Size(44, 17);
            this.Akey2.TabIndex = 8;
            this.Akey2.Text = "Alpha";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(33, 45);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 63);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1482, 68);
            this.label1.TabIndex = 36;
            this.label1.Text = "Color Picker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.btn_Open);
            this.groupBox2.Controls.Add(this.BValue);
            this.groupBox2.Controls.Add(this.GValue);
            this.groupBox2.Controls.Add(this.Rvalue);
            this.groupBox2.Controls.Add(this.Avalue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(664, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 222);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(265, 45);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(107, 78);
            this.btn_Open.TabIndex = 16;
            this.btn_Open.Text = "Open Picture";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click_1);
            // 
            // BValue
            // 
            this.BValue.AutoSize = true;
            this.BValue.Location = new System.Drawing.Point(215, 103);
            this.BValue.Name = "BValue";
            this.BValue.Size = new System.Drawing.Size(16, 17);
            this.BValue.TabIndex = 15;
            this.BValue.Text = "0";
            // 
            // GValue
            // 
            this.GValue.AutoSize = true;
            this.GValue.Location = new System.Drawing.Point(215, 67);
            this.GValue.Name = "GValue";
            this.GValue.Size = new System.Drawing.Size(16, 17);
            this.GValue.TabIndex = 14;
            this.GValue.Text = "0";
            // 
            // Rvalue
            // 
            this.Rvalue.AutoSize = true;
            this.Rvalue.Location = new System.Drawing.Point(215, 34);
            this.Rvalue.Name = "Rvalue";
            this.Rvalue.Size = new System.Drawing.Size(16, 17);
            this.Rvalue.TabIndex = 13;
            this.Rvalue.Text = "0";
            // 
            // Avalue
            // 
            this.Avalue.AutoSize = true;
            this.Avalue.Location = new System.Drawing.Point(215, 5);
            this.Avalue.Name = "Avalue";
            this.Avalue.Size = new System.Drawing.Size(16, 17);
            this.Avalue.TabIndex = 12;
            this.Avalue.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alpha";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(33, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 63);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // uC_ColorPicker1
            // 
            this.uC_ColorPicker1.AutoScroll = true;
            this.uC_ColorPicker1.AutoSize = true;
            this.uC_ColorPicker1.Location = new System.Drawing.Point(2, 0);
            this.uC_ColorPicker1.Name = "uC_ColorPicker1";
            this.uC_ColorPicker1.Size = new System.Drawing.Size(820, 788);
            this.uC_ColorPicker1.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1503, 774);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uC_ColorPicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Bvalue2;
        private System.Windows.Forms.Label Gvalue2;
        private System.Windows.Forms.Label Rvalue2;
        private System.Windows.Forms.Label Avalue2;
        private System.Windows.Forms.Label Bkey2;
        private System.Windows.Forms.Label Gkey2;
        private System.Windows.Forms.Label Rkey2;
        private System.Windows.Forms.Label Akey2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private UC_ColorPicker uC_ColorPicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Label BValue;
        private System.Windows.Forms.Label GValue;
        private System.Windows.Forms.Label Rvalue;
        private System.Windows.Forms.Label Avalue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

