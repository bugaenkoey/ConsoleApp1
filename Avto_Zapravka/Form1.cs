using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avto_Zapravka
{
    public partial class FormBestOil : Form
    {
        public List<GasInfo> gasInfos;
        public List<CafeInfo> cafeInfos;
        public FormBestOil()
        {
            InitializeComponent();
            gasInfos = GasInfos();
            cafeInfos = CafeInfos();
            comboBoxBenzin.Items.AddRange(gasInfos.ToArray());
            textBoxGasPrice.Enabled = false;
            textBoxKolichestvo.Enabled = false;
            textBoxSuma.Enabled = false;

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
                new CafeInfo("Хот-дог", 4.00m),
                 new CafeInfo("Гамбургер", 5.40m),
                  new CafeInfo("Картопля фрі", 7.20m),
                   new CafeInfo("Кока-кола", 4.40m)
            };
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
                //  MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonSuma_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                textBoxKolichestvo.Enabled = false;
                textBoxSuma.Enabled = true;
                //  MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void textBoxKolichestvo_TextChanged(object sender, EventArgs e)
        {
            /*int.TryParse(Console.ReadLine(), out int result )
             */

            if (decimal.TryParse(textBoxGasPrice.Text, out decimal price)
                 && decimal.TryParse(textBoxKolichestvo.Text, out decimal quantity))
            {
                textBoxKOplate.Text = textBoxSuma.Text = (price * quantity).ToString();

            }
            else textBoxKOplate.Text = string.Empty;
            //   var price = Convert.ToDecimal(textBoxGasPrice.Text);
            //  var quantity = Convert.ToDecimal(textBoxKolichestvo.Text);
            //  textBoxKOplate.Text = textBoxSuma.Text = (price * quantity).ToString();
        }

        private void textBoxSuma_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxGasPrice.Text, out decimal price)
                && decimal.TryParse(textBoxSuma.Text, out decimal suma))
            {
                textBoxKOplate.Text = textBoxKolichestvo.Text = (suma / price).ToString();
                //   textBoxKOplate.Text = suma.ToString();
            }
            else textBoxKOplate.Text = string.Empty;
            //    var price = Convert.ToDecimal(textBoxGasPrice.Text);
            //  var suma = Convert.ToDecimal(textBoxSuma.Text);
            //  textBoxKolichestvo.Text = (suma / price).ToString();
            //   textBoxKOplate.Text = suma.ToString();
        }

        private void groupBoxKOplate_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
