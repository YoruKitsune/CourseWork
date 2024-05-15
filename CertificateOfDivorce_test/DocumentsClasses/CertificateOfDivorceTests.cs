namespace CertificateOfDivorce_test.DocumentsClasses // ����������� ������������ ���� CertificateOfDivorce_test.DocumentsClasses
{
    using System; // ������ ������������ ���� System
    using CourseWork.DocumentsClasses; // ������ ������������ ���� CourseWork.DocumentsClasses
    using Microsoft.VisualStudio.TestTools.UnitTesting; // ������ ������������ ���� Microsoft.VisualStudio.TestTools.UnitTesting

    [TestClass] // �������, ����������� ��� ����� �������� �������� ������
    public class CertificateOfDivorceTests // ����������� ������ CertificateOfDivorceTests
    {
        private CertificateOfDivorce _testClass; // ��������� ���� _testClass ���� CertificateOfDivorce
        private int _series; // ��������� ���� _series ���� int
        private int _number; // ��������� ���� _number ���� int
        private DateTime _issueDate; // ��������� ���� _issueDate ���� DateTime
        private string _issuePlace; // ��������� ���� _issuePlace ���� string
        private DateTime _actDate; // ��������� ���� _actDate ���� DateTime
        private int _actNumber; // ��������� ���� _actNumber ���� int
        private string _gettedSurname; // ��������� ���� _gettedSurname ���� string

        [TestInitialize] // �������, ����������� ��� ����� ������ ����������� ����� ������ �������� �������
        public void SetUp() // ����������� ������ SetUp
        {
            _series = 9701; // ���������� �������� ��� _series
            _number = 105421; // ���������� �������� ��� _number
            _issueDate = DateTime.UtcNow; // ���������� �������� ��� _issueDate
            _issuePlace = "������"; // ���������� �������� ��� _issuePlace
            _actDate = DateTime.UtcNow; // ���������� �������� ��� _actDate
            _actNumber = 18563; // ���������� �������� ��� _actNumber
            _gettedSurname = "�����������"; // ���������� �������� ��� _gettedSurname
            _testClass = new CertificateOfDivorce(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _gettedSurname); // �������� ���������� ������ CertificateOfDivorce
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanConstruct() // ����������� ������ CanConstruct
        {
            // Act
            var instance = new CertificateOfDivorce(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _gettedSurname); // �������� ����������

            // Assert
            Assert.IsNotNull(instance); // ��������, ��� ��������� �� null

            // Act
            instance = new CertificateOfDivorce(); // �������� ����������

            // Assert
            Assert.IsNotNull(instance); // ��������, ��� ����� ��������� �� null
        }


        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void GettedSurnameIsInitializedCorrectly() // ����������� ������ ��� �������� ���������� ������������� ������� ����������
        {
            Assert.AreEqual(_gettedSurname, _testClass.GettedSurname); // ��������, ��� ������� ���������� ���������������� ���������
        }
    }
}