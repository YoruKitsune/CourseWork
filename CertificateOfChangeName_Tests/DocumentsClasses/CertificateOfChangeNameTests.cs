using System; // ������ ������������ ���� System
using CourseWork.DocumentsClasses; // ������ ������������ ���� CourseWork.DocumentsClasses
using Microsoft.VisualStudio.TestTools.UnitTesting; // ������ ������������ ���� Microsoft.VisualStudio.TestTools.UnitTesting

namespace CertificateOfChangeName_Tests.DocumentsClasses // ���������� ������������ ���� CertificateOfChangeName_Tests.DocumentsClasses
{
    [TestClass] // ������� ���������, ��� ����� �������� ������ ������������
    public class CertificateOfChangeNameTests // ���������� ������ CertificateOfChangeNameTests
    {
        private CertificateOfChangeName _testClass; // ��������� ���� ��� �������� ���������� CertificateOfChangeName
        private int _series; // ��������� ���� ��� �����
        private int _number; // ��������� ���� ��� ������
        private DateTime _issueDate; // ��������� ���� ��� ���� ������
        private string _issuePlace; // ��������� ���� ��� ����� ������
        private DateTime _actDate; // ��������� ���� ��� ���� ����
        private int _actNumber; // ��������� ���� ��� ������ ����
        private string _newName; // ��������� ���� ��� ������ �����
        private string _newSurname; // ��������� ���� ��� ����� �������
        private string _newPatronymic; // ��������� ���� ��� ������ ��������

        [TestInitialize] // ������� ��� ������, ������� ����������� ����� ������ ������� �����
        public void SetUp() // ����� ��� ��������� ��������� ��������
        {
            _series = 1021; // ��������� �������� ��� �����
            _number = 178242; // ��������� �������� ��� ������
            _issueDate = DateTime.UtcNow; // ��������� �������� ������� ��� ���� ������
            _issuePlace = "������"; // ��������� �������� ��� ����� ������
            _actDate = DateTime.UtcNow; // ��������� �������� ������� ��� ���� ����
            _actNumber = 18820; // ��������� �������� ��� ������ ����
            _newName = "�����"; // ��������� �������� ��� ������ �����
            _newSurname = "������"; // ��������� �������� ��� ����� �������
            _newPatronymic = "��������"; // ��������� �������� ��� ������ ��������
            _testClass = new CertificateOfChangeName(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _newName, _newSurname, _newPatronymic); // �������� ���������� CertificateOfChangeName
        }

        [TestMethod] // ������� ��� ������, ������� �������� �������� �������
        public void CanConstruct() // ����� ��� �������� �������� �������
        {
            SetUp(); // ����� SetUp

            // ��������
            var instance = new CertificateOfChangeName(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _newName, _newSurname, _newPatronymic); // �������� �������

            // �����������
            Assert.IsNotNull(instance); // �������� �� �� �������

            // ��������
            instance = new CertificateOfChangeName(); // �������� ������ �������

            // �����������
            Assert.IsNotNull(instance); // �������� �� �� �������
        }

       

        [TestMethod] // ������� ��� ������, ������� �������� �������� �������
        public void NewNameIsInitializedCorrectly() // ����� ��� �������� ���������� ������������� ������ �����
        {
            SetUp(); // ����� SetUp

            Assert.AreEqual(_newName, _testClass.NewName); // �������� �� ���������� ������������� ������ �����
        }

        [TestMethod] // ������� ��� ������, ������� �������� �������� �������
        public void NewSurnameIsInitializedCorrectly() // ����� ��� �������� ���������� ������������� ����� �������
        {
            SetUp(); // ����� SetUp

            Assert.AreEqual(_newSurname, _testClass.NewSurname); // �������� �� ���������� ������������� ����� �������
        }

        [TestMethod] // ������� ��� ������, ������� �������� �������� �������
        public void NewPatronymicIsInitializedCorrectly() // ����� ��� �������� ���������� ������������� ������ ��������
        {
            SetUp(); // ����� SetUp

            Assert.AreEqual(_newPatronymic, _testClass.NewPatronymic); // �������� �� ���������� ������������� ������ ��������
        }
    }
}