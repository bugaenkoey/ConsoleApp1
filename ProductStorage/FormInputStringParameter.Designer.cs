
namespace ProductStorage
{
    partial class FormInputStringParameter
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelInputParameter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 46);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(282, 27);
            this.textBox.TabIndex = 0;
            // 
            // labelInputParameter
            // 
            this.labelInputParameter.AutoSize = true;
            this.labelInputParameter.Location = new System.Drawing.Point(21, 10);
            this.labelInputParameter.Name = "labelInputParameter";
            this.labelInputParameter.Size = new System.Drawing.Size(110, 20);
            this.labelInputParameter.TabIndex = 2;
            this.labelInputParameter.Text = "InputParameter";
            // 
            // FormInputStringParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 103);
            this.Controls.Add(this.labelInputParameter);
            this.Controls.Add(this.textBox);
            this.Name = "FormInputStringParameter";
            this.Text = "FormInputParameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelInputParameter;
    }
}