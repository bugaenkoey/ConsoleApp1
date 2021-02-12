using System;
using System.Windows.Forms;

namespace MoveForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int stepLeft = 50;
        int stepTop = 50;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)ConsoleKey.Enter == e.KeyChar)
            {
                int sizeFrom = 300;
                Left = 0;
                Top = 0;
                Width = sizeFrom;
                Height = sizeFrom;
                moveMyForm();
/*
                for (int i = 0; i < 800; i++)
                {
                    Left++;
                }
                for (int i = 0; i < 400; i++)
                {
                    Top++;
                }
                for (int i = 0; i < 800; i++)
                {
                    Left--;
                }
                for (int i = 0; i < 400; i++)
                {
                    Top--;
                }
*/

                /*
                                if (Location.X > 800 || Location.X < 10)
                                {
                                    stepLeft *= -1;
                                }

                                if (Location.Y > 400 || Location.Y < 10)
                                {
                                    stepTop *= -1;
                                }

                                Left += stepLeft;
                                Top += stepTop;
                */
            }


            if ((char)ConsoleKey.Escape == e.KeyChar)
            {
              //  return;
            }
                Text = $"{Enum.GetName(typeof(ConsoleKey), e.KeyChar)}";
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {

        }

        public void moveMyForm()
        {
            for (int i = 0; i < 800; i++)
            {
                Left++;
            }
            for (int i = 0; i < 400; i++)
            {
                Top++;
            }
            for (int i = 0; i < 800; i++)
            {
                Left--;
            }
            for (int i = 0; i < 400; i++)
            {
                Top--;
            }
        }
    }
}
