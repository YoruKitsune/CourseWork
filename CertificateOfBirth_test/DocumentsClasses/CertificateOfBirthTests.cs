using System; 
using CourseWork.DocumentsClasses; 
using Microsoft.VisualStudio.TestTools.UnitTesting; 

namespace CertificateOfBirthUnitTests // Объявление пространства имен CertificateOfBirthUnitTests
{
    [TestClass] // Атрибут указывает, что класс является классом тестов
    public class CertificateOfBirthTests // Объявление класса CertificateOfBirthTests
    {

        [TestMethod] // Атрибут указывает, что метод является тестовым методом
        public void CertificateOfBirthConstructor_WithNullFather_ShouldThrowArgumentException() // Объявление метода тестирования с нулевым отцом
        {
            // Arrange // Подготовка данных
            PersonClass father = null; // Инициализация переменной father значением null
            PersonClass mother = new PersonClass(); // Создание объекта класса PersonClass
            DateTime dateOfBirth = new DateTime(2000, 1, 1); // Инициализация переменной с датой рождения

            // Act & Assert // Выполнение действий и проверка утверждения
            Assert.ThrowsException<ArgumentException>(() => new CertificateOfBirth(1234, 56789, DateTime.Now, "Test Issue Place", DateTime.Now, 98765, father, mother, dateOfBirth));
        }

        [TestMethod] // Атрибут указывает, что метод является тестовым методом
        public void CertificateOfBirthConstructor_WithInvalidValues_ShouldThrowArgumentException() // Объявление метода тестирования с недопустимыми значениями
        {
            // Arrange // Подготовка данных
            PersonClass father = new PersonClass();
            PersonClass mother = new PersonClass();
            DateTime dateOfBirth = new DateTime(2000, 1, 1);

            // Act & Assert // Выполнение действий и проверка утверждения
            Assert.ThrowsException<ArgumentException>(() => new CertificateOfBirth(1234, -56789, DateTime.Now, "Test Issue Place", DateTime.Now, 98765, father, mother, dateOfBirth)); // Отрицательное число
            Assert.ThrowsException<ArgumentException>(() => new CertificateOfBirth(1234, 56789, DateTime.Now, "Test Issue Place", DateTime.Now, 98765, father, mother, DateTime.Now.AddDays(1))); // Дата рождения в будущем
        }

        [TestMethod] // Атрибут указывает, что метод является тестовым методом
        public void CertificateOfBirthDefaultConstructor_WithNullMother_ShouldThrowArgumentException() // Объявление метода тестирования с нулевой матерью
        {
            // Arrange // Подготовка данных
            PersonClass father = new PersonClass();
            PersonClass mother = null;
            DateTime dateOfBirth = new DateTime(2000, 1, 1);

            // Act & Assert // Выполнение действий и проверка утверждения
            Assert.ThrowsException<ArgumentException>(() => new CertificateOfBirth(1234, 56789, DateTime.Now, "Test Issue Place", DateTime.Now, 98765, father, mother, dateOfBirth));
        }

        [TestMethod] // Атрибут указывает, что метод является тестовым методом
        public void CertificateOfBirthDefaultConstructor_ShouldCreateObjectWithDefaultValues() // Объявление метода тестирования создания объекта с "дефолтными" значениями
        {
            // Act // Действие
            CertificateOfBirth certificate = new CertificateOfBirth(); // Создание объекта сертификата рождения

            // Assert // Проверка
            Assert.IsNotNull(certificate); // Проверка на null
            Assert.AreEqual(9999, certificate.Series); // Проверка на равенство
            Assert.AreEqual(999999, certificate.Number); // Проверка на равенство

            Assert.IsNotNull(certificate.Father); // Проверка на null
            Assert.IsNotNull(certificate.Mother); // Проверка на null
            Assert.AreEqual(DateTime.Now.Date, certificate.DateOfBirth.Date); // Проверка только даты
        }

        [TestMethod] // Атрибут указывает, что метод является тестовым методом
        [ExpectedException(typeof(ArgumentException))] // Ожидаемое исключение
        public void CertificateOfBirthConstructor_WithFutureDateOfBirth_ShouldThrowArgumentException() // Объявление метода тестирования с датой рождения в будущем
        {
            // Arrange // Подготовка данных
            int series = 1234;
            int number = 56789;
            DateTime issueDate = DateTime.Now;
            string issuePlace = "Test Issue Place";
            DateTime actDate = DateTime.Now;
            int actNumber = 98765;
            PersonClass father = new PersonClass();
            PersonClass mother = new PersonClass();
            DateTime futureDateOfBirth = DateTime.Now.AddDays(1);

            // Act // Действие
            CertificateOfBirth certificate = new CertificateOfBirth(series, number, issueDate, issuePlace, actDate, actNumber, father, mother, futureDateOfBirth);


        }
    }
}