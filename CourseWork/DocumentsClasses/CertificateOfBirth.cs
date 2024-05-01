using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfBirth : CertificateClass
    {
        private DateTime dateofbirth;
        public PersonClass Father { get; private set; }
       
        public PersonClass Mother { get; private set; }
       
        public DateTime DateOfBirth
        {
            private set { if (value > DateTime.Now) throw new ArgumentException("Дата неккоректна!"); else dateofbirth = value; }
            get { return dateofbirth; }
        }
        public CertificateOfBirth(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, PersonClass father, PersonClass mother, DateTime dateOfBith) : base(series, number, issueDate, issuePlace, actDate, actNumber)
        {
            Father = father;
            Mother = mother;
            DateOfBirth = dateOfBith;
        }
        public CertificateOfBirth() : base()
        {
            Father = new PersonClass();
            Mother = new PersonClass();
            DateOfBirth = DateTime.Now;
        }
    }
}