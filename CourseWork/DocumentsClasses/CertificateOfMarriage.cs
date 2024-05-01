using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfMarriage : CertificateClass
    {
        public string BrideSurname {  private set; get; }
        public string GroomSurname { private set; get; }

        public string GroomOldSurname { private set; get; }

        public string BrideOldSurname { private set; get; }

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
            GroomOldSurname = "";
            GroomSurname = "";
            BrideSurname = "";
            BrideOldSurname = "";
        }
    }
}