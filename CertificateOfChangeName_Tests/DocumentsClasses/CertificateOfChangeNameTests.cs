using System; // Импорт пространства имен System
using CourseWork.DocumentsClasses; // Импорт пространства имен CourseWork.DocumentsClasses
using Microsoft.VisualStudio.TestTools.UnitTesting; // Импорт пространства имен Microsoft.VisualStudio.TestTools.UnitTesting

namespace CertificateOfChangeName_Tests.DocumentsClasses // Объявление пространства имен CertificateOfChangeName_Tests.DocumentsClasses
{
    [TestClass] // Атрибут указывает, что класс содержит методы тестирования
    public class CertificateOfChangeNameTests // Объявление класса CertificateOfChangeNameTests
    {
        private CertificateOfChangeName _testClass; // Приватное поле для хранения экземпляра CertificateOfChangeName
        private int _series; // Приватное поле для серии
        private int _number; // Приватное поле для номера
        private DateTime _issueDate; // Приватное поле для даты выдачи
        private string _issuePlace; // Приватное поле для места выдачи
        private DateTime _actDate; // Приватное поле для даты акта
        private int _actNumber; // Приватное поле для номера акта
        private string _newName; // Приватное поле для нового имени
        private string _newSurname; // Приватное поле для новой фамилии
        private string _newPatronymic; // Приватное поле для нового отчества

        [TestInitialize] // Атрибут для метода, который выполняется перед каждым методом теста
        public void SetUp() // Метод для установки начальных значений
        {
            _series = 1021; // Установка значения для серии
            _number = 178242; // Установка значения для номера
            _issueDate = DateTime.UtcNow; // Установка текущего времени для даты выдачи
            _issuePlace = "Москва"; // Установка значения для места выдачи
            _actDate = DateTime.UtcNow; // Установка текущего времени для даты акта
            _actNumber = 18820; // Установка значения для номера акта
            _newName = "Игорь"; // Установка значения для нового имени
            _newSurname = "Игорев"; // Установка значения для новой фамилии
            _newPatronymic = "Игоревич"; // Установка значения для нового отчества
            _testClass = new CertificateOfChangeName(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _newName, _newSurname, _newPatronymic); // Создание экземпляра CertificateOfChangeName
        }

        [TestMethod] // Атрибут для метода, который является тестовым случаем
        public void CanConstruct() // Метод для проверки создания объекта
        {
            SetUp(); // Вызов SetUp

            // Действие
            var instance = new CertificateOfChangeName(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _newName, _newSurname, _newPatronymic); // Создание объекта

            // Утверждение
            Assert.IsNotNull(instance); // Проверка на не пустоту

            // Действие
            instance = new CertificateOfChangeName(); // Создание нового объекта

            // Утверждение
            Assert.IsNotNull(instance); // Проверка на не пустоту
        }

       

        [TestMethod] // Атрибут для метода, который является тестовым случаем
        public void NewNameIsInitializedCorrectly() // Метод для проверки правильной инициализации нового имени
        {
            SetUp(); // Вызов SetUp

            Assert.AreEqual(_newName, _testClass.NewName); // Проверка на правильную инициализацию нового имени
        }

        [TestMethod] // Атрибут для метода, который является тестовым случаем
        public void NewSurnameIsInitializedCorrectly() // Метод для проверки правильной инициализации новой фамилии
        {
            SetUp(); // Вызов SetUp

            Assert.AreEqual(_newSurname, _testClass.NewSurname); // Проверка на правильную инициализацию новой фамилии
        }

        [TestMethod] // Атрибут для метода, который является тестовым случаем
        public void NewPatronymicIsInitializedCorrectly() // Метод для проверки правильной инициализации нового отчества
        {
            SetUp(); // Вызов SetUp

            Assert.AreEqual(_newPatronymic, _testClass.NewPatronymic); // Проверка на правильную инициализацию нового отчества
        }
    }
}