namespace Lab01_Bai3
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
            this.txtTenMien = new System.Windows.Forms.TextBox();
            this.btnPhanGiai = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên miền";
            // 
            // txtTenMien
            // 
            this.txtTenMien.Location = new System.Drawing.Point(95, 10);
            this.txtTenMien.Name = "txtTenMien";
            this.txtTenMien.Size = new System.Drawing.Size(224, 20);
            this.txtTenMien.TabIndex = 1;
            // 
            // btnPhanGiai
            // 
            this.btnPhanGiai.Location = new System.Drawing.Point(325, 8);
            this.btnPhanGiai.Name = "btnPhanGiai";
            this.btnPhanGiai.Size = new System.Drawing.Size(75, 23);
            this.btnPhanGiai.TabIndex = 2;
            this.btnPhanGiai.Text = "Phân giải";
            this.btnPhanGiai.UseVisualStyleBackColor = true;
            this.btnPhanGiai.Click += new System.EventHandler(this.btnPhanGiai_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(16, 42);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(678, 396);
            this.rtbInfo.TabIndex = 3;
            this.rtbInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.btnPhanGiai);
            this.Controls.Add(this.txtTenMien);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenMien;
        private System.Windows.Forms.Button btnPhanGiai;
        private System.Windows.Forms.RichTextBox rtbInfo;
    }
}

