namespace RawToRGConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RawTbx = new System.Windows.Forms.TextBox();
            this.PngTbx = new System.Windows.Forms.TextBox();
            this.RawBtn = new System.Windows.Forms.Button();
            this.PngBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FileSizeLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResolutionLbl = new System.Windows.Forms.Label();
            this.DisplayPbx = new System.Windows.Forms.PictureBox();
            this.SaveRawBtn = new System.Windows.Forms.Button();
            this.SavePngBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAW File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PNG File";
            // 
            // RawTbx
            // 
            this.RawTbx.Location = new System.Drawing.Point(66, 6);
            this.RawTbx.Name = "RawTbx";
            this.RawTbx.Size = new System.Drawing.Size(358, 20);
            this.RawTbx.TabIndex = 2;
            // 
            // PngTbx
            // 
            this.PngTbx.Location = new System.Drawing.Point(67, 31);
            this.PngTbx.Name = "PngTbx";
            this.PngTbx.Size = new System.Drawing.Size(358, 20);
            this.PngTbx.TabIndex = 3;
            // 
            // RawBtn
            // 
            this.RawBtn.Location = new System.Drawing.Point(431, 6);
            this.RawBtn.Name = "RawBtn";
            this.RawBtn.Size = new System.Drawing.Size(44, 23);
            this.RawBtn.TabIndex = 4;
            this.RawBtn.Text = "Open";
            this.RawBtn.UseVisualStyleBackColor = true;
            this.RawBtn.Click += new System.EventHandler(this.RawBtn_Click);
            // 
            // PngBtn
            // 
            this.PngBtn.Location = new System.Drawing.Point(431, 29);
            this.PngBtn.Name = "PngBtn";
            this.PngBtn.Size = new System.Drawing.Size(44, 23);
            this.PngBtn.TabIndex = 5;
            this.PngBtn.Text = "Open";
            this.PngBtn.UseVisualStyleBackColor = true;
            this.PngBtn.Click += new System.EventHandler(this.PngBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Size: ";
            // 
            // FileSizeLbl
            // 
            this.FileSizeLbl.AutoSize = true;
            this.FileSizeLbl.Location = new System.Drawing.Point(122, 54);
            this.FileSizeLbl.Name = "FileSizeLbl";
            this.FileSizeLbl.Size = new System.Drawing.Size(13, 13);
            this.FileSizeLbl.TabIndex = 7;
            this.FileSizeLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Image Resolution";
            // 
            // ResolutionLbl
            // 
            this.ResolutionLbl.AutoSize = true;
            this.ResolutionLbl.Location = new System.Drawing.Point(370, 54);
            this.ResolutionLbl.Name = "ResolutionLbl";
            this.ResolutionLbl.Size = new System.Drawing.Size(0, 13);
            this.ResolutionLbl.TabIndex = 9;
            // 
            // DisplayPbx
            // 
            this.DisplayPbx.Location = new System.Drawing.Point(12, 82);
            this.DisplayPbx.Name = "DisplayPbx";
            this.DisplayPbx.Size = new System.Drawing.Size(513, 513);
            this.DisplayPbx.TabIndex = 10;
            this.DisplayPbx.TabStop = false;
            // 
            // SaveRawBtn
            // 
            this.SaveRawBtn.Location = new System.Drawing.Point(481, 6);
            this.SaveRawBtn.Name = "SaveRawBtn";
            this.SaveRawBtn.Size = new System.Drawing.Size(44, 23);
            this.SaveRawBtn.TabIndex = 11;
            this.SaveRawBtn.Text = "Save";
            this.SaveRawBtn.UseVisualStyleBackColor = true;
            this.SaveRawBtn.Click += new System.EventHandler(this.SaveRawBtn_Click);
            // 
            // SavePngBtn
            // 
            this.SavePngBtn.Location = new System.Drawing.Point(481, 29);
            this.SavePngBtn.Name = "SavePngBtn";
            this.SavePngBtn.Size = new System.Drawing.Size(44, 23);
            this.SavePngBtn.TabIndex = 12;
            this.SavePngBtn.Text = "Save";
            this.SavePngBtn.UseVisualStyleBackColor = true;
            this.SavePngBtn.Click += new System.EventHandler(this.SavePngBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 614);
            this.Controls.Add(this.SavePngBtn);
            this.Controls.Add(this.SaveRawBtn);
            this.Controls.Add(this.DisplayPbx);
            this.Controls.Add(this.ResolutionLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FileSizeLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PngBtn);
            this.Controls.Add(this.RawBtn);
            this.Controls.Add(this.PngTbx);
            this.Controls.Add(this.RawTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Raw / Png Converter";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RawTbx;
        private System.Windows.Forms.TextBox PngTbx;
        private System.Windows.Forms.Button RawBtn;
        private System.Windows.Forms.Button PngBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FileSizeLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ResolutionLbl;
        private System.Windows.Forms.PictureBox DisplayPbx;
        private System.Windows.Forms.Button SaveRawBtn;
        private System.Windows.Forms.Button SavePngBtn;
    }
}

