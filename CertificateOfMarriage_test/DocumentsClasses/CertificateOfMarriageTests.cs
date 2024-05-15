namespace CertificateOfMarriage_test.DocumentsClasses // ����������� ������������ ���� CertificateOfMarriage_test.DocumentsClasses
{
    using System; // ������ ������������ ���� System
    using CourseWork.DocumentsClasses; // ������ ������������ ���� CourseWork.DocumentsClasses
    using Microsoft.VisualStudio.TestTools.UnitTesting; // ������ ������������ ���� Microsoft.VisualStudio.TestTools.UnitTesting

    [TestClass] // �������, ����������� ��� ����� �������� �������� ������
    public class CertificateOfMarriageTests // ����������� ������ CertificateOfMarriageTests
    {
        private CertificateOfMarriage _testClass; // ��������� ���� _testClass ���� CertificateOfMarriage
        private int _series; // ��������� ���� _series ���� int
        private int _number; // ��������� ���� _number ���� int
        private DateTime _issueDate; // ��������� ���� _issueDate ���� DateTime
        private string _issuePlace; // ��������� ���� _issuePlace ���� string
        private DateTime _actDate; // ��������� ���� _actDate ���� DateTime
        private int _actNumber; // ��������� ���� _actNumber ���� int
        private PersonClass _groom; // ��������� ���� _groom ���� PersonClass
        private PersonClass _bride; // ��������� ���� _bride ���� PersonClass
        private string _brideSurname; // ��������� ���� _brideSurname ���� string
        private string _groomSurname; // ��������� ���� _groomSurname ���� string

        [TestInitialize] // �������, ����������� ��� ����� ������ ����������� ����� ������ �������� �������
        public void SetUp() // ����������� ������ SetUp
        {
            _series = 9064; // ���������� �������� ��� _series
            _number = 639753; // ���������� �������� ��� _number
            _issueDate = DateTime.UtcNow; // ���������� �������� ��� _issueDate
            _issuePlace = "������"; // ���������� �������� ��� _issuePlace
            _actDate = DateTime.UtcNow; // ���������� �������� ��� _actDate
            _actNumber = 37805; // ���������� �������� ��� _actNumber
            _groom = new PersonClass(); // �������� ���������� PersonClass � ���������� ��� ��������� _groom
            _bride = new PersonClass(); // �������� ���������� PersonClass � ���������� ��� ��������� _bride
            _brideSurname = "���������"; // ���������� �������� ��� _brideSurname
            _groomSurname = "�������"; // ���������� �������� ��� _groomSurname
            _testClass = new CertificateOfMarriage(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _groom, _bride, _brideSurname, _groomSurname); // �������� ���������� CertificateOfMarriage � ���������� ��� �������� _testClass
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanConstruct() // ����������� ������ CanConstruct
        {
            // Act
            var instance = new CertificateOfMarriage(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _groom, _bride, _brideSurname, _groomSurname); // �������� ����������

            // Assert
            Assert.IsNotNull(instance); // ��������, ��� ��������� �� null

            // Act
            instance = new CertificateOfMarriage(); // �������� ����������

            // Assert
            Assert.IsNotNull(instance); // ��������, ��� ����� ��������� �� null
        }

      
        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void BrideSurnameIsInitializedCorrectly() // ����������� ������ ��� �������� ���������� ������������� ������� �������
        {
            Assert.AreEqual(_brideSurname, _testClass.BrideSurname); // ��������, ��� ������� ������� ���������������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void GroomSurnameIsInitializedCorrectly() // ����������� ������ ��� �������� ���������� ������������� ������� ������
        {
            Assert.AreEqual(_groomSurname, _testClass.GroomSurname); // ��������, ��� ������� ������ ���������������� ���������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanGetGroomOldSurname() // ����������� ������ ��� �������� ����������� �������� ���������� ������� ������
        {
            // Assert
            Assert.IsInstanceOfType(_testClass.GroomOldSurname, typeof(string)); // �����������, ��� �������� GroomOldSurname �������� ����������� string
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void CanGetBrideOldSurname() // ����������� ������ ��� �������� ����������� �������� ���������� ������� �������
        {
            // Assert
            Assert.IsInstanceOfType(_testClass.BrideOldSurname, typeof(string)); // �����������, ��� �������� BrideOldSurname �������� ����������� string
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void BrideIsInitializedCorrectly() // ����������� ������ ��� �������� ���������� ������������� �������
        {
            Assert.AreSame(_bride, _testClass.Bride); // ��������, ��� ������ _bride � _testClass.Bride ��������� �� ���� � ��� �� ������
        }

        [TestMethod] // �������, ����������� ��� ��� �������� �����
        public void GroomIsInitializedCorrectly() // ����������� ������ ��� �������� ���������� ������������� ������
        {
            Assert.AreSame(_groom, _testClass.Groom); // ��������, ��� ������ _groom � _testClass.Groom ��������� �� ���� � ��� �� ������
        }
    }
}