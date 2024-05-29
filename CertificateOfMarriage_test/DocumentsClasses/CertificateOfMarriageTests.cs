namespace CertificateOfMarriage_test.DocumentsClasses // Определение пространства имен CertificateOfMarriage_test.DocumentsClasses
{
    using System; // Импорт пространства имен System
    using CourseWork.DocumentsClasses; // Импорт пространства имен CourseWork.DocumentsClasses
    using Microsoft.VisualStudio.TestTools.UnitTesting; // Импорт пространства имен Microsoft.VisualStudio.TestTools.UnitTesting

    [TestClass] // Атрибут, указывающий что класс содержит тестовые методы
    public class CertificateOfMarriageTests // Определение класса CertificateOfMarriageTests
    {
        private CertificateOfMarriage _testClass; // Приватное поле _testClass типа CertificateOfMarriage
        private int _series; // Приватное поле _series типа int
        private int _number; // Приватное поле _number типа int
        private DateTime _issueDate; // Приватное поле _issueDate типа DateTime
        private string _issuePlace; // Приватное поле _issuePlace типа string
        private DateTime _actDate; // Приватное поле _actDate типа DateTime
        private int _actNumber; // Приватное поле _actNumber типа int
        private PersonClass _groom; // Приватное поле _groom типа PersonClass
        private PersonClass _bride; // Приватное поле _bride типа PersonClass
        private string _brideSurname; // Приватное поле _brideSurname типа string
        private string _groomSurname; // Приватное поле _groomSurname типа string

        [TestInitialize] // Атрибут, указывающий что метод должен выполниться перед каждым тестовым методом
        public void SetUp() // Определение метода SetUp
        {
            _series = 9064; // Присвоение значения для _series
            _number = 639753; // Присвоение значения для _number
            _issueDate = DateTime.UtcNow; // Присвоение значения для _issueDate
            _issuePlace = "Москва"; // Присвоение значения для _issuePlace
            _actDate = DateTime.UtcNow; // Присвоение значения для _actDate
            _actNumber = 37805; // Присвоение значения для _actNumber
            _groom = new PersonClass(); // Создание экземпляра PersonClass и присвоение его значенния _groom
            _bride = new PersonClass(); // Создание экземпляра PersonClass и присвоение его значенния _bride
            _brideSurname = "Кириловна"; // Присвоение значения для _brideSurname
            _groomSurname = "Кирилов"; // Присвоение значения для _groomSurname
            _testClass = new CertificateOfMarriage(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _groom, _bride, _brideSurname, _groomSurname); // Создание экземпляра CertificateOfMarriage и присвоение его значения _testClass
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanConstruct() // Определение метода CanConstruct
        {
            // Act
            var instance = new CertificateOfMarriage(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _groom, _bride, _brideSurname, _groomSurname); // Создание экземпляра

            // Assert
            Assert.IsNotNull(instance); // Проверка, что экземпляр не null

            // Act
            instance = new CertificateOfMarriage(); // Создание экземпляра

            // Assert
            Assert.IsNotNull(instance); // Проверка, что новый экземпляр не null
        }

      
        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void BrideSurnameIsInitializedCorrectly() // Определение метода для проверки корректной инициализации фамилии невесты
        {
            Assert.AreEqual(_brideSurname, _testClass.BrideSurname); // Проверка, что фамилия невесты инициализирована корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void GroomSurnameIsInitializedCorrectly() // Определение метода для проверки корректной инициализации фамилии жениха
        {
            Assert.AreEqual(_groomSurname, _testClass.GroomSurname); // Проверка, что фамилия жениха инициализирована корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanGetGroomOldSurname() // Определение метода для проверки возможности получить предыдущую фамилию жениха
        {
            // Assert
            Assert.IsInstanceOfType(_testClass.GroomOldSurname, typeof(string)); // Утверждение, что свойство GroomOldSurname является экземпляром string
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanGetBrideOldSurname() // Определение метода для проверки возможности получить предыдущую фамилию невесты
        {
            // Assert
            Assert.IsInstanceOfType(_testClass.BrideOldSurname, typeof(string)); // Утверждение, что свойство BrideOldSurname является экземпляром string
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void BrideIsInitializedCorrectly() // Определение метода для проверки корректной инициализации невесты
        {
            Assert.AreSame(_bride, _testClass.Bride); // Проверка, что объект _bride и _testClass.Bride ссылаются на один и тот же объект
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void GroomIsInitializedCorrectly() // Определение метода для проверки корректной инициализации жениха
        {
            Assert.AreSame(_groom, _testClass.Groom); // Проверка, что объект _groom и _testClass.Groom ссылаются на один и тот же объект
        }
    }
}