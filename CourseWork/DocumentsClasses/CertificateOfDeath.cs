using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfDeath : CertificateClass
    {
        public string DeathPlace {  get; private set; }
        public DateTime DeathDate { get; private set; }

        public CertificateOfDeath(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, string deathPlace, DateTime deathDate) : base(series, number, issueDate, issuePlace, actDate, actNumber)
        {
            DeathPlace = deathPlace;
            DeathDate = deathDate;
        }
        public CertificateOfDeath()
        {
            throw new NotImplementedException();
        }
    }
}