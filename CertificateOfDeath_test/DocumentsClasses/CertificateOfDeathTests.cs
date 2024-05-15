using System; // ������ ������������ ���� System
using CourseWork.DocumentsClasses; // ������ ������������ ���� CourseWork.DocumentsClasses
using Microsoft.VisualStudio.TestTools.UnitTesting; // ������ ������������ ���� Microsoft.VisualStudio.TestTools.UnitTesting

namespace CertificateOfDeath_test.DocumentsClasses // ����������� ������������ ���� CertificateOfDeath_test.DocumentsClasses
{
    [TestClass] // �������, �����������, ��� ����� �������� �������� ������
    public class CertificateOfDeathTests // ����������� ������ CertificateOfDeathTests
    {
        private CertificateOfDeath _testClass; // ��������� ���� _testClass ���� CertificateOfDeath
        private int _series; // ��������� ���� _series ���� int
        private int _number; // ��������� ���� _number ���� int
        private DateTime _issueDate; // ��������� ���� _issueDate ���� DateTime
        private string _issuePlace; // ��������� ���� _issuePlace ���� string
        private DateTime _actDate; // ��������� ���� _actDate ���� DateTime
        private int _actNumber; // ��������� ���� _actNumber ���� int
        private string _deathPlace; // ��������� ���� _deathPlace ���� string
        private DateTime _deathDate; // ��������� ���� _deathDate ���� DateTime

        [TestInitialize] // �������, �����������, ��� ����� ������ ����������� ����� ������ �������� �������
        public void SetUp() // ����������� ������ SetUp
        {
            _series = 1304; // ���������� �������� ��� _series
            _number = 255340; // ���������� �������� ��� _number
            _issueDate = DateTime.UtcNow; // ���������� �������� ��� _issueDate
            _issuePlace = "������"; // ���������� �������� ��� _issuePlace
            _actDate = DateTime.UtcNow; // ���������� �������� ��� _actDate
            _actNumber = 70315; // ���������� �������� ��� _actNumber
            _deathPlace = "������"; // ���������� �������� ��� _deathPlace
            _deathDate = DateTime.UtcNow; // ���������� �������� ��� _deathDate
            _testClass = new CertificateOfDeath(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _deathPlace, _deathDate); // �������� ���������� ������ CertificateOfDeath
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanConstruct() // ����������� ������ CanConstruct
        {
            // Act
            var instance = new CertificateOfDeath(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _deathPlace, _deathDate); // �������� ����������

            // Assert
            Assert.IsNotNull(instance); // ��������, ��� ��������� �� null

            // Act
            instance = new CertificateOfDeath(); // �������� ����������

            // Assert
            Assert.IsNotNull(instance); // ��������, ��� ����� ��������� �� null
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void DeathPlaceIsInitializedCorrectly() // ����������� ������ ��� �������� ���������� ������������� ����� ������
        {
            Assert.AreEqual(_deathPlace, _testClass.DeathPlace); // ��������, ��� ����� ������ ���������������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void DeathDateIsInitializedCorrectly() // ����������� ������ ��� �������� ���������� ������������� ���� ������
        {
            Assert.AreEqual(_deathDate, _testClass.DeathDate); // ��������, ��� ���� ������ ���������������� ���������
        }
    }
}