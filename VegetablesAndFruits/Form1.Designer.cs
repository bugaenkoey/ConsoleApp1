
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
            this.components = new System.ComponentModel.Container();
            this.labelDbConnect = new System.Windows.Forms.Label();
            this.checkBoxDbConnect = new System.Windows.Forms.CheckBox();
            this.textBoxShowSelect = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDbConnect
            // 
            this.labelDbConnect.AutoSize = true;
            this.labelDbConnect.Location = new System.Drawing.Point(311, 12);
            this.labelDbConnect.Name = "labelDbConnect";
            this.labelDbConnect.Size = new System.Drawing.Size(133, 20);
            this.labelDbConnect.TabIndex = 1;
            this.labelDbConnect.Text = "Нет подключения";
            // 
            // checkBoxDbConnect
            // 
            this.checkBoxDbConnect.AutoSize = true;
            this.checkBoxDbConnect.Location = new System.Drawing.Point(12, 11);
            this.checkBoxDbConnect.Name = "checkBoxDbConnect";
            this.checkBoxDbConnect.Size = new System.Drawing.Size(226, 24);
            this.checkBoxDbConnect.TabIndex = 3;
            this.checkBoxDbConnect.Text = "Соединится с базой данных";
            this.checkBoxDbConnect.UseVisualStyleBackColor = true;
            this.checkBoxDbConnect.CheckedChanged += new System.EventHandler(this.checkBoxDbConnect_CheckedChanged);
            // 
            // textBoxShowSelect
            // 
            this.textBoxShowSelect.Enabled = false;
            this.textBoxShowSelect.Location = new System.Drawing.Point(12, 90);
            this.textBoxShowSelect.Multiline = true;
            this.textBoxShowSelect.Name = "textBoxShowSelect";
            this.textBoxShowSelect.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxShowSelect.Size = new System.Drawing.Size(776, 50);
            this.textBoxShowSelect.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(776, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(772, 478);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 670);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxShowSelect);
            this.Controls.Add(this.checkBoxDbConnect);
            this.Controls.Add(this.labelDbConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDbConnect;
        private System.Windows.Forms.CheckBox checkBoxDbConnect;
        private System.Windows.Forms.TextBox textBoxShowSelect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

