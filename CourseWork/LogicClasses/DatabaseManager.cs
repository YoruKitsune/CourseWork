using CourseWork.DocumentsClasses;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        public void CreateCertificate(object Certificate, params PersonClass[] persons)
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
            foreach (var person in _db.Persons)
            {
                foreach (var person2 in persons)
                {
                    if (person2.PassportData == person.PassportData) person2.IssuedCertificates.Add((CertificateClass)Certificate);
                }

            }
            _db.SaveChanges();


        }
        public void BrokeCertificate(object Certificate)
        {

        }
        public void CreatePerson(PersonClass person)
        {
            _db.Persons.Add(person);
            _db.SaveChanges(true);
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
                if (Person.PassportData == passportData)
                {
                    findedPerson = Person;
                    break;
                }
            }
            return findedPerson;
        }
        public object FindCertificate(int series, int number)
        {
            bool finded = false;
            object findedCertificate = null;
            foreach (var Certificate in _db.CertificateOfAdoption.ToList())
            {
                if (Certificate.Series == series && Certificate.Number == number)
                {
                    finded = true;
                    findedCertificate = Certificate;
                    break;
                }
                if (finded) break;
            }
            foreach (var Certificate in _db.CertificatesOfBirth.ToList())
            {
                if (Certificate.Series == series && Certificate.Number == number)
                {
                    finded = true;
                    findedCertificate = Certificate;
                    break;
                }
                if (finded) break;
            }
            foreach (var Certificate in _db.CertificateOfDeath.ToList())
            {
                if (Certificate.Series == series && Certificate.Number == number)
                {
                    finded = true;
                    findedCertificate = Certificate;
                    break;
                }
                if (finded) break;
            }
            foreach (var Certificate in _db.CertificateOfChangeName.ToList())
            {
                if (Certificate.Series == series && Certificate.Number == number)
                {
                    finded = true;
                    findedCertificate = Certificate;
                    break;
                }
                if (finded) break;
            }
            foreach (var Certificate in _db.CertificateOfDivorce.ToList())
            {
                if (Certificate.Series == series && Certificate.Number == number)
                {
                    finded = true;
                    findedCertificate = Certificate;
                    break;
                }
                if (finded) break;
            }
            foreach (var Certificate in _db.CertificateOfEstablishingPaternity.ToList())
            {
                if (Certificate.Series == series && Certificate.Number == number)
                {
                    finded = true;
                    findedCertificate = Certificate;
                    break;
                }
                if (finded) break;
            }
            foreach (var Certificate in _db.CertificateOfMarriage.ToList())
            {
                if (Certificate.Series == series && Certificate.Number == number)
                {
                    finded = true;
                    findedCertificate = Certificate;
                    break;
                }
                if (finded) break;
            }
            return findedCertificate;
        }
        public void FindCertificate()
        {

        }



    }
}
