
namespace Avto_Zapravka
{
    partial class FormBestOil
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
            System.Windows.Forms.Label labelBenzin;
            this.groupBoxZapravka = new System.Windows.Forms.GroupBox();
            this.labelValut = new System.Windows.Forms.Label();
            this.labelLitres = new System.Windows.Forms.Label();
            this.textBoxSuma = new System.Windows.Forms.TextBox();
            this.textBoxKolichestvo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonSuma = new System.Windows.Forms.RadioButton();
            this.radioButtonKolichestvo = new System.Windows.Forms.RadioButton();
            this.groupBoxKOplate = new System.Windows.Forms.GroupBox();
            this.labelKOplateValuta = new System.Windows.Forms.Label();
            this.textBoxKOplate = new System.Windows.Forms.TextBox();
            this.labelValuta = new System.Windows.Forms.Label();
            this.textBoxGasPrice = new System.Windows.Forms.TextBox();
            this.labelCena = new System.Windows.Forms.Label();
            this.comboBoxBenzin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCafe = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            labelBenzin = new System.Windows.Forms.Label();
            this.groupBoxZapravka.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxKOplate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBenzin
            // 
            labelBenzin.AutoSize = true;
            labelBenzin.Location = new System.Drawing.Point(6, 23);
            labelBenzin.Name = "labelBenzin";
            labelBenzin.Size = new System.Drawing.Size(60, 20);
            labelBenzin.TabIndex = 1;
            labelBenzin.Text = "Бензин";
            // 
            // groupBoxZapravka
            // 
            this.groupBoxZapravka.Controls.Add(this.labelValut);
            this.groupBoxZapravka.Controls.Add(this.labelLitres);
            this.groupBoxZapravka.Controls.Add(this.textBoxSuma);
            this.groupBoxZapravka.Controls.Add(this.textBoxKolichestvo);
            this.groupBoxZapravka.Controls.Add(this.panel1);
            this.groupBoxZapravka.Controls.Add(this.groupBoxKOplate);
            this.groupBoxZapravka.Controls.Add(this.labelValuta);
            this.groupBoxZapravka.Controls.Add(this.textBoxGasPrice);
            this.groupBoxZapravka.Controls.Add(this.labelCena);
            this.groupBoxZapravka.Controls.Add(labelBenzin);
            this.groupBoxZapravka.Controls.Add(this.comboBoxBenzin);
            this.groupBoxZapravka.Location = new System.Drawing.Point(12, 12);
            this.groupBoxZapravka.Name = "groupBoxZapravka";
            this.groupBoxZapravka.Size = new System.Drawing.Size(303, 341);
            this.groupBoxZapravka.TabIndex = 0;
            this.groupBoxZapravka.TabStop = false;
            this.groupBoxZapravka.Text = "Автозаправка";
            // 
            // labelValut
            // 
            this.labelValut.AutoSize = true;
            this.labelValut.Location = new System.Drawing.Point(262, 183);
            this.labelValut.Name = "labelValut";
            this.labelValut.Size = new System.Drawing.Size(36, 20);
            this.labelValut.TabIndex = 10;
            this.labelValut.Text = "грн.";
            // 
            // labelLitres
            // 
            this.labelLitres.AutoSize = true;
            this.labelLitres.Location = new System.Drawing.Point(262, 144);
            this.labelLitres.Name = "labelLitres";
            this.labelLitres.Size = new System.Drawing.Size(20, 20);
            this.labelLitres.TabIndex = 9;
            this.labelLitres.Text = "л.";
            // 
            // textBoxSuma
            // 
            this.textBoxSuma.Location = new System.Drawing.Point(141, 176);
            this.textBoxSuma.Name = "textBoxSuma";
            this.textBoxSuma.Size = new System.Drawing.Size(107, 27);
            this.textBoxSuma.TabIndex = 8;
            this.textBoxSuma.TextChanged += new System.EventHandler(this.textBoxSuma_TextChanged);
            // 
            // textBoxKolichestvo
            // 
            this.textBoxKolichestvo.Location = new System.Drawing.Point(141, 137);
            this.textBoxKolichestvo.Name = "textBoxKolichestvo";
            this.textBoxKolichestvo.Size = new System.Drawing.Size(107, 27);
            this.textBoxKolichestvo.TabIndex = 7;
            this.textBoxKolichestvo.TextChanged += new System.EventHandler(this.textBoxKolichestvo_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonSuma);
            this.panel1.Controls.Add(this.radioButtonKolichestvo);
            this.panel1.Location = new System.Drawing.Point(6, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 66);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButtonSuma
            // 
            this.radioButtonSuma.AutoSize = true;
            this.radioButtonSuma.Location = new System.Drawing.Point(6, 40);
            this.radioButtonSuma.Name = "radioButtonSuma";
            this.radioButtonSuma.Size = new System.Drawing.Size(65, 24);
            this.radioButtonSuma.TabIndex = 1;
            this.radioButtonSuma.TabStop = true;
            this.radioButtonSuma.Text = "Сума";
            this.radioButtonSuma.UseVisualStyleBackColor = true;
            this.radioButtonSuma.CheckedChanged += new System.EventHandler(this.radioButtonSuma_CheckedChanged);
            // 
            // radioButtonKolichestvo
            // 
            this.radioButtonKolichestvo.AutoSize = true;
            this.radioButtonKolichestvo.Location = new System.Drawing.Point(6, 5);
            this.radioButtonKolichestvo.Name = "radioButtonKolichestvo";
            this.radioButtonKolichestvo.Size = new System.Drawing.Size(111, 24);
            this.radioButtonKolichestvo.TabIndex = 0;
            this.radioButtonKolichestvo.TabStop = true;
            this.radioButtonKolichestvo.Text = "Количество";
            this.radioButtonKolichestvo.UseVisualStyleBackColor = true;
            this.radioButtonKolichestvo.CheckedChanged += new System.EventHandler(this.radioButtonKolichestvo_CheckedChanged);
            // 
            // groupBoxKOplate
            // 
            this.groupBoxKOplate.Controls.Add(this.labelKOplateValuta);
            this.groupBoxKOplate.Controls.Add(this.textBoxKOplate);
            this.groupBoxKOplate.Location = new System.Drawing.Point(6, 209);
            this.groupBoxKOplate.Name = "groupBoxKOplate";
            this.groupBoxKOplate.Size = new System.Drawing.Size(242, 125);
            this.groupBoxKOplate.TabIndex = 5;
            this.groupBoxKOplate.TabStop = false;
            this.groupBoxKOplate.Text = "К оплате";
            this.groupBoxKOplate.Enter += new System.EventHandler(this.groupBoxKOplate_Enter);
            // 
            // labelKOplateValuta
            // 
            this.labelKOplateValuta.AutoSize = true;
            this.labelKOplateValuta.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKOplateValuta.Location = new System.Drawing.Point(175, 82);
            this.labelKOplateValuta.Name = "labelKOplateValuta";
            this.labelKOplateValuta.Size = new System.Drawing.Size(65, 37);
            this.labelKOplateValuta.TabIndex = 4;
            this.labelKOplateValuta.Text = "грн.";
            // 
            // textBoxKOplate
            // 
            this.textBoxKOplate.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKOplate.Location = new System.Drawing.Point(6, 58);
            this.textBoxKOplate.Name = "textBoxKOplate";
            this.textBoxKOplate.Size = new System.Drawing.Size(163, 61);
            this.textBoxKOplate.TabIndex = 3;
            // 
            // labelValuta
            // 
            this.labelValuta.AutoSize = true;
            this.labelValuta.Location = new System.Drawing.Point(159, 58);
            this.labelValuta.Name = "labelValuta";
            this.labelValuta.Size = new System.Drawing.Size(37, 20);
            this.labelValuta.TabIndex = 4;
            this.labelValuta.Text = "Грн.";
            // 
            // textBoxGasPrice
            // 
            this.textBoxGasPrice.Location = new System.Drawing.Point(86, 55);
            this.textBoxGasPrice.Name = "textBoxGasPrice";
            this.textBoxGasPrice.Size = new System.Drawing.Size(67, 27);
            this.textBoxGasPrice.TabIndex = 3;
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Location = new System.Drawing.Point(6, 55);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(45, 20);
            this.labelCena.TabIndex = 2;
            this.labelCena.Text = "Цена";
            // 
            // comboBoxBenzin
            // 
            this.comboBoxBenzin.FormattingEnabled = true;
            this.comboBoxBenzin.Location = new System.Drawing.Point(86, 20);
            this.comboBoxBenzin.Name = "comboBoxBenzin";
            this.comboBoxBenzin.Size = new System.Drawing.Size(67, 28);
            this.comboBoxBenzin.TabIndex = 0;
            this.comboBoxBenzin.SelectedIndexChanged += new System.EventHandler(this.comboBoxBebzin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-215, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panelCafe
            // 
            this.panelCafe.Location = new System.Drawing.Point(16, 23);
            this.panelCafe.Name = "panelCafe";
            this.panelCafe.Size = new System.Drawing.Size(245, 298);
            this.panelCafe.TabIndex = 8;
            this.panelCafe.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCafe_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelCafe);
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 341);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // FormBestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxZapravka);
            this.Name = "FormBestOil";
            this.RightToLeftLayout = true;
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.FormBestOil_Load);
            this.groupBoxZapravka.ResumeLayout(false);
            this.groupBoxZapravka.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxKOplate.ResumeLayout(false);
            this.groupBoxKOplate.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxZapravka;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.Label labelBenzin;
        private System.Windows.Forms.ComboBox comboBoxBenzin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonSuma;
        private System.Windows.Forms.RadioButton radioButtonKolichestvo;
        private System.Windows.Forms.GroupBox groupBoxKOplate;
        private System.Windows.Forms.Label labelValuta;
        private System.Windows.Forms.TextBox textBoxGasPrice;
        private System.Windows.Forms.Label labelValut;
        private System.Windows.Forms.Label labelLitres;
        private System.Windows.Forms.TextBox textBoxSuma;
        private System.Windows.Forms.TextBox textBoxKolichestvo;
        private System.Windows.Forms.Label labelKOplateValuta;
        private System.Windows.Forms.TextBox textBoxKOplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCafe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

