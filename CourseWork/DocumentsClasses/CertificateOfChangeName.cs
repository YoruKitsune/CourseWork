using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfChangeName : CertificateClass
    {
        private string newname,newsurname,newpatronymic;
        public string NewName
        {
            private set
            {
                if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) newname = value;
                else throw new ArgumentException("Имя неккоректно!");
            }
            get { return newname; }
        }
        public string NewSurname
        {
            private set { if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) newsurname = value; else throw new ArgumentException("Фамилия неккоректна!"); }
            get { return newsurname; }
        }
        public string NewPatronymic
        {
            private set { if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success || value == "") newpatronymic = value; else throw new ArgumentException("Отчество неккоректно!"); }
            get { return newpatronymic; }
        }

        public CertificateOfChangeName(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, string newName, string newSurname, string newPatronymic) : base(series, number, issueDate, issuePlace, actDate, actNumber)
        {
            NewName = newName;
            NewSurname = newSurname;
            NewPatronymic = newPatronymic;

        }
        public CertificateOfChangeName() : base()
        {
            NewName = "Иван";
            NewPatronymic = "Иванович";
            NewSurname = "Иванов";
        }
    }
}