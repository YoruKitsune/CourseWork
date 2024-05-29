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

        [TestInitialize] // �������, ����������� ��� ����� ������ ����������� ����� ������ �������� �������
        public void SetUp() // ����������� ������ SetUp
        {
            _name = "�����"; // ������������� ���������� _name
            _surname = "������"; // ������������� ���������� _surname
            _patronymic = ""; // ������������� ���������� _patronymic
            _birthplace = "�������������"; // ������������� ���������� _birthplace
            _birthdate = DateTime.UtcNow; // ������������� ���������� _birthdate
            _passportData = "5856 156734"; // ������������� ���������� _passportData
            _nationality = "�������"; // ������������� ���������� _nationality
            _status = StatusEnum.divorced; // ������������� ���������� _status
            _testClass = new PersonClass(_name, _surname, _patronymic, _birthplace, _birthdate, _passportData, _nationality, _status); // �������� ���������� PersonClass
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanConstruct() // ����������� ������ CanConstruct
        {
            // Act
            var instance = new PersonClass(_name, _surname, _patronymic, _birthplace, _birthdate, _passportData, _nationality, _status); // �������� ����������

            // Assert
            Assert.IsNotNull(instance); // ��������, ��� ��������� �� null

            // Act
            instance = new PersonClass(); // �������� ����������

            // Assert
            Assert.IsNotNull(instance); // ��������, ��� ����� ��������� �� null
        }


        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanCallChangeStatus() // ����������� ������ CanCallChangeStatus
        {
            // Arrange
            var status = StatusEnum.single; // ������������� ���������� status

            // Act
            _testClass.ChangeStatus(status); // ����� ������ ChangeStatus

            // Assert
            Assert.AreEqual(status, _testClass.Status); // ��������, ��� ������ ��� �������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanSetAndGetId() // ����������� ������ CanSetAndGetId
        {
            // Arrange
            var testValue = "TestValue1293772477"; // ������������� ���������� testValue

            // Act
            _testClass.Id = testValue; // ��������� �������� �������� Id

            // Assert
            Assert.AreEqual(testValue, _testClass.Id); // ��������, ��� Id ���������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void NameIsInitializedCorrectly() // ����������� ������ NameIsInitializedCorrectly
        {
            Assert.AreEqual(_name, _testClass.Name); // ��������, ��� ���� Name ���������������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void SurnameIsInitializedCorrectly() // ����������� ������ SurnameIsInitializedCorrectly
        {
            Assert.AreEqual(_surname, _testClass.Surname); // ��������, ��� ���� Surname ���������������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void PatronymicIsInitializedCorrectly() // ����������� ������ PatronymicIsInitializedCorrectly
        {
            Assert.AreEqual(_patronymic, _testClass.Patronymic); // ��������, ��� ���� Patronymic ���������������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void BirthDateIsInitializedCorrectly() // ����������� ������ BirthDateIsInitializedCorrectly
        {
            Assert.AreEqual(_birthdate, _testClass.BirthDate); // ��������, ��� ���� BirthDate ���������������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void BirthPlaceIsInitializedCorrectly() // ����������� ������ BirthPlaceIsInitializedCorrectly
        {
            Assert.AreEqual(_birthplace, _testClass.BirthPlace); // ��������, ��� ���� BirthPlace ���������������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void PassportDataIsInitializedCorrectly() // ����������� ������ PassportDataIsInitializedCorrectly
        {
            Assert.AreEqual(_passportData, _testClass.PassportData); // ��������, ��� ���� PassportData ���������������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void NationalityIsInitializedCorrectly() // ����������� ������ NationalityIsInitializedCorrectly
        {
            Assert.AreEqual(_nationality, _testClass.Nationality); // ��������, ��� ���� Nationality ���������������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void StatusIsInitializedCorrectly() // ����������� ������ StatusIsInitializedCorrectly
        {
            Assert.AreEqual(_status, _testClass.Status); // ��������, ��� ���� Status ���������������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanSetAndGetChilds() // ����������� ������ CanSetAndGetChilds
        {
            // Arrange
            var testValue = new[] { new PersonClass(), new PersonClass(), new PersonClass() }; // �������� ������� ����������� PersonClass

            // Act
            _testClass.Childs = testValue; // ��������� �������� �������� Childs

            // Assert
            Assert.AreSame(testValue, _testClass.Childs); // ��������, ��� �������� Childs �������� ��� �� ����� ������, ��� � testValue
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanGetIssuedCertificates() // ����������� ������ CanGetIssuedCertificates
        {
            // Assert
            Assert.IsInstanceOfType(_testClass.IssuedCertificates, typeof(List<CertificateClass>)); // ��������, ��� �������� IssuedCertificates �������� ����������� List<CertificateClass>
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanGetBrokenCertificates() // ����������� ������ CanGetBrokenCertificates
        {
            // Assert
            Assert.IsInstanceOfType(_testClass.BrokenCertificates, typeof(List<CertificateClass>)); // ��������, ��� �������� BrokenCertificates �������� ����������� List<CertificateClass>
        }
    }
}