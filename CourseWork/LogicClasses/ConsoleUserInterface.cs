using CourseWork.DocumentsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.LogicClasses
{
    internal class ConsoleUserInterface
    {
        public static currentScreen CurScreen;
        private static ControllerClass _controllerClass;
        public ConsoleUserInterface()
        {
            _controllerClass = new ControllerClass(this);
            _initScreen();
            
        }


        private static void _initScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Добро пожаловать в автоматизированную систему ЗАГСа.");   
            CurScreen += new currentScreen(_chooseAction);
            _keyPressAwait();
        }
        private static void _changeTextColor(ConsoleColor color) => Console.ForegroundColor = color;
        private static void _keyPressAwait()
        {
            Console.WriteLine("Для продолжения нажмите любую кнопку... ");
            Console.ReadKey();
            CurScreen.Invoke();
        }
        public void Return()
        {
            CurScreen = new currentScreen(_chooseAction);
            CurScreen.Invoke();
        }
        private static void _chooseAction()
        {
            Console.Clear();
            PrintMsg("Что вы хотите сделать?\n" +
                "1 — Создать карточку человека\n" +
                "2 — Создать свидетельство\n" +
                "3 — Найти карточку человека\n" +
                "4 — Найти свидетельство");
            int action = Int32.Parse((string)GetInformationFromConsole("номер действия", false));
            switch (action)
            {
                case 1:
                    CurScreen = new currentScreen(_createPersonScreen);
                    CurScreen.Invoke();
                    break;
                case 2:
                    CurScreen = new currentScreen(_createCerificateScreen);
                    CurScreen.Invoke();
                    break;
                case 3:
                    CurScreen = new currentScreen(_findPersonScreen);
                    CurScreen.Invoke();
                    break;
                case 4:
                    CurScreen = new currentScreen(_findCerificateScreen);
                    CurScreen.Invoke();
                    break;
                default:
                    ErrorMsg("Неверное действие!", true);
                    break;

            }
        }
        public void ErrorMsg(string msg)
        {
            Console.Clear();
            _changeTextColor(ConsoleColor.Red);
            Console.WriteLine(msg);
            _changeTextColor(ConsoleColor.Green);
            CurScreen = new currentScreen(_chooseAction);
            _keyPressAwait();
        }
        public static void ErrorMsg(string msg, bool clear)
        {
            if(clear) Console.Clear();
            _changeTextColor(ConsoleColor.Red);
            Console.WriteLine(msg);
            _changeTextColor(ConsoleColor.Green);
            CurScreen = new currentScreen(_chooseAction);
            _keyPressAwait();
        }
        public static object GetInformationFromConsole(string output, bool flag)
        {
            if(flag) Console.Clear();

            Console.WriteLine($"Введите {output}: ");
            return Console.ReadLine();
        }
        public object GetInformationFromConsole(string output)
        {
            Console.Clear();
            Console.WriteLine($"Введите {output}: ");
            return Console.ReadLine();
        }
        private static void _createCerificateScreen()
        {
            Console.Clear();
            PrintMsg("Какой сертификат вы хотите создать?\n" +
                "1 — Создать свидетельство о рождении\n" +
                "2 — Создать свидетельство о смерти\n" +
                "3 — Создать свидетельство об усыновлении\n" +
                "4 — Создать свидетельство о браке\n" +
                "5 — Создать свидетельство о расторжении брака\n" +
                "6 — Создать свидетельство о смене имени\n" +
                "7 — Создать свидетельство об установлении отцовства\n");
            int action = Int32.Parse((string)GetInformationFromConsole("номер действия", false));
            switch (action)
            {
                case 1:
                    _controllerClass.InitialCreateCertificate(new CertificateOfBirth());
                    break;
                case 2:
                    _controllerClass.InitialCreateCertificate(new CertificateOfDeath());
                    break;
                case 3:
                    _controllerClass.InitialCreateCertificate(new CertificateOfAdoption());
                    break;
                case 4:
                    _controllerClass.InitialCreateCertificate(new CertificateOfMarriage());
                    break;
                case 5:
                    _controllerClass.InitialCreateCertificate(new CertificateOfDivorce());
                    break;
                case 6:
                    _controllerClass.InitialCreateCertificate(new CertificateOfChangeName());
                    break;
                case 7:
                    _controllerClass.InitialCreateCertificate(new CertificateOfEstablishingPaternity());
                    break;
                default:
                    ErrorMsg("Неверное действие!", true);
                    break;

            }
        }
        private static void _createPersonScreen()
        {
            _controllerClass.InitialCreatePerson();
        }
        private static void _findPersonScreen()
        {
            _controllerClass.FindPerson();
        }
        private static void _findCerificateScreen()
        {
            _controllerClass.FindCertificate();
        }
        public static void PrintMsg(string msg)
        {
            Console.WriteLine(msg);
        }
        public void PrintMsg(string msg, bool clearConsole)
        {
            if (clearConsole) Console.Clear();
            Console.WriteLine(msg);
        }
        public void AwaitButton()
        {
            Console.WriteLine("Для продолжения нажмите любую кнопку... ");
            Console.ReadKey();
        }
        public delegate void currentScreen();

    }
}
