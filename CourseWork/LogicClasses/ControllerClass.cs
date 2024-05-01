using CourseWork.DocumentsClasses;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.LogicClasses
{
    internal class ControllerClass
    {
        private DatabaseManager _db;
        private ConsoleUserInterface _cUI;
        public ControllerClass(ConsoleUserInterface UI)
        {
            _cUI = UI;
            _db = new DatabaseManager();
           
        }
        public void InitialCreateCertificate(object referenceClass)
        {

            switch (referenceClass.GetType().ToString())
            {
                case "CourseWork.DocumentsClasses.CertificateOfAdoption":
                    var stepfather = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные отчима"));
                    var stepmother = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные мачехи"));
                    _db.CreateCertificate(
                        CreateCertificate(referenceClass, _cUI.GetInformationFromConsole("серию свидетельства"), _cUI.GetInformationFromConsole("номер свидетельства"), 
                        _cUI.GetInformationFromConsole("дату выдачи свидетельства"), _cUI.GetInformationFromConsole("место выдачи свидетельства"), 
                        _cUI.GetInformationFromConsole("дату внесения акта свидетельства"), _cUI.GetInformationFromConsole("номер акта свидетельства"),
                        stepfather, stepmother),

                        stepfather, stepmother);
                    _cUI.Return();
                    break;
                case "CourseWork.DocumentsClasses.CertificateOfBirth":
                    var father = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные отца"));
                    var mother = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные матери"));
                    _db.CreateCertificate(
                        CreateCertificate(referenceClass, _cUI.GetInformationFromConsole("серию свидетельства"), _cUI.GetInformationFromConsole("номер свидетельства"),
                        _cUI.GetInformationFromConsole("дату выдачи свидетельства"), _cUI.GetInformationFromConsole("место выдачи свидетельства"),
                        _cUI.GetInformationFromConsole("дату внесения акта свидетельства"), _cUI.GetInformationFromConsole("номер акта свидетельства"),
                        father, mother, _cUI.GetInformationFromConsole("дату рождения")),

                        father, mother);
                    _cUI.Return();
                    break;

                case "CourseWork.DocumentsClasses.CertificateOfDeath":
                    var personDied = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные умершего"));
                    _db.CreateCertificate(
                       CreateCertificate(referenceClass, _cUI.GetInformationFromConsole("серию свидетельства"), _cUI.GetInformationFromConsole("номер свидетельства"),
                        _cUI.GetInformationFromConsole("дату выдачи свидетельства"), _cUI.GetInformationFromConsole("место выдачи свидетельства"),
                        _cUI.GetInformationFromConsole("дату внесения акта свидетельства"), _cUI.GetInformationFromConsole("номер акта свидетельства"),
                        _cUI.GetInformationFromConsole("дату смерти")),

                        personDied);
                    _cUI.Return();
                    break;

                case "CourseWork.DocumentsClasses.CertificateOfChangeName":
                    var personChangedName = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные умершего"));
                    _db.CreateCertificate(
                       CreateCertificate(referenceClass, _cUI.GetInformationFromConsole("серию свидетельства"), _cUI.GetInformationFromConsole("номер свидетельства"),
                        _cUI.GetInformationFromConsole("дату выдачи свидетельства"), _cUI.GetInformationFromConsole("место выдачи свидетельства"),
                        _cUI.GetInformationFromConsole("дату внесения акта свидетельства"), _cUI.GetInformationFromConsole("номер акта свидетельства"),
                        _cUI.GetInformationFromConsole("новое имя"), _cUI.GetInformationFromConsole("новую фамилию"), _cUI.GetInformationFromConsole("новое отчество")),

                        personChangedName);
                    _cUI.Return();
                    break;
                case "CourseWork.DocumentsClasses.CertificateOfDivorce":
                    var personDevorced = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные разведённого"));
                    
                    _db.CreateCertificate(
                        CreateCertificate(referenceClass, _cUI.GetInformationFromConsole("серию свидетельства"), _cUI.GetInformationFromConsole("номер свидетельства"),
                        _cUI.GetInformationFromConsole("дату выдачи свидетельства"), _cUI.GetInformationFromConsole("место выдачи свидетельства"),
                        _cUI.GetInformationFromConsole("дату внесения акта свидетельства"), _cUI.GetInformationFromConsole("номер акта свидетельства"),
                        _cUI.GetInformationFromConsole("новую фамилию")),

                        personDevorced);
                    _cUI.Return();
                    break;

                case "CourseWork.DocumentsClasses.CertificateOfEstablishingPaternity":

                    var personParent = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные умершего"));
                    _db.CreateCertificate(
                       CreateCertificate(referenceClass, _cUI.GetInformationFromConsole("серию свидетельства"), _cUI.GetInformationFromConsole("номер свидетельства"),
                        _cUI.GetInformationFromConsole("дату выдачи свидетельства"), _cUI.GetInformationFromConsole("место выдачи свидетельства"),
                        _cUI.GetInformationFromConsole("дату внесения акта свидетельства"), _cUI.GetInformationFromConsole("номер акта свидетельства")),

                        personParent);
                    _cUI.Return();
                    break;

                case "CourseWork.DocumentsClasses.CertificateOfMarriage":
                    var bride = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные отчима"));
                    var groom = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные мачехи"));
                    _db.CreateCertificate(
                        CreateCertificate(referenceClass, _cUI.GetInformationFromConsole("серию свидетельства"), _cUI.GetInformationFromConsole("номер свидетельства"),
                        _cUI.GetInformationFromConsole("дату выдачи свидетельства"), _cUI.GetInformationFromConsole("место выдачи свидетельства"),
                        _cUI.GetInformationFromConsole("дату внесения акта свидетельства"), _cUI.GetInformationFromConsole("номер акта свидетельства"),
                        bride, groom, _cUI.GetInformationFromConsole("новую фамилию невесты"), _cUI.GetInformationFromConsole("новую фамилию жениха")),

                        bride, groom);
                    _cUI.Return();
                    break;
                default:
                    ConsoleUserInterface.ErrorMsg("Неккоректные данные");
                    return;
            }

        }
        public static object CreateCertificate(object referenceClass, params object[] args)
        {

            

                switch (referenceClass.GetType().ToString())
                {
                    case "CourseWork.DocumentsClasses.CertificateOfAdoption":
                        return CertificateManager.CreateCertificate(Int32.Parse((string)args[0]), Int32.Parse((string)args[1]), DateTime.Parse((string)args[2]), (string)args[3], DateTime.Parse((string)args[2]), Int32.Parse((string)args[5]), (PersonClass)args[6], (PersonClass)args[7]);

                    case "CourseWork.DocumentsClasses.CertificateOfBirth":
                        return CertificateManager.CreateCertificate(Int32.Parse((string)args[0]), Int32.Parse((string)args[1]), DateTime.Parse((string)args[2]), (string)args[3], DateTime.Parse((string)args[2]), Int32.Parse((string)args[5]), (PersonClass)args[6], (PersonClass)args[7], DateTime.Parse((string)args[8]));

                    case "CourseWork.DocumentsClasses.CertificateOfDeath":

                        return CertificateManager.CreateCertificate(Int32.Parse((string)args[0]), Int32.Parse((string)args[1]), DateTime.Parse((string)args[2]), (string)args[3], DateTime.Parse((string)args[2]), Int32.Parse((string)args[5]), (string)args[6], DateTime.Parse((string)args[7]));
                    case "CourseWork.DocumentsClasses.CertificateOfChangeName":

                        return CertificateManager.CreateCertificate(Int32.Parse((string)args[0]), Int32.Parse((string)args[1]), DateTime.Parse((string)args[2]), (string)args[3], DateTime.Parse((string)args[2]), Int32.Parse((string)args[5]), (string)args[6], (string)args[7], (string)args[8]);
                    case "CourseWork.DocumentsClasses.CertificateOfDivorce":

                        return CertificateManager.CreateCertificate(Int32.Parse((string)args[0]), Int32.Parse((string)args[1]), DateTime.Parse((string)args[2]), (string)args[3], DateTime.Parse((string)args[2]), Int32.Parse((string)args[5]), (string)args[6]);
                    case "CourseWork.DocumentsClasses.CertificateOfEstablishingPaternity":

                        return CertificateManager.CreateCertificate(Int32.Parse((string)args[0]), Int32.Parse((string)args[1]), DateTime.Parse((string)args[2]), (string)args[3], DateTime.Parse((string)args[2]), Int32.Parse((string)args[5]), (PersonClass)args[6]);
                    case "CourseWork.DocumentsClasses.CertificateOfMarriage":

                        return CertificateManager.CreateCertificate(Int32.Parse((string)args[0]), Int32.Parse((string)args[1]), DateTime.Parse((string)args[2]), (string)args[3], DateTime.Parse((string)args[2]), Int32.Parse((string)args[5]), (PersonClass)args[6], (PersonClass)args[7], (string)args[8], (string)args[9]);
                    default:
                        ConsoleUserInterface.ErrorMsg("Неккоректные данные");
                        return -1;
                }
            }
         


        
    }
}
