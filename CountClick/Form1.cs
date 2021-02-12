using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountClick
{
    public partial class Form1 : Form
    {
        public int n = 0;
        public int mc = 0;
        public int MouseButtonsLeft = 0;
        public int MouseButtonsMiddle = 0;
        public int MouseButtonsRight = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Count Click Mouse Buttons";
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    ++MouseButtonsLeft;
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    ++MouseButtonsRight;
                    break;
                case MouseButtons.Middle:
                    ++MouseButtonsMiddle;
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
            Text = $"{e.Button} MouseClick Left {MouseButtonsLeft} Middle {MouseButtonsMiddle} Right {MouseButtonsRight} " +
                $"Total {MouseButtonsLeft + MouseButtonsMiddle + MouseButtonsRight}";

        }
    }
}
