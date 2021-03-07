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
        public static decimal AllSumaCafe { get; set; } = default;
        public CafeInfo Cafe_Info { get; set; } = default;
        public decimal CafePrice { get; set; } = default;
        /*       public CafeItem()
               {
                   InitializeComponent();
                   CafePrice = 0;
                   // Cafe_Info = new CafeInfo("hot-dog", 4.50m);
                   SetCafeItems();
               }
       */

        public CafeItem(CafeInfo cafeInfo)
        {
            InitializeComponent();
            Cafe_Info = cafeInfo;
            CafePrice = 0;
            SetCafeItems();
           // ReCalculateItem();

        }
        public void ClearsCafeItem()
        {
            AllSumaCafe = default;
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

            ReCalculateItem();
            Form.ActiveForm.Text = $"All Suma Cafe {Cafe_Info.Suma} ";        
        }
        public void ReCalculateItem()
        {
            AllSumaCafe -= Cafe_Info.Suma;
            Cafe_Info.Count = (int)numericUpDown1.Value;
            Cafe_Info.Suma = Cafe_Info.Price * Cafe_Info.Count;
            AllSumaCafe += Cafe_Info.Suma;

           
            Program.MyForma.ReCalculateCafe();
        }

    }
}
