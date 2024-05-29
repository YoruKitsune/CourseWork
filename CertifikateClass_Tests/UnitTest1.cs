using System;  // ����������� ������������ ���� ��� ������� ������� � ����� ������
using CourseWork.DocumentsClasses;  // ����������� ������������ ���� � �������� ��� ����������
using Microsoft.VisualStudio.TestTools.UnitTesting;  // ����������� ������������ ���� ��� ����-������������

namespace CertificateClass_Test.DocumentsClasses
{
    [TestClass]
    public class CertificateClassTests
    {
        private class TestCertificateClass : CertificateClass  // �������� ������ ��� ������������, ��������������� �� ���������������� ������
        {
            public TestCertificateClass(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber) : base(series, number, issueDate, issuePlace, actDate, actNumber)
            {
            }

            public TestCertificateClass() : base()  // ����������� ��� ����������
            {
            }
        }

        private TestCertificateClass _testClass;  // �������� ���������� ������ ��� ������������
        private int _series;  // ���� ��� ���������� �������� ������
        private int _number;
        private DateTime _issueDate;
        private string _issuePlace;
        private DateTime _actDate;
        private int _actNumber;

        [TestInitialize]
        public void SetUp()  // ������������� ������ ��� ������������
        {
            _series = 6865;
            _number = 505543;
            _issueDate = new DateTime(2023, 5, 10);
            _issuePlace = "������";
            _actDate = new DateTime(2023, 5, 10);
            _actNumber = 187;
            _testClass = new TestCertificateClass(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber);
        }

        [TestMethod]
        public void CanConstruct()  // ���� �������� ������������
        {
            var instance = new TestCertificateClass(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber);
            Assert.IsNotNull(instance);  // �������� �� �� ������ ��������

            instance = new TestCertificateClass();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CannotConstructWithNullSeries()  // ���� �� ������������� �������� ��� �������� �����
        {
            Assert.ThrowsException<ArgumentException>(() => new TestCertificateClass(0, _number, _issueDate, _issuePlace, _actDate, _actNumber));
        }

        [TestMethod]
        public void CannotConstructWithNullNumber()  // ���� �� ������������� �������� ��� �������� ������
        {
            Assert.ThrowsException<ArgumentException>(() => new TestCertificateClass(_series, 0, _issueDate, _issuePlace, _actDate, _actNumber));
        }

        [TestMethod]
        public void CannotConstructWithNullActNumber()  // ���� �� ������������� �������� ��� �������� ������ ����
        {
            Assert.ThrowsException<ArgumentException>(() => new TestCertificateClass(_series, _number, _issueDate, _issuePlace, _actDate, -1));
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        public void CannotConstructWithInvalidIssuePlace(string value)  // ���� �� ������������� �������� � ������������ ������ ������
        {
            Assert.ThrowsException<ArgumentException>(() => new TestCertificateClass(_series, _number, _issueDate, value ?? "SomePlace", _actDate, _actNumber));
        }

        [TestMethod]
        public void SeriesIsInitializedCorrectly()  // ���� �� �������� ���������� ������������� �����
        {
            Assert.AreEqual(_series, _testClass.Series);
        }

        [TestMethod]
        public void NumberIsInitializedCorrectly()  // ���� �� �������� ���������� ������������� ������
        {
            Assert.AreEqual(_number, _testClass.Number);
        }

        [TestMethod]
        public void IssueDateIsInitializedCorrectly()  // ���� �� �������� ���������� ������������� ���� ������
        {
            Assert.AreEqual(_issueDate, _testClass.IssueDate);
        }

        [TestMethod]
        public void IssuePlaceIsInitializedCorrectly()  // ���� �� �������� ���������� ������������� ����� ������
        {
            Assert.AreEqual(_issuePlace, _testClass.IssuePlace);
        }

        [TestMethod]
        public void CanGetDateOfAct()  // ���� �� ����������� ��������� ���� ����
        {
            Assert.IsInstanceOfType(_testClass.DateOfAct, typeof(DateTime));
        }

        [TestMethod]
        public void CanGetNumberOfAct()  // ���� �� ����������� ��������� ������ ����
        {
            Assert.IsInstanceOfType(_testClass.NumberOfAct, typeof(int));
        }
    }
}