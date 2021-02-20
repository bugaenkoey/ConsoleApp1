using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Avto_Zapravka
{
    public partial class CafeItem : UserControl
    {
        public CafeInfo Cafe_Info { get; set; }
        public decimal CafePrice { get; set; }
        public CafeItem()
        {
            InitializeComponent();
            CafePrice = 0;
            // Cafe_Info = new CafeInfo("hot-dog", 4.50m);
            SetCafeItems();
        }


        public CafeItem(CafeInfo cafeInfo)
        {
            InitializeComponent();
            Cafe_Info = cafeInfo;
            CafePrice = 0;
            SetCafeItems();

        }
        private void SetCafeItems()
        {
            textBox1.Text = Cafe_Info.Price.ToString();
            numericUpDown1.Value = Cafe_Info.Count;
            checkBox1.Text = Cafe_Info.Product;
        }
        private void CafeItem_Load(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = checkBox1.Checked;
            numericUpDown1.Value = 0;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Cafe_Info.Count = (int)numericUpDown1.Value;
            ReCalculateCafe();
            MessageBox.Show($"suma {Cafe_Info.TotalPrice} ");

        }
        public void ReCalculateCafe()
        {
            Cafe_Info.TotalPrice = Cafe_Info.Price * Cafe_Info.Count;
            

        }
    }
}
