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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)ConsoleKey.Enter == e.KeyChar)
            {
                int sizeFrom = 300;
                Width = sizeFrom;
                Height = sizeFrom;
                int spead = 10;
                moveMyForm(spead);

            }

            if ((char)ConsoleKey.Escape == e.KeyChar)
            {
                //"Должна быть обработка нажатия Esc"
                MessageBox.Show(
         "Здесь должна быть обработка нажатия Esc",
         "Нажата кнопка Esc",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
                //  return;
            }
            Text = $"{Enum.GetName(typeof(ConsoleKey), e.KeyChar)}";

        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {

        }

        public void moveMyForm(int spead)
        {
            Left = 0;
            Top = 0;
            for (; Left < SystemInformation.PrimaryMonitorSize.Width - Width; Left += spead) ;
            for (; Top < SystemInformation.PrimaryMonitorSize.Height - Height; Top += spead) ;
            for (; Left > 0; Left -= spead) ;
            for (; Top > 0; Top -= spead) ;
        }
    }
}
