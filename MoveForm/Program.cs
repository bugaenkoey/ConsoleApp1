using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Задание 4:
Написать приложение, обладающее следующей функциональностью:
 При нажатии клавиши <Enter> главное окно позиционируется в
левый верхний угол экрана с размерами (300х300) и начинает
перемещаться по периметру экрана с определённой скоростью;
 При нажатии клавиши <Esc> перемещение окна прекращается.
 */
namespace MoveForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

          

        }
    }
}
