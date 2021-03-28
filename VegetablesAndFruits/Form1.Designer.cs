
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxValue2 = new System.Windows.Forms.TextBox();
            this.textBoxValue1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxParam1 = new System.Windows.Forms.ComboBox();
            this.comboBoxParam2 = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.textBoxShowSelect.Size = new System.Drawing.Size(776, 134);
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
            // textBoxValue2
            // 
            this.textBoxValue2.Location = new System.Drawing.Point(671, 9);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(117, 27);
            this.textBoxValue2.TabIndex = 6;
            this.textBoxValue2.Visible = false;
            this.textBoxValue2.TextChanged += new System.EventHandler(this.textBoxValue2_TextChanged);
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Location = new System.Drawing.Point(548, 9);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(117, 27);
            this.textBoxValue1.TabIndex = 7;
            this.textBoxValue1.Visible = false;
            this.textBoxValue1.TextChanged += new System.EventHandler(this.textBoxValue1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Type,
            this.color,
            this.cal});
            this.dataGridView1.Location = new System.Drawing.Point(16, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(772, 162);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBoxParam1
            // 
            this.comboBoxParam1.FormattingEnabled = true;
            this.comboBoxParam1.Location = new System.Drawing.Point(33, 416);
            this.comboBoxParam1.Name = "comboBoxParam1";
            this.comboBoxParam1.Size = new System.Drawing.Size(151, 28);
            this.comboBoxParam1.TabIndex = 9;
            // 
            // comboBoxParam2
            // 
            this.comboBoxParam2.FormattingEnabled = true;
            this.comboBoxParam2.Location = new System.Drawing.Point(254, 416);
            this.comboBoxParam2.Name = "comboBoxParam2";
            this.comboBoxParam2.Size = new System.Drawing.Size(151, 28);
            this.comboBoxParam2.TabIndex = 10;
            // 
            // id
            // 
            this.id.HeaderText = "id ";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.MinimumWidth = 6;
            this.color.Name = "color";
            this.color.Width = 125;
            // 
            // cal
            // 
            this.cal.HeaderText = "Cal";
            this.cal.MinimumWidth = 6;
            this.cal.Name = "cal";
            this.cal.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 534);
            this.Controls.Add(this.comboBoxParam2);
            this.Controls.Add(this.comboBoxParam1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxValue1);
            this.Controls.Add(this.textBoxValue2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxShowSelect);
            this.Controls.Add(this.checkBoxDbConnect);
            this.Controls.Add(this.labelDbConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDbConnect;
        private System.Windows.Forms.CheckBox checkBoxDbConnect;
        private System.Windows.Forms.TextBox textBoxShowSelect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxValue2;
        private System.Windows.Forms.TextBox textBoxValue1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBoxParam1;
        private System.Windows.Forms.ComboBox comboBoxParam2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn cal;
    }
}

