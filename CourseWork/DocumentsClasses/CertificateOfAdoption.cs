using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfAdoption : CertificateClass
    {
   
        public PersonClass Stepmother {  get; private set; }
        

        public PersonClass Stepfather { get; private set; }
 
        public CertificateOfAdoption(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, PersonClass stepfather, PersonClass stepmother) : base(series, number, issueDate, issuePlace, actDate, actNumber)
        {
            Stepfather = stepfather;
            Stepmother = stepmother;

        }
        public CertificateOfAdoption() : base()
        {
            Stepmother = new PersonClass();
            Stepfather = new PersonClass();
        }
    }
}