using System; // Импорт пространства имен System
using CourseWork.DocumentsClasses; // Импорт пространства имен CourseWork.DocumentsClasses
using Microsoft.VisualStudio.TestTools.UnitTesting; // Импорт пространства имен Microsoft.VisualStudio.TestTools.UnitTesting

namespace CertificateOfDeath_test.DocumentsClasses // Определение пространства имен CertificateOfDeath_test.DocumentsClasses
{
    [TestClass] // Атрибут, указывающий, что класс содержит тестовые методы
    public class CertificateOfDeathTests // Определение класса CertificateOfDeathTests
    {
        private CertificateOfDeath _testClass; // Приватное поле _testClass типа CertificateOfDeath
        private int _series; // Приватное поле _series типа int
        private int _number; // Приватное поле _number типа int
        private DateTime _issueDate; // Приватное поле _issueDate типа DateTime
        private string _issuePlace; // Приватное поле _issuePlace типа string
        private DateTime _actDate; // Приватное поле _actDate типа DateTime
        private int _actNumber; // Приватное поле _actNumber типа int
        private string _deathPlace; // Приватное поле _deathPlace типа string
        private DateTime _deathDate; // Приватное поле _deathDate типа DateTime

        [TestInitialize] // Атрибут, указывающий, что метод должен выполниться перед каждым тестовым методом
        public void SetUp() // Определение метода SetUp
        {
            _series = 1304; // Присвоение значения для _series
            _number = 255340; // Присвоение значения для _number
            _issueDate = DateTime.UtcNow; // Присвоение значения для _issueDate
            _issuePlace = "Москва"; // Присвоение значения для _issuePlace
            _actDate = DateTime.UtcNow; // Присвоение значения для _actDate
            _actNumber = 70315; // Присвоение значения для _actNumber
            _deathPlace = "Москва"; // Присвоение значения для _deathPlace
            _deathDate = DateTime.UtcNow; // Присвоение значения для _deathDate
            _testClass = new CertificateOfDeath(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _deathPlace, _deathDate); // Создание экземпляра класса CertificateOfDeath
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanConstruct() // Определение метода CanConstruct
        {
            // Act
            var instance = new CertificateOfDeath(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _deathPlace, _deathDate); // Создание экземпляра

            // Assert
            Assert.IsNotNull(instance); // Проверка, что экземпляр не null

            // Act
            instance = new CertificateOfDeath(); // Создание экземпляра

            // Assert
            Assert.IsNotNull(instance); // Проверка, что новый экземпляр не null
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void DeathPlaceIsInitializedCorrectly() // Определение метода для проверки корректной инициализации места смерти
        {
            Assert.AreEqual(_deathPlace, _testClass.DeathPlace); // Проверка, что место смерти инициализировано корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void DeathDateIsInitializedCorrectly() // Определение метода для проверки корректной инициализации даты смерти
        {
            Assert.AreEqual(_deathDate, _testClass.DeathDate); // Проверка, что дата смерти инициализирована корректно
        }
    }
}