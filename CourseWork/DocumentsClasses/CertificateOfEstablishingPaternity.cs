using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfEstablishingPaternity : CertificateClass
    {
        public PersonClass Father { get; private set; }

        public CertificateOfEstablishingPaternity(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, PersonClass father) : base(series, number, issueDate, issuePlace, actDate, actNumber)
        {
            Father = father;
        }
        public CertificateOfEstablishingPaternity() : base()
        {
            Father = new PersonClass();
        }

    }
}