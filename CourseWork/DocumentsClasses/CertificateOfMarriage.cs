using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfMarriage : CertificateClass
        
    {
        private string brideSurname, groomSurname, groomOldSurname, brideOldSurname;
        public string BrideSurname
        {
            private set { if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) brideSurname = value; else throw new ArgumentException("Фамилия невесты неккоректна!"); }
            get { return brideSurname; }
        }
        public string GroomSurname
        {
            private set { if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) groomSurname = value; else throw new ArgumentException("Фамилия жениха неккоректна!"); }
            get { return groomSurname; }
        }

        public string GroomOldSurname
        {
            private set { if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) groomOldSurname = value; else throw new ArgumentException("Старая фамилия жениха неккоректна!"); }
            get { return groomOldSurname; }
        }

        public string BrideOldSurname
        {
            private set { if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) brideOldSurname = value; else throw new ArgumentException("Старая фамилия невесты неккоректна!"); }
            get { return brideOldSurname; }
        }

        public PersonClass Bride { private set; get; }

        public PersonClass Groom { private set; get; }

        public CertificateOfMarriage(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, PersonClass groom, PersonClass bride, string brideSurname, string groomSurname) : base(series, number, issueDate, issuePlace, actDate, actNumber)
        {
            Bride = bride;
            Groom = groom;
            BrideSurname = brideSurname;
            GroomSurname = groomSurname;
            GroomOldSurname = groom.Surname;
            BrideOldSurname = bride.Surname;
        }
        public CertificateOfMarriage() : base()
        {
            Bride = new PersonClass();
            Groom = new PersonClass();
            GroomOldSurname = "Иванов";
            GroomSurname = "Иванов";
            BrideSurname = "Иванова";
            BrideOldSurname = "Иванова";
        }
    }
}