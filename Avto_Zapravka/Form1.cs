using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Avto_Zapravka
{
    public partial class FormBestOil : Form
    {
        public List<GasInfo> gasInfos;
        public List<CafeInfo> cafeInfos;
        public decimal SumaGas { get; set; }
        public decimal Quantity { get; set; }
        public decimal SumaCafe { get; set; }
        public static decimal totalPrice = default;
        public decimal ZaSmenuPrice = default;
        public FormBestOil()
        {
            InitializeComponent();
            gasInfos = GasInfos();
            cafeInfos = CafeInfos();
            comboBoxBenzin.Items.AddRange(gasInfos.ToArray());
            ClearsForm();
        }
        public void ClearsForm()
        {
            SumaGas = Quantity = SumaCafe = totalPrice = default;
            textBoxGasPrice.Enabled = false;
            textBoxKolichestvo.Enabled = false;
            textBoxSuma.Enabled = false;
            textBoxGasPrice.Text = "";
            textBoxKolichestvo.Text = "";
            textBoxSuma.Text = "";
            textBoxGasPrice.Text = "";
            textBoxKOplate.Text = textBoxSuma.Text = SumaGas.ToString();
            //label3.Text = "";
           // label3.Text = totalPrice.ToString(CultureInfo.InvariantCulture);

            panelCafe.Controls.Clear();
            SetCafeItems();
            ReCalculateCafe();
            // ReCalculateItem();

        }

        public List<GasInfo> GasInfos()
        {
            return new List<GasInfo>
            {
                new GasInfo("A-76", 21.10m),
                 new GasInfo("A-80", 22.20m),
                  new GasInfo("A-92", 23.30m),
                   new GasInfo("A-95", 24.40m)
            };
        }

        public List<CafeInfo> CafeInfos()
        {
            return new List<CafeInfo>
            {
                new CafeInfo("Хот-дог", 5.10m),
                new CafeInfo("Гамбургер", 6.20m),
                new CafeInfo("Картопля фрі", 7.30m),
                new CafeInfo("Кока-кола", 8.40m)

            };
        }

        public void SetCafeItems()
        {
            foreach (var item in cafeInfos)
            {
                var cafeItem = new CafeItem(item);
                //item.Count = default;
                cafeItem.Dock = DockStyle.Top;
                panelCafe.Controls.Add(cafeItem);

            }
            groupBoxCafeKOplate.Dock = DockStyle.Bottom;

            panelCafe.Controls.Add(groupBoxCafeKOplate);
        }
        private void comboBoxBebzin_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = comboBoxBenzin.SelectedIndex;
            var prise = gasInfos[index].Price;
            textBoxGasPrice.Text = prise.ToString();
        }

        private void radioButtonKolichestvo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                textBoxKolichestvo.Enabled = true;
                textBoxSuma.Enabled = false;
            }
        }



        private void radioButtonSuma_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                textBoxKolichestvo.Enabled = false;
                textBoxSuma.Enabled = true;
            }
        }

        private void textBoxKolichestvo_TextChanged(object sender, EventArgs e)
        {

            if (decimal.TryParse(textBoxGasPrice.Text, out decimal price)
                 && decimal.TryParse(textBoxKolichestvo.Text, out decimal quantity))
            {
                SumaGas = Math.Round(price * quantity, 2);

                textBoxSuma.Text = "";
                textBoxKOplate.Text = SumaGas.ToString();

                groupBoxKOplate.Text = "К оплате";
                labelKOplateValuta.Text = "Грн.";
            }
            else textBoxKOplate.Text = string.Empty;

        }

        private void textBoxSuma_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxGasPrice.Text, out decimal price)
                && decimal.TryParse(textBoxSuma.Text, out decimal suma))
            {
                SumaGas = suma;
                Quantity = Math.Round(suma / price, 2);

                textBoxKolichestvo.Text = "";
                textBoxKOplate.Text = Quantity.ToString();
                groupBoxKOplate.Text = "Количество";
                labelKOplateValuta.Text = "Л.";
            }
            else textBoxKOplate.Text = string.Empty;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            totalPrice = 0;
            ReCalculateCafe();
            totalPrice += SumaCafe;
            totalPrice += SumaGas;
            labelTotalPrice.Text = totalPrice.ToString(CultureInfo.InvariantCulture);

            timer1.Enabled = true;

        }
        public void ReCalculateCafe()
        {
            SumaCafe = CafeItem.AllSumaCafe;
            textBoxCafeKOplate.Text = SumaCafe.ToString(CultureInfo.InvariantCulture);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DialogResult dialogResult = MessageBox.Show("Следующий клиент", "Обслужить следующего клиента?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                ZaSmenuPrice += totalPrice;
                ClearsForm();
            }
            if (dialogResult == DialogResult.No)
            {
                timer1.Enabled = true;
            }
        }
        private void FormBestOil_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Общая сумма выручки за данный день. { ZaSmenuPrice}", "Закончился рабочий день", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void groupBoxKOplate_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormBestOil_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cafeItem1_Load(object sender, EventArgs e)
        {

        }

        private void cafeItem2_Load(object sender, EventArgs e)
        {

        }

        private void cafeItem2_Load_1(object sender, EventArgs e)
        {

        }

        private void panelCafe_Paint(object sender, PaintEventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
