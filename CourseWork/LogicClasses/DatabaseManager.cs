using CourseWork.DocumentsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CourseWork.LogicClasses
{
    internal class DatabaseManager
    {
        private ApplicationContext _db;

        public DatabaseManager()
        {
            InitDataBase();
        }
        private void InitDataBase()
        {
            if (_db == null) _db = new ApplicationContext();
        }
        public void CreateCertificate(object Certificate) 
        { 
            var objectType = Certificate.GetType().ToString();

            switch (objectType)
            {
                case "CourseWork.DocumentsClasses.CertificateOfAdoption":
                    _db.CertificateOfAdoption.Add((CertificateOfAdoption)Certificate);
                    break;
                case "CourseWork.DocumentsClasses.CertificateOfBirth":
                    _db.CertificatesOfBirth.Add((CertificateOfBirth)Certificate);
                    break;
                case "CourseWork.DocumentsClasses.CertificateOfDeath":
                    _db.CertificateOfDeath.Add((CertificateOfDeath)Certificate);
                    break;
                case "CourseWork.DocumentsClasses.CertificateOfChangeName":
                    _db.CertificateOfChangeName.Add((CertificateOfChangeName)Certificate);
                    break;
                case "CourseWork.DocumentsClasses.CertificateOfDivorce":
                    _db.CertificateOfDivorce.Add((CertificateOfDivorce)Certificate);
                    break;
                case "CourseWork.DocumentsClasses.CertificateOfEstablishingPaternity":
                    _db.CertificateOfEstablishingPaternity.Add((CertificateOfEstablishingPaternity)Certificate);
                    break;
                case "CourseWork.DocumentsClasses.CertificateOfMarriage":
                    _db.CertificateOfMarriage.Add((CertificateOfMarriage)Certificate);
                    break;
                default:
                    ConsoleUserInterface.ErrorMsg("Неккоректные данные");
                    break;
            }
            _db.SaveChanges();


        }
        public void BrokeCertificate(object Certificate)
        {

        }
        public void CreatePerson()
        {
        
        }
        public void UpdatePerson()
        {

        }
        public PersonClass FindPerson(string passportData)
        {
            var Persons = _db.Persons.ToList();
            PersonClass findedPerson = null;
            foreach (var Person in Persons)
            {
                if (Person.PassportData == passportData) findedPerson = Person;
                break;
            }
            return findedPerson;
        }
        public void FindCertificate()
        {

        }
      
        
    
    }
}
