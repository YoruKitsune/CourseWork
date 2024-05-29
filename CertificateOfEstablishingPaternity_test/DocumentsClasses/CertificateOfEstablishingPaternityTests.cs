namespace CertificateOfEstablishingPaternity_test.DocumentsClasses // ����������� ������������ ���� CertificateOfEstablishingPaternity_test.DocumentsClasses
{
    using System; // ������ ������������ ���� System
    using CourseWork.DocumentsClasses; // ������ ������������ ���� CourseWork.DocumentsClasses
    using Microsoft.VisualStudio.TestTools.UnitTesting; // ������ ������������ ���� Microsoft.VisualStudio.TestTools.UnitTesting

    [TestClass] // �������, ����������� ��� ����� �������� �������� ������
    public class CertificateOfEstablishingPaternityTests // ����������� ������ CertificateOfEstablishingPaternityTests
    {
        private CertificateOfEstablishingPaternity _testClass; // ��������� ���� _testClass ���� CertificateOfEstablishingPaternity
        private int _series; // ��������� ���� _series ���� int
        private int _number; // ��������� ���� _number ���� int
        private DateTime _issueDate; // ��������� ���� _issueDate ���� DateTime
        private string _issuePlace; // ��������� ���� _issuePlace ���� string
        private DateTime _actDate; // ��������� ���� _actDate ���� DateTime
        private int _actNumber; // ��������� ���� _actNumber ���� int
        private PersonClass _father; // ��������� ���� _father ���� PersonClass

        [TestInitialize] // �������, ����������� ��� ����� ������ ����������� ����� ������ �������� �������
        public void SetUp() // ����������� ������ SetUp
        {
            _series = 1753; // ���������� �������� ��� _series
            _number = 189481; // ���������� �������� ��� _number
            _issueDate = DateTime.UtcNow; // ���������� �������� ��� _issueDate
            _issuePlace = "������"; // ���������� �������� ��� _issuePlace
            _actDate = DateTime.UtcNow; // ���������� �������� ��� _actDate
            _actNumber = 19337; // ���������� �������� ��� _actNumber
            _father = new PersonClass(); // �������� ������ ���������� ������ PersonClass
            _testClass = new CertificateOfEstablishingPaternity(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _father); // �������� ���������� ������ CertificateOfEstablishingPaternity
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanConstruct() // ����������� ������ CanConstruct
        {
            // Act
            var instance = new CertificateOfEstablishingPaternity(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _father); // �������� ����������

            // Assert
            Assert.IsNotNull(instance); // ��������, ��� ��������� �� null

            // Act
            instance = new CertificateOfEstablishingPaternity(); // �������� ����������

            // Assert
            Assert.IsNotNull(instance); // ��������, ��� ����� ��������� �� null
        }

       

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void FatherIsInitializedCorrectly() // ����������� ������ ��� �������� ���������� ������������� ����
        {
            Assert.AreSame(_father, _testClass.Father); // ��������, ��� ���� ��������������� ���������
        }
    }
}