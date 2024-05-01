using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfChangeName : CertificateClass
    {
        public string NewName { get; private set; }
        public string NewSurname { get; private set; }
        public string NewPatronymic {  get; private set; }

        public CertificateOfChangeName(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, string newName, string newSurname, string newPatronymic) : base(series, number, issueDate, issuePlace, actDate, actNumber)
        {
            NewName = newName;
            NewSurname = newSurname;
            NewPatronymic = newPatronymic;

        }
        public CertificateOfChangeName()
        {
            throw new NotImplementedException();
        }
    }
}