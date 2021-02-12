using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleBorders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //где произошел щелчок мышью: внутри прямоугольника, снаружи или на границе прямоугольника
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string str = string.Empty;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    str = LocationClick(e.Location);
                    break;

                case MouseButtons.Right:
                    str = $"размер клиентской области окна" +
                        $"{ClientSize.Width}* {ClientSize.Height}, {Size.Width} * {Size.Height}";
                    break;

                default:
                    break;
            }
            Text = str;

        }

        private string LocationClick(Point location)
        {
            int indent = 10;
            int x = location.X;
            int y = location.Y;
            string str = string.Empty;
            if (x > indent && x < ClientSize.Width - indent && y > indent && y < ClientSize.Height - indent) str = "внутри прямоугольника";
            if ((x < indent || x > ClientSize.Width - indent )||( y < indent || y > ClientSize.Height - indent)) str = "снаружи прямоугольника";
            if (x == indent || x == ClientSize.Width - indent || y == indent || y == ClientSize.Height - indent) str = "на границе прямоугольника";

            return str += $" X {x}, Y {y}";
        }


    }
}
