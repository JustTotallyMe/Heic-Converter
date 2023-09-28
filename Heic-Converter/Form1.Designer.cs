
namespace Heic_Converter
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
            this.txt_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_convert = new System.Windows.Forms.Button();
            this.rBtn_jpg = new System.Windows.Forms.RadioButton();
            this.rBtn_png = new System.Windows.Forms.RadioButton();
            this.rBtn_bmp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(47, 14);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(230, 20);
            this.txt_path.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pfad:";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(283, 14);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(81, 20);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Durchsuchen";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(12, 95);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(352, 25);
            this.btn_convert.TabIndex = 5;
            this.btn_convert.Text = "Konvertieren";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // rBtn_jpg
            // 
            this.rBtn_jpg.AutoSize = true;
            this.rBtn_jpg.Checked = true;
            this.rBtn_jpg.Location = new System.Drawing.Point(47, 58);
            this.rBtn_jpg.Name = "rBtn_jpg";
            this.rBtn_jpg.Size = new System.Drawing.Size(45, 17);
            this.rBtn_jpg.TabIndex = 6;
            this.rBtn_jpg.TabStop = true;
            this.rBtn_jpg.Text = "JPG";
            this.rBtn_jpg.UseVisualStyleBackColor = true;
            // 
            // rBtn_png
            // 
            this.rBtn_png.AutoSize = true;
            this.rBtn_png.Location = new System.Drawing.Point(134, 58);
            this.rBtn_png.Name = "rBtn_png";
            this.rBtn_png.Size = new System.Drawing.Size(48, 17);
            this.rBtn_png.TabIndex = 7;
            this.rBtn_png.Text = "PNG";
            this.rBtn_png.UseVisualStyleBackColor = true;
            // 
            // rBtn_bmp
            // 
            this.rBtn_bmp.AutoSize = true;
            this.rBtn_bmp.Location = new System.Drawing.Point(229, 58);
            this.rBtn_bmp.Name = "rBtn_bmp";
            this.rBtn_bmp.Size = new System.Drawing.Size(48, 17);
            this.rBtn_bmp.TabIndex = 8;
            this.rBtn_bmp.Text = "BMP";
            this.rBtn_bmp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 135);
            this.Controls.Add(this.rBtn_bmp);
            this.Controls.Add(this.rBtn_png);
            this.Controls.Add(this.rBtn_jpg);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Heic/Heif Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.RadioButton rBtn_jpg;
        private System.Windows.Forms.RadioButton rBtn_png;
        private System.Windows.Forms.RadioButton rBtn_bmp;
    }
}

