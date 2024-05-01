using CourseWork.DocumentsClasses;


namespace CourseWork.LogicClasses
{
    internal class CertificateManager
    {
        public static CertificateOfAdoption CreateCertificate(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, PersonClass stepfather, PersonClass stepmother)
        { 
            return new CertificateOfAdoption(series, number, issueDate, issuePlace, actDate, actNumber, stepfather, stepmother);
        }
        public static CertificateOfBirth CreateCertificate(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, PersonClass father, PersonClass mother, DateTime dateOfBirth)
        {
            return new CertificateOfBirth(series, number, issueDate, issuePlace, actDate, actNumber, father, mother, dateOfBirth);
        }
        public static CertificateOfChangeName CreateCertificate(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, string newName, string newSurname, string newPatronymic)
        {
            return new CertificateOfChangeName(series,number,issueDate, issuePlace, actDate, actNumber, newName, newSurname, newPatronymic);
        }
        public static CertificateOfDeath CreateCertificate(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, string deathPlace, DateTime deathTime)
        {
            return new CertificateOfDeath(series, number, issueDate, issuePlace, actDate, actNumber, deathPlace, deathTime);
        }
        public  static CertificateOfDivorce CreateCertificate(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, string gettedSurname)
        {
            return new CertificateOfDivorce(series, number, issueDate, issuePlace, actDate, actNumber, gettedSurname);
        }
        public static CertificateOfEstablishingPaternity CreateCertificate(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, PersonClass father)
        {
            return new CertificateOfEstablishingPaternity(series, number, issueDate, issuePlace, actDate, actNumber, father);
        }
        public static CertificateOfMarriage CreateCertificate(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, PersonClass groom, PersonClass bride, string brideSurname, string groomSurname)
        {
            return new CertificateOfMarriage(series, number, issueDate, issuePlace, actDate, actNumber, groom, bride, brideSurname, groomSurname);
        }

    }
    
}
