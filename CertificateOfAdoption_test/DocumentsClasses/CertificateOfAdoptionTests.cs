namespace CertificateOfAdoption_test.DocumentsClasses  // Объявление пространства имен для тестирования документов
{
    using System;  // Подключение пространства имен для базовых классов и типов данных
    using CourseWork.DocumentsClasses;  // Подключение пространства имен с классами для документов
    using Microsoft.VisualStudio.TestTools.UnitTesting;  // Подключение пространства имен для юнит-тестирования

    [TestClass]  // Атрибут указывающий, что класс является тестовым классом
    public class CertificateOfAdoptionTests  // Объявление класса для тестирования свидетельства о усыновлении
    {
        private CertificateOfAdoption _testClass;  // Объявление переменной для тестирования класса Свидетельство о усыновлении
        private int _series;  // Поле для хранения тестовых данных
        private int _number;
        private DateTime _issueDate;
        private string _issuePlace;
        private DateTime _actDate;
        private int _actNumber;
        private PersonClass _stepfather;  // Поля для хранения данных о приемном отце и матери
        private PersonClass _stepmother;

        [TestInitialize]  // Метод инициализации данных перед каждым тестом
        public void SetUp()
        {

            _series = 6865;
            _number = 505543;
            _issueDate = DateTime.UtcNow;
            _issuePlace = "Москва";
            _actDate = DateTime.UtcNow;
            _actNumber = 327821487;
            _stepfather = new PersonClass();  // Создание экземпляров объектов для приемного отца и матери
            _stepmother = new PersonClass();
            _testClass = new CertificateOfAdoption(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _stepfather, _stepmother);  // Инициализация экземпляра для тестирования
        }

        [TestMethod]  // Атрибут, указывающий на метод-тест
        public void CanConstruct()  // Тест создания объекта
        {
            // Act
            var instance = new CertificateOfAdoption(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _stepfather, _stepmother);  // Действие

            // Assert
            Assert.IsNotNull(instance);  // Проверка, что объект не является пустым

            // Act
            instance = new CertificateOfAdoption();  // Действие

            // Assert
            Assert.IsNotNull(instance);  // Проверка, что объект не является пустым
        }


        [TestMethod]  // Тест на проверку правильной инициализации приемной матери
        public void StepmotherIsInitializedCorrectly()
        {
            Assert.AreSame(_stepmother, _testClass.Stepmother);
        }

        [TestMethod]  // Тест на проверку правильной инициализации приемного отца
        public void StepfatherIsInitializedCorrectly()
        {
            Assert.AreSame(_stepfather, _testClass.Stepfather);
        }
    }
}