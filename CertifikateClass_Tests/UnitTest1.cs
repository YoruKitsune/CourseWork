using System;  // Подключение пространства имен для базовых классов и типов данных
using CourseWork.DocumentsClasses;  // Подключение пространства имен с классами для документов
using Microsoft.VisualStudio.TestTools.UnitTesting;  // Подключение пространства имен для юнит-тестирования

namespace CertificateClass_Test.DocumentsClasses
{
    [TestClass]
    public class CertificateClassTests
    {
        private class TestCertificateClass : CertificateClass  // Открытие класса для тестирования, унаследованного от верификационного класса
        {
            public TestCertificateClass(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber) : base(series, number, issueDate, issuePlace, actDate, actNumber)
            {
            }

            public TestCertificateClass() : base()  // Конструктор без параметров
            {
            }
        }

        private TestCertificateClass _testClass;  // Создание экземпляра класса для тестирования
        private int _series;  // Поля для сохранения тестовых данных
        private int _number;
        private DateTime _issueDate;
        private string _issuePlace;
        private DateTime _actDate;
        private int _actNumber;

        [TestInitialize]
        public void SetUp()  // Инициализация данных для тестирования
        {
            _series = 6865;
            _number = 505543;
            _issueDate = new DateTime(2023, 5, 10);
            _issuePlace = "Москва";
            _actDate = new DateTime(2023, 5, 10);
            _actNumber = 187;
            _testClass = new TestCertificateClass(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber);
        }

        [TestMethod]
        public void CanConstruct()  // Тест проверки конструктора
        {
            var instance = new TestCertificateClass(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber);
            Assert.IsNotNull(instance);  // Проверка на не пустое значение

            instance = new TestCertificateClass();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CannotConstructWithNullSeries()  // Тест на невозможность создания без указания серии
        {
            Assert.ThrowsException<ArgumentException>(() => new TestCertificateClass(0, _number, _issueDate, _issuePlace, _actDate, _actNumber));
        }

        [TestMethod]
        public void CannotConstructWithNullNumber()  // Тест на невозможность создания без указания номера
        {
            Assert.ThrowsException<ArgumentException>(() => new TestCertificateClass(_series, 0, _issueDate, _issuePlace, _actDate, _actNumber));
        }

        [TestMethod]
        public void CannotConstructWithNullActNumber()  // Тест на невозможность создания без указания номера акта
        {
            Assert.ThrowsException<ArgumentException>(() => new TestCertificateClass(_series, _number, _issueDate, _issuePlace, _actDate, -1));
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        public void CannotConstructWithInvalidIssuePlace(string value)  // Тест на невозможность создания с неправильным местом выдачи
        {
            Assert.ThrowsException<ArgumentException>(() => new TestCertificateClass(_series, _number, _issueDate, value ?? "SomePlace", _actDate, _actNumber));
        }

        [TestMethod]
        public void SeriesIsInitializedCorrectly()  // Тест на проверку правильной инициализации серии
        {
            Assert.AreEqual(_series, _testClass.Series);
        }

        [TestMethod]
        public void NumberIsInitializedCorrectly()  // Тест на проверку правильной инициализации номера
        {
            Assert.AreEqual(_number, _testClass.Number);
        }

        [TestMethod]
        public void IssueDateIsInitializedCorrectly()  // Тест на проверку правильной инициализации даты выдачи
        {
            Assert.AreEqual(_issueDate, _testClass.IssueDate);
        }

        [TestMethod]
        public void IssuePlaceIsInitializedCorrectly()  // Тест на проверку правильной инициализации места выдачи
        {
            Assert.AreEqual(_issuePlace, _testClass.IssuePlace);
        }

        [TestMethod]
        public void CanGetDateOfAct()  // Тест на возможность получения даты акта
        {
            Assert.IsInstanceOfType(_testClass.DateOfAct, typeof(DateTime));
        }

        [TestMethod]
        public void CanGetNumberOfAct()  // Тест на возможность получения номера акта
        {
            Assert.IsInstanceOfType(_testClass.NumberOfAct, typeof(int));
        }
    }
}