using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace CourseWork.DocumentsClasses
{
    public class PersonClass
    {
        public string Id { set; get; }
        public string Name { private set; get; }
        public string Surname { private set; get; }
        public string? Patronymic { private set; get; }
        public  DateTime BirthDate { private set; get; }
        public string BirthPlace { private set; get; }
        public string PassportData { private set; get; }
        public string? Nationality { private set; get; }
        public StatusEnum Status { private set; get; }
        public PersonClass[]? Childs {  set; get; }
        public List<CertificateClass> IssuedCertificates { private set; get; } = new();
        public List<CertificateClass> BrokenCertificates { private set; get; } = new();

        public PersonClass(string name, string surname, string patronymic, string birthplace, DateTime birthdate , string passportData, string nationality , StatusEnum status = StatusEnum.single)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            BirthPlace = birthplace;
            BirthDate = birthdate;
            PassportData = passportData;
            Nationality = nationality;
            Status = status;
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(DateTime.Now.ToString() + name + surname + patronymic);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                Id = hash;
            }
        }
        public PersonClass()
        {
            Name = "John";
            Surname = "Doe";
            Patronymic = null;
            BirthPlace = "Nowhere";
            Status = StatusEnum.single;
            PassportData = "0000 000000";
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(DateTime.Now.ToString() + Name + Surname + Patronymic);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                Id = hash;
            }
        }

        public void ChangeStatus(StatusEnum status)
        {
            Status = status;
        }
    }
}