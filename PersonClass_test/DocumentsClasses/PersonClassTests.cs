namespace PersonClass_test.DocumentsClasses
{
    using System;
    using System.Collections.Generic;
    using CourseWork.DocumentsClasses;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PersonClassTests
    {
        private PersonClass _testClass;
        private string _name;
        private string _surname;
        private string _patronymic;
        private string _birthplace;
        private DateTime _birthdate;
        private string _passportData;
        private string _nationality;
        private StatusEnum _status;

        [TestInitialize] // Атрибут, указывающий что метод должен выполниться перед каждым тестовым методом
        public void SetUp() // Определение метода SetUp
        {
            _name = "Игорь"; // Инициализация переменной _name
            _surname = "Иванов"; // Инициализация переменной _surname
            _patronymic = ""; // Инициализация переменной _patronymic
            _birthplace = "Простоквашино"; // Инициализация переменной _birthplace
            _birthdate = DateTime.UtcNow; // Инициализация переменной _birthdate
            _passportData = "5856 156734"; // Инициализация переменной _passportData
            _nationality = "Русский"; // Инициализация переменной _nationality
            _status = StatusEnum.divorced; // Инициализация переменной _status
            _testClass = new PersonClass(_name, _surname, _patronymic, _birthplace, _birthdate, _passportData, _nationality, _status); // Создание экземпляра PersonClass
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanConstruct() // Определение метода CanConstruct
        {
            // Act
            var instance = new PersonClass(_name, _surname, _patronymic, _birthplace, _birthdate, _passportData, _nationality, _status); // Создание экземпляра

            // Assert
            Assert.IsNotNull(instance); // Проверка, что экземпляр не null

            // Act
            instance = new PersonClass(); // Создание экземпляра

            // Assert
            Assert.IsNotNull(instance); // Проверка, что новый экземпляр не null
        }


        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanCallChangeStatus() // Определение метода CanCallChangeStatus
        {
            // Arrange
            var status = StatusEnum.single; // Инициализация переменной status

            // Act
            _testClass.ChangeStatus(status); // Вызов метода ChangeStatus

            // Assert
            Assert.AreEqual(status, _testClass.Status); // Проверка, что статус был изменен
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanSetAndGetId() // Определение метода CanSetAndGetId
        {
            // Arrange
            var testValue = "TestValue1293772477"; // Инициализация переменной testValue

            // Act
            _testClass.Id = testValue; // Установка значения свойства Id

            // Assert
            Assert.AreEqual(testValue, _testClass.Id); // Проверка, что Id установлен корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void NameIsInitializedCorrectly() // Определение метода NameIsInitializedCorrectly
        {
            Assert.AreEqual(_name, _testClass.Name); // Проверка, что поле Name инициализировано корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void SurnameIsInitializedCorrectly() // Определение метода SurnameIsInitializedCorrectly
        {
            Assert.AreEqual(_surname, _testClass.Surname); // Проверка, что поле Surname инициализировано корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void PatronymicIsInitializedCorrectly() // Определение метода PatronymicIsInitializedCorrectly
        {
            Assert.AreEqual(_patronymic, _testClass.Patronymic); // Проверка, что поле Patronymic инициализировано корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void BirthDateIsInitializedCorrectly() // Определение метода BirthDateIsInitializedCorrectly
        {
            Assert.AreEqual(_birthdate, _testClass.BirthDate); // Проверка, что поле BirthDate инициализировано корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void BirthPlaceIsInitializedCorrectly() // Определение метода BirthPlaceIsInitializedCorrectly
        {
            Assert.AreEqual(_birthplace, _testClass.BirthPlace); // Проверка, что поле BirthPlace инициализировано корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void PassportDataIsInitializedCorrectly() // Определение метода PassportDataIsInitializedCorrectly
        {
            Assert.AreEqual(_passportData, _testClass.PassportData); // Проверка, что поле PassportData инициализировано корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void NationalityIsInitializedCorrectly() // Определение метода NationalityIsInitializedCorrectly
        {
            Assert.AreEqual(_nationality, _testClass.Nationality); // Проверка, что поле Nationality инициализировано корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void StatusIsInitializedCorrectly() // Определение метода StatusIsInitializedCorrectly
        {
            Assert.AreEqual(_status, _testClass.Status); // Проверка, что поле Status инициализировано корректно
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanSetAndGetChilds() // Определение метода CanSetAndGetChilds
        {
            // Arrange
            var testValue = new[] { new PersonClass(), new PersonClass(), new PersonClass() }; // Создание массива экземпляров PersonClass

            // Act
            _testClass.Childs = testValue; // Установка значения свойства Childs

            // Assert
            Assert.AreSame(testValue, _testClass.Childs); // Проверка, что свойство Childs содержит тот же самый объект, что и testValue
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanGetIssuedCertificates() // Определение метода CanGetIssuedCertificates
        {
            // Assert
            Assert.IsInstanceOfType(_testClass.IssuedCertificates, typeof(List<CertificateClass>)); // Проверка, что свойство IssuedCertificates является экземпляром List<CertificateClass>
        }

        [TestMethod] // Атрибут, указывающий что это тестовый метод
        public void CanGetBrokenCertificates() // Определение метода CanGetBrokenCertificates
        {
            // Assert
            Assert.IsInstanceOfType(_testClass.BrokenCertificates, typeof(List<CertificateClass>)); // Проверка, что свойство BrokenCertificates является экземпляром List<CertificateClass>
        }
    }
}