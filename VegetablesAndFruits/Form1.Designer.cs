﻿
namespace VegetablesAndFruits
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDbConnect = new System.Windows.Forms.Label();
            this.checkBoxDbConnect = new System.Windows.Forms.CheckBox();
            this.textBoxShowSelect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDbConnect
            // 
            this.labelDbConnect.AutoSize = true;
            this.labelDbConnect.Location = new System.Drawing.Point(145, 12);
            this.labelDbConnect.Name = "labelDbConnect";
            this.labelDbConnect.Size = new System.Drawing.Size(182, 20);
            this.labelDbConnect.TabIndex = 1;
            this.labelDbConnect.Text = "Состояние подключения";
            // 
            // checkBoxDbConnect
            // 
            this.checkBoxDbConnect.AutoSize = true;
            this.checkBoxDbConnect.Location = new System.Drawing.Point(12, 11);
            this.checkBoxDbConnect.Name = "checkBoxDbConnect";
            this.checkBoxDbConnect.Size = new System.Drawing.Size(105, 24);
            this.checkBoxDbConnect.TabIndex = 3;
            this.checkBoxDbConnect.Text = "DbConnect";
            this.checkBoxDbConnect.UseVisualStyleBackColor = true;
            this.checkBoxDbConnect.CheckedChanged += new System.EventHandler(this.checkBoxDbConnect_CheckedChanged);
            // 
            // textBoxShowSelect
            // 
            this.textBoxShowSelect.Enabled = false;
            this.textBoxShowSelect.Location = new System.Drawing.Point(375, 12);
            this.textBoxShowSelect.Multiline = true;
            this.textBoxShowSelect.Name = "textBoxShowSelect";
            this.textBoxShowSelect.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxShowSelect.Size = new System.Drawing.Size(413, 426);
            this.textBoxShowSelect.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxShowSelect);
            this.Controls.Add(this.checkBoxDbConnect);
            this.Controls.Add(this.labelDbConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDbConnect;
        private System.Windows.Forms.CheckBox checkBoxDbConnect;
        private System.Windows.Forms.TextBox textBoxShowSelect;
    }
}

