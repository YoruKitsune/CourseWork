namespace CertificateOfAdoption_test.DocumentsClasses  // ���������� ������������ ���� ��� ������������ ����������
{
    using System;  // ����������� ������������ ���� ��� ������� ������� � ����� ������
    using CourseWork.DocumentsClasses;  // ����������� ������������ ���� � �������� ��� ����������
    using Microsoft.VisualStudio.TestTools.UnitTesting;  // ����������� ������������ ���� ��� ����-������������

    [TestClass]  // ������� �����������, ��� ����� �������� �������� �������
    public class CertificateOfAdoptionTests  // ���������� ������ ��� ������������ ������������� � �����������
    {
        private CertificateOfAdoption _testClass;  // ���������� ���������� ��� ������������ ������ ������������� � �����������
        private int _series;  // ���� ��� �������� �������� ������
        private int _number;
        private DateTime _issueDate;
        private string _issuePlace;
        private DateTime _actDate;
        private int _actNumber;
        private PersonClass _stepfather;  // ���� ��� �������� ������ � �������� ���� � ������
        private PersonClass _stepmother;

        [TestInitialize]  // ����� ������������� ������ ����� ������ ������
        public void SetUp()
        {

            _series = 6865;
            _number = 505543;
            _issueDate = DateTime.UtcNow;
            _issuePlace = "������";
            _actDate = DateTime.UtcNow;
            _actNumber = 327821487;
            _stepfather = new PersonClass();  // �������� ����������� �������� ��� ��������� ���� � ������
            _stepmother = new PersonClass();
            _testClass = new CertificateOfAdoption(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _stepfather, _stepmother);  // ������������� ���������� ��� ������������
        }

        [TestMethod]  // �������, ����������� �� �����-����
        public void CanConstruct()  // ���� �������� �������
        {
            // Act
            var instance = new CertificateOfAdoption(_series, _number, _issueDate, _issuePlace, _actDate, _actNumber, _stepfather, _stepmother);  // ��������

            // Assert
            Assert.IsNotNull(instance);  // ��������, ��� ������ �� �������� ������

            // Act
            instance = new CertificateOfAdoption();  // ��������

            // Assert
            Assert.IsNotNull(instance);  // ��������, ��� ������ �� �������� ������
        }


        [TestMethod]  // ���� �� �������� ���������� ������������� �������� ������
        public void StepmotherIsInitializedCorrectly()
        {
            Assert.AreSame(_stepmother, _testClass.Stepmother);
        }

        [TestMethod]  // ���� �� �������� ���������� ������������� ��������� ����
        public void StepfatherIsInitializedCorrectly()
        {
            Assert.AreSame(_stepfather, _testClass.Stepfather);
        }
    }
}