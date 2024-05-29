using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace CourseWork.DocumentsClasses
{
    public class PersonClass
    {
        public string Id { set; get; }
        private string name, surname, birthplace, passportdata, nationality;
        private string? patronymic;
        private DateTime birthdate;
        public string Name
        {
            private set { 
                if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) name = value; 
                else throw new ArgumentException("Имя неккоректно!"); }
            get { return name; }
        }
        public string Surname
        {
            private set { if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) surname = value; else throw new ArgumentException("Фамилия неккоректна!"); }
            get { return surname; }
        }
        public string? Patronymic
        {
            private set { if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success || value == "") patronymic = value; else throw new ArgumentException("Отчество неккоректно!"); }
            get { return patronymic; }
        }
        public  DateTime BirthDate { 
            private set { if(value > DateTime.Now) throw new ArgumentException("Дата неккоректна!"); else birthdate = value; }
            get { return birthdate; }
        }
        public string BirthPlace
        {
            private set { if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) birthplace = value; else throw new ArgumentException("Место рождения неккоректно!"); }
            get { return birthplace; }
        }
        public string PassportData
        {
            private set { if (Regex.Match(value, @"\d{4}\s\d{6}", RegexOptions.IgnoreCase).Success) passportdata = value; else throw new ArgumentException("Данные паспорта неккоректны!"); }
            get { return passportdata; }
        }
        public string? Nationality
        {
            private set { if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) nationality = value; else throw new ArgumentException("Национальность неккоректна!"); }
            get { return nationality; }
        }
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
            Name = "Иван";
            Surname = "Иванов";
            Patronymic = "";
            BirthPlace = "Простоквашино";
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