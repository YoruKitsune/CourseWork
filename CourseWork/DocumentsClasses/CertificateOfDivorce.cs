using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfDivorce : CertificateClass
    {
        public string GettedSurname {  get; private set; }

        public CertificateOfDivorce(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, string gettedSurname) : base(series, number, issueDate, issuePlace, actDate, actNumber)
        {
            GettedSurname = gettedSurname;
        }
        public CertificateOfDivorce() : base()
        {
            GettedSurname = "";
        }
    }
}