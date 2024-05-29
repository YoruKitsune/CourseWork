namespace CertificateOfDivorce_test.DocumentsClasses // Определение пространства имен CertificateOfDivorce_test.DocumentsClasses
{
    using System; // Импорт пространства имен System
    using CourseWork.DocumentsClasses; // Импорт пространства имен CourseWork.DocumentsClasses
    using Microsoft.VisualStudio.TestTools.UnitTesting; // Импорт пространства имен Microsoft.VisualStudio.TestTools.UnitTesting

    [TestClass] // Атрибут, указывающий что класс содержит тестовые методы
    public class CertificateOfDivorceTests // Определение класса CertificateOfDivorceTests
    {
        private CertificateOfDivorce _testClass; // Приватное поле _testClass типа CertificateOfDivorce
        private int _series; // Приватное поле _series типа int
        private int _number; // Приватное поле _number типа int
        private DateTime _issueDate; // Приватное поле _issueDate типа DateTime
        private string _issuePlace; // Приватное поле _issuePlace типа string
        private DateTime _actDate; // Приватное поле _actDate типа DateTime
        private int _actNumber; // Приватное поле _actNumber типа int
        private string _gettedSurname; // Приватное поле _gettedSurname типа string

        [TestInitialize] // Атрибут, указывающий что метод должен выполниться перед каждым тестовым методом
        public void SetUp() // Определение метода SetUp
        {
            _series = 9701; // Присвоение значения для _series
            _number = 105421; // Присвоение значения для _number
            _issueDate = DateTime.UtcNow; // Присвоение значения для _issueDate
            _issuePlace = "Москва"; // Присвоение значения для _issuePlace
            _actDate = DateTime.UtcNow; // Присвоение значения для _actDate
            _actNumber = 18563; // Присвоение значения для _actNumber
            _gettedSurname = "Новосибирск"; // Присвоение значения для _gettedSurname
            _testClass = new CertificateOfDivorce(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _gettedSurname); // Создание экземпляра класса CertificateOfDivorce
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanConstruct() // Определение метода CanConstruct
        {
            // Act
            var instance = new CertificateOfDivorce(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _gettedSurname); // Создание экземпляра

            // Assert
            Assert.IsNotNull(instance); // Проверка, что экземпляр не null

            // Act
            instance = new CertificateOfDivorce(); // Создание экземпляра

            // Assert
            Assert.IsNotNull(instance); // Проверка, что новый экземпляр не null
        }


        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void GettedSurnameIsInitializedCorrectly() // Определение метода для проверки корректной инициализации фамилии получателя
        {
            Assert.AreEqual(_gettedSurname, _testClass.GettedSurname); // Проверка, что фамилия получателя инициализирована корректно
        }
    }
}