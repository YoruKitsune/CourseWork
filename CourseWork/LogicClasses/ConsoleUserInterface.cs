using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.LogicClasses
{
    internal class ConsoleUserInterface
    {
        private static currentScreen _curScreen;
        
        public ConsoleUserInterface() { _initScreen();  }

      
        private static void _initScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Добро пожаловать в автоматизированную систему ЗАГСа.");
            _keyPressAwait();
            _curScreen += new currentScreen(_initScreen);
        }
        private static void _changeTextColor(ConsoleColor color) => Console.ForegroundColor = color;
        private static void _keyPressAwait()
        {
            Console.WriteLine("Для продолжения нажмите любую кнопку... ");
            Console.ReadKey();
        }
        public static void ErrorMsg(string msg)
        { 
            _changeTextColor(ConsoleColor.Red);
            Console.WriteLine(msg);
            _changeTextColor(ConsoleColor.Green);
            _keyPressAwait();
            _curScreen.Invoke();
        }
        private static object _getInformationFromConsole(string output)
        {
            Console.WriteLine($"Введите {output}: ");
            return Console.ReadLine();
        }
        private static void _createCerificateScreen()
        {

        }
        private static void _createPersonScreen()
        {

        }
        delegate void currentScreen();
    }
}
