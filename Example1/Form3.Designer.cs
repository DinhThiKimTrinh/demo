﻿namespace Example1
{
    partial class Form3
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
            this.buttonDX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDX
            // 
            this.buttonDX.Location = new System.Drawing.Point(517, 433);
            this.buttonDX.Name = "buttonDX";
            this.buttonDX.Size = new System.Drawing.Size(110, 34);
            this.buttonDX.TabIndex = 0;
            this.buttonDX.Text = "Đăng Xuất";
            this.buttonDX.UseVisualStyleBackColor = true;
            this.buttonDX.Click += new System.EventHandler(this.buttonDX_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Example1.Properties.Resources._200_Background_MUA_HE_Dep_Soi_Dong_Day_Nang_Luong;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 479);
            this.Controls.Add(this.buttonDX);
            this.Name = "Form3";
            this.Text = "Nội Dung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDX;
    }
}