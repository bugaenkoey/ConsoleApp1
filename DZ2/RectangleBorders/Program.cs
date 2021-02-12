using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Задание 2:
Предположим, что существует прямоугольник, границы которого на 10
пикселей отстоят от границ клиентской области окна. Необходимо при
нажатии левой кнопки мыши выводить в заголовок окна сообщение о
том, где произошел щелчок мышью: внутри прямоугольника, снаружи
или на границе прямоугольника. При нажатии правой кнопки мыши
необходимо выводить в заголовок окна информацию о размере
клиентской области окна (ширина и высота клиентской области окна).
 */
namespace RectangleBorders
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
