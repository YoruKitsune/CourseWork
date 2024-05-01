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
        public ConsoleUserInterface _cUI { private set; get; }
        public ControllerClass(ConsoleUserInterface UI)
        {
            _cUI = UI;
            _db = new DatabaseManager(this);

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
                        _cUI.GetInformationFromConsole("место смерти"), _cUI.GetInformationFromConsole("дату смерти")),

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
                    var bride = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные невесты"));
                    var groom = _db.FindPerson((string)_cUI.GetInformationFromConsole("паспортные данные жениха"));
                    _db.CreateCertificate(
                        CreateCertificate(referenceClass, _cUI.GetInformationFromConsole("серию свидетельства"), _cUI.GetInformationFromConsole("номер свидетельства"),
                        _cUI.GetInformationFromConsole("дату выдачи свидетельства"), _cUI.GetInformationFromConsole("место выдачи свидетельства"),
                        _cUI.GetInformationFromConsole("дату внесения акта свидетельства"), _cUI.GetInformationFromConsole("номер акта свидетельства"),
                        bride, groom, _cUI.GetInformationFromConsole("новую фамилию невесты"), _cUI.GetInformationFromConsole("новую фамилию жениха")),

                        bride, groom);
                    _cUI.Return();
                    break;
                default:
                    _cUI.ErrorMsg("Неккоректные данные");
                    return;
            }

        }
        public object CreateCertificate(object referenceClass, params object[] args)
        {

            try
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
                        _cUI.ErrorMsg("Неккоректные данные");
                        return -1;
                }
            }
            catch (Exception ex)
            {
                _cUI.ErrorMsg("Неккоректные данные");
                return -1;

            }
        }

        public void InitialCreatePerson()
        {
            try
            {
                var name = (string)_cUI.GetInformationFromConsole("имя");
                var surname = (string)_cUI.GetInformationFromConsole("фамилию");
                var patronymic = (string)_cUI.GetInformationFromConsole("отчество");
                var birthdate = DateTime.Parse((string)_cUI.GetInformationFromConsole("дату рождения"));
                var birthplace = (string)_cUI.GetInformationFromConsole("место рождения");
                var passportData = (string)_cUI.GetInformationFromConsole("паспортные данные");
                var nationality = (string)_cUI.GetInformationFromConsole("национальность");
                var status = StatusEnum.single;
                switch (_cUI.GetInformationFromConsole("состояние(холост, женат, разведён, вдовец, мёртв").ToString().ToLower())
                {
                    case "холост":
                        status = StatusEnum.single;
                        break;
                    case "женат":
                        status = StatusEnum.married;
                        break;
                    case "разведён":
                        status = StatusEnum.divorced;
                        break;
                    case "вдовец":
                        status = StatusEnum.widower;
                        break;
                    case "мёртв":
                        status = StatusEnum.dead;
                        break;
                    default:
                        _cUI.ErrorMsg("Неверные данные!");
                        return;

                }
                PersonClass newPerson = new PersonClass(name, surname, patronymic, birthplace, birthdate, passportData, nationality, status);
                _db.CreatePerson(newPerson);
                _cUI.Return();
            }
            catch (Exception e)
            {
                _cUI.ErrorMsg(e.Message);
                _cUI.Return();
            }

        }

        public void FindCertificate()
        {
       
            try
            {
                var gettedCertificate = _db.FindCertificate(Int32.Parse((string)_cUI.GetInformationFromConsole("серию свидетельства")), Int32.Parse((string)_cUI.GetInformationFromConsole("номер свидетельства")));
                var certificateCommon = (CertificateClass)gettedCertificate;
                _cUI.PrintMsg($"Серия: {certificateCommon.Series} \n" +
                $"Номер: {certificateCommon.Number}\n" +
                $"Дата выдачи: {certificateCommon.IssueDate}\n" +
                $"Место выдачи: {certificateCommon.IssuePlace}\n" +
                $"Дата составления акта: {certificateCommon.DateOfAct}\n" +
                $"Номер акта: {certificateCommon.NumberOfAct}\n", true);
           

            switch (gettedCertificate.GetType().ToString())
            {
                case "CourseWork.DocumentsClasses.CertificateOfAdoption":
                    var CertificateOfAdoption = (CertificateOfAdoption)gettedCertificate;
                    _cUI.PrintMsg($"Отчим: {CertificateOfAdoption.Stepfather.Name} {CertificateOfAdoption.Stepfather.Surname} {CertificateOfAdoption.Stepfather.Patronymic} \n" +
                                    $"Мачиха: {CertificateOfAdoption.Stepmother.Name} {CertificateOfAdoption.Stepmother.Surname} {CertificateOfAdoption.Stepmother.Patronymic}\n", false);
                    break;

                case "CourseWork.DocumentsClasses.CertificateOfBirth":
                    var CertificateOfBirth = (CertificateOfBirth)gettedCertificate;
                    _cUI.PrintMsg($"Отец: {CertificateOfBirth.Father.Name} {CertificateOfBirth.Father.Surname} {CertificateOfBirth.Father.Patronymic} \n" +
                                $"Мать: {CertificateOfBirth.Mother.Name} {CertificateOfBirth.Mother.Surname} {CertificateOfBirth.Mother.Patronymic}\n" +
                                $"Дата рождения: {CertificateOfBirth.DateOfBirth} \n", false);
                    break;

                case "CourseWork.DocumentsClasses.CertificateOfDeath":
                    var CertificateOfDeath = (CertificateOfDeath)gettedCertificate;
                    _cUI.PrintMsg($"Место смерти: {CertificateOfDeath.DeathPlace} \n" +
                                $"Дата смерти: {CertificateOfDeath.DeathDate} \n", false);
                    break;

                case "CourseWork.DocumentsClasses.CertificateOfChangeName":
                    var CertificateOfChangeName = (CertificateOfChangeName)gettedCertificate;
                    _cUI.PrintMsg($"Новое имя: {CertificateOfChangeName.NewName} \n" +
                                $"Новая фамилия: {CertificateOfChangeName.NewSurname} \n" +
                                $"Новое отчество: {CertificateOfChangeName.NewPatronymic}", false);
                    break;

                case "CourseWork.DocumentsClasses.CertificateOfDivorce":
                    var CertificateOfDivorce = (CertificateOfDivorce)gettedCertificate;
                    _cUI.PrintMsg($"Новое имя: {CertificateOfDivorce.GettedSurname} \n", false);
                    break;

                case "CourseWork.DocumentsClasses.CertificateOfEstablishingPaternity":

                    var CertificateOfEstablishingPaternity = (CertificateOfEstablishingPaternity)gettedCertificate;
                    _cUI.PrintMsg($"Отец: {CertificateOfEstablishingPaternity.Father.Name} {CertificateOfEstablishingPaternity.Father.Surname} {CertificateOfEstablishingPaternity.Father.Patronymic} \n", true);

                    break;
                case "CourseWork.DocumentsClasses.CertificateOfMarriage":
                    var CertificateOfMarriage = (CertificateOfMarriage)gettedCertificate;
                    _cUI.PrintMsg($"Жених: {CertificateOfMarriage.Groom.Name} {CertificateOfMarriage.Groom.Surname} {CertificateOfMarriage.Groom.Patronymic} \n" +
                                $"Невеста: {CertificateOfMarriage.Bride.Name} {CertificateOfMarriage.Bride.Surname} {CertificateOfMarriage.Bride.Patronymic}\n" +
                                $"Новая фамилия жениха: {CertificateOfMarriage.GroomSurname} \n" +
                                $"Новая фамилия невесты: {CertificateOfMarriage.BrideSurname} \n", false);
                    break;

                default:
                    _cUI.ErrorMsg("Свидетельство не найдено!");
                    return;
            }
            _cUI.AwaitButton();
            _cUI.Return();
            }
            catch (Exception ex)
            {
                _cUI.ErrorMsg("Свидетельство не найдено!");
                return;

            }
        }

        public void FindPerson()
        {
            var findedPerson = _db.FindPerson((string)_cUI.GetInformationFromConsole("данные паспорта"));
            if (findedPerson != null)
            {
                _cUI.PrintMsg($"Имя: {findedPerson.Name}\n" +
                    $"Фамилия: {findedPerson.Surname}\n" +
                    $"Отчество: {findedPerson.Patronymic}\n" +
                    $"Дата рождения: {findedPerson.BirthDate}\n" +
                    $"Место рождения: {findedPerson.BirthPlace}\n" +
                    $"Данные паспорта: {findedPerson.PassportData}\n" +
                    $"Национальность: {findedPerson.Nationality}\n" +
                    $"Состояние: {findedPerson.Status}\n", true);
            }
            else
            {
                _cUI.ErrorMsg("Гражданин не найден");
            }
            _cUI.AwaitButton();
            _cUI.Return();
        }

    }
}
