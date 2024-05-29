using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfDivorce : CertificateClass
    {
        private string gettedSurname;
        public string GettedSurname
        {
            private set { if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) gettedSurname = value; else throw new ArgumentException("Фамилия неккоректна!"); }
            get { return gettedSurname; }
        }

        public CertificateOfDivorce(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, string gettedSurname) : base(series, number, issueDate, issuePlace, actDate, actNumber)
        {
            GettedSurname = gettedSurname;
        }
        public CertificateOfDivorce() : base()
        {
            GettedSurname = "Иванов";
        }
    }
}