using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfBirth : CertificateClass
    {
        public PersonClass Father { get; private set; }
       
        public PersonClass Mother { get; private set; }
       
        public DateTime DateOfBith {  get; private set; }
        public CertificateOfBirth(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, PersonClass father, PersonClass mother, DateTime dateOfBith) : base(series, number, issueDate, issuePlace, actDate, actNumber)
        {
            Father = father;
            Mother = mother;
            DateOfBith = dateOfBith;
        }
        public CertificateOfBirth()
        {
            throw new NotImplementedException();
        }
    }
}