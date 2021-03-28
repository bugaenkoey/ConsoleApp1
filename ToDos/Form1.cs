using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDos
{
    public partial class Form1 : Form
    {
        public Button button;
        public TextBox textBox;
        public ListBox listBox;

        public Form1()
        {
            InitializeComponent();
            Click += new EventHandler(ClickHandler);
        }
        //закрепляем обработчик события

        public void ClickHandler(Object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Click in Form", "KU - KU", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);

            MessageBox.Show($"{dialogResult}");
        }
   
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 3;
            progressBar1.Step = 1;
           


            if (listBox1.Items.Count >0)
            {
                progressBar1.PerformStep();
                progressBar1.Value.ToString();
                this.Update();

                listBox2.Items.Add(listBox1.Items[0]);
                listBox1.Items.Remove((string)listBox1.Items[0]);
            }
      /*      foreach (var item in listBox1.Items)
            {
                textBox1.Text += $"\n {item}";
            }
*/
        }
    }
}
