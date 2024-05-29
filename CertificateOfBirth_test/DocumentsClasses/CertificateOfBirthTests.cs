using System; 
using CourseWork.DocumentsClasses; 
using Microsoft.VisualStudio.TestTools.UnitTesting; 

namespace CertificateOfBirthUnitTests // ���������� ������������ ���� CertificateOfBirthUnitTests
{
    [TestClass] // ������� ���������, ��� ����� �������� ������� ������
    public class CertificateOfBirthTests // ���������� ������ CertificateOfBirthTests
    {

        [TestMethod] // ������� ���������, ��� ����� �������� �������� �������
        public void CertificateOfBirthConstructor_WithNullFather_ShouldThrowArgumentException() // ���������� ������ ������������ � ������� �����
        {
            // Arrange // ���������� ������
            PersonClass father = null; // ������������� ���������� father ��������� null
            PersonClass mother = new PersonClass(); // �������� ������� ������ PersonClass
            DateTime dateOfBirth = new DateTime(2000, 1, 1); // ������������� ���������� � ����� ��������

            // Act & Assert // ���������� �������� � �������� �����������
            Assert.ThrowsException<ArgumentException>(() => new CertificateOfBirth(1234, 56789, DateTime.Now, "Test Issue Place", DateTime.Now, 98765, father, mother, dateOfBirth));
        }

        [TestMethod] // ������� ���������, ��� ����� �������� �������� �������
        public void CertificateOfBirthConstructor_WithInvalidValues_ShouldThrowArgumentException() // ���������� ������ ������������ � ������������� ����������
        {
            // Arrange // ���������� ������
            PersonClass father = new PersonClass();
            PersonClass mother = new PersonClass();
            DateTime dateOfBirth = new DateTime(2000, 1, 1);

            // Act & Assert // ���������� �������� � �������� �����������
            Assert.ThrowsException<ArgumentException>(() => new CertificateOfBirth(1234, -56789, DateTime.Now, "Test Issue Place", DateTime.Now, 98765, father, mother, dateOfBirth)); // ������������� �����
            Assert.ThrowsException<ArgumentException>(() => new CertificateOfBirth(1234, 56789, DateTime.Now, "Test Issue Place", DateTime.Now, 98765, father, mother, DateTime.Now.AddDays(1))); // ���� �������� � �������
        }

        [TestMethod] // ������� ���������, ��� ����� �������� �������� �������
        public void CertificateOfBirthDefaultConstructor_WithNullMother_ShouldThrowArgumentException() // ���������� ������ ������������ � ������� �������
        {
            // Arrange // ���������� ������
            PersonClass father = new PersonClass();
            PersonClass mother = null;
            DateTime dateOfBirth = new DateTime(2000, 1, 1);

            // Act & Assert // ���������� �������� � �������� �����������
            Assert.ThrowsException<ArgumentException>(() => new CertificateOfBirth(1234, 56789, DateTime.Now, "Test Issue Place", DateTime.Now, 98765, father, mother, dateOfBirth));
        }

        [TestMethod] // ������� ���������, ��� ����� �������� �������� �������
        public void CertificateOfBirthDefaultConstructor_ShouldCreateObjectWithDefaultValues() // ���������� ������ ������������ �������� ������� � "����������" ����������
        {
            // Act // ��������
            CertificateOfBirth certificate = new CertificateOfBirth(); // �������� ������� ����������� ��������

            // Assert // ��������
            Assert.IsNotNull(certificate); // �������� �� null
            Assert.AreEqual(9999, certificate.Series); // �������� �� ���������
            Assert.AreEqual(999999, certificate.Number); // �������� �� ���������

            Assert.IsNotNull(certificate.Father); // �������� �� null
            Assert.IsNotNull(certificate.Mother); // �������� �� null
            Assert.AreEqual(DateTime.Now.Date, certificate.DateOfBirth.Date); // �������� ������ ����
        }

        [TestMethod] // ������� ���������, ��� ����� �������� �������� �������
        [ExpectedException(typeof(ArgumentException))] // ��������� ����������
        public void CertificateOfBirthConstructor_WithFutureDateOfBirth_ShouldThrowArgumentException() // ���������� ������ ������������ � ����� �������� � �������
        {
            // Arrange // ���������� ������
            int series = 1234;
            int number = 56789;
            DateTime issueDate = DateTime.Now;
            string issuePlace = "Test Issue Place";
            DateTime actDate = DateTime.Now;
            int actNumber = 98765;
            PersonClass father = new PersonClass();
            PersonClass mother = new PersonClass();
            DateTime futureDateOfBirth = DateTime.Now.AddDays(1);

            // Act // ��������
            CertificateOfBirth certificate = new CertificateOfBirth(series, number, issueDate, issuePlace, actDate, actNumber, father, mother, futureDateOfBirth);


        }
    }
}