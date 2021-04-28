
namespace ProductStorage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxOnDB = new System.Windows.Forms.CheckBox();
            this.comboBoxQueries = new System.Windows.Forms.ComboBox();
            this.DatabaseState = new System.Windows.Forms.Label();
            this.labelShowe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(775, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkBoxOnDB
            // 
            this.checkBoxOnDB.AutoSize = true;
            this.checkBoxOnDB.Location = new System.Drawing.Point(13, 13);
            this.checkBoxOnDB.Name = "checkBoxOnDB";
            this.checkBoxOnDB.Size = new System.Drawing.Size(208, 24);
            this.checkBoxOnDB.TabIndex = 1;
            this.checkBoxOnDB.Text = "Подключить базу данных";
            this.checkBoxOnDB.UseVisualStyleBackColor = true;
            this.checkBoxOnDB.CheckedChanged += new System.EventHandler(this.checkBoxOnDB_CheckedChanged);
            // 
            // comboBoxQueries
            // 
            this.comboBoxQueries.FormattingEnabled = true;
            this.comboBoxQueries.Location = new System.Drawing.Point(13, 43);
            this.comboBoxQueries.Name = "comboBoxQueries";
            this.comboBoxQueries.Size = new System.Drawing.Size(775, 28);
            this.comboBoxQueries.TabIndex = 2;
            this.comboBoxQueries.SelectedIndexChanged += new System.EventHandler(this.comboBoxQueries_SelectedIndexChanged);
            // 
            // DatabaseState
            // 
            this.DatabaseState.AutoSize = true;
            this.DatabaseState.Location = new System.Drawing.Point(304, 14);
            this.DatabaseState.Name = "DatabaseState";
            this.DatabaseState.Size = new System.Drawing.Size(176, 20);
            this.DatabaseState.TabIndex = 3;
            this.DatabaseState.Text = "База данных отключена";
            // 
            // labelShowe
            // 
            this.labelShowe.AutoSize = true;
            this.labelShowe.Location = new System.Drawing.Point(580, 9);
            this.labelShowe.Name = "labelShowe";
            this.labelShowe.Size = new System.Drawing.Size(42, 20);
            this.labelShowe.TabIndex = 4;
            this.labelShowe.Text = "label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.labelShowe);
            this.Controls.Add(this.DatabaseState);
            this.Controls.Add(this.comboBoxQueries);
            this.Controls.Add(this.checkBoxOnDB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxOnDB;
        private System.Windows.Forms.ComboBox comboBoxQueries;
        private System.Windows.Forms.Label DatabaseState;
        private System.Windows.Forms.Label labelShowe;
    }
}

