﻿
namespace sodoko_winform3
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
            this.btn_sovle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sovle
            // 
            this.btn_sovle.BackColor = System.Drawing.Color.LightGray;
            this.btn_sovle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sovle.Location = new System.Drawing.Point(392, 141);
            this.btn_sovle.Name = "btn_sovle";
            this.btn_sovle.Size = new System.Drawing.Size(103, 64);
            this.btn_sovle.TabIndex = 0;
            this.btn_sovle.Text = "حل سودوکو";
            this.btn_sovle.UseVisualStyleBackColor = false;
            this.btn_sovle.Click += new System.EventHandler(this.btn_sovle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 377);
            this.Controls.Add(this.btn_sovle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sovle;
    }
}

