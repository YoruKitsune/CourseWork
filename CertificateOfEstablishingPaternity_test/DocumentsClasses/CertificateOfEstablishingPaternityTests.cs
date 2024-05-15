namespace CertificateOfEstablishingPaternity_test.DocumentsClasses // Определение пространства имен CertificateOfEstablishingPaternity_test.DocumentsClasses
{
    using System; // Импорт пространства имен System
    using CourseWork.DocumentsClasses; // Импорт пространства имен CourseWork.DocumentsClasses
    using Microsoft.VisualStudio.TestTools.UnitTesting; // Импорт пространства имен Microsoft.VisualStudio.TestTools.UnitTesting

    [TestClass] // Атрибут, указывающий что класс содержит тестовые методы
    public class CertificateOfEstablishingPaternityTests // Определение класса CertificateOfEstablishingPaternityTests
    {
        private CertificateOfEstablishingPaternity _testClass; // Приватное поле _testClass типа CertificateOfEstablishingPaternity
        private int _series; // Приватное поле _series типа int
        private int _number; // Приватное поле _number типа int
        private DateTime _issueDate; // Приватное поле _issueDate типа DateTime
        private string _issuePlace; // Приватное поле _issuePlace типа string
        private DateTime _actDate; // Приватное поле _actDate типа DateTime
        private int _actNumber; // Приватное поле _actNumber типа int
        private PersonClass _father; // Приватное поле _father типа PersonClass

        [TestInitialize] // Атрибут, указывающий что метод должен выполниться перед каждым тестовым методом
        public void SetUp() // Определение метода SetUp
        {
            _series = 1753; // Присвоение значения для _series
            _number = 189481; // Присвоение значения для _number
            _issueDate = DateTime.UtcNow; // Присвоение значения для _issueDate
            _issuePlace = "Москва"; // Присвоение значения для _issuePlace
            _actDate = DateTime.UtcNow; // Присвоение значения для _actDate
            _actNumber = 19337; // Присвоение значения для _actNumber
            _father = new PersonClass(); // Создание нового экземпляра класса PersonClass
            _testClass = new CertificateOfEstablishingPaternity(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _father); // Создание экземпляра класса CertificateOfEstablishingPaternity
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanConstruct() // Определение метода CanConstruct
        {
            // Act
            var instance = new CertificateOfEstablishingPaternity(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _father); // Создание экземпляра

            // Assert
            Assert.IsNotNull(instance); // Проверка, что экземпляр не null

            // Act
            instance = new CertificateOfEstablishingPaternity(); // Создание экземпляра

            // Assert
            Assert.IsNotNull(instance); // Проверка, что новый экземпляр не null
        }

       

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void FatherIsInitializedCorrectly() // Определение метода для проверки корректной инициализации отца
        {
            Assert.AreSame(_father, _testClass.Father); // Проверка, что отец инициализирован корректно
        }
    }
}