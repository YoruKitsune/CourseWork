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
        public static object CreateCertificate<T>(T referenceClass, params object[] args)
        {


            try
            {

                switch (referenceClass.GetType().ToString())
                {
                    case "CourseWork.DocumentsClasses.CertificateOfAdoption":
                        return CertificateManager.CreateCertificate((int)args[0], (int)args[1], (DateTime)args[2], (string)args[3], (DateTime)args[4], (int)args[5], (PersonClass)args[6], (PersonClass)args[7]);

                    case "CourseWork.DocumentsClasses.CertificateOfBirth":
                        return CertificateManager.CreateCertificate((int)args[0], (int)args[1], (DateTime)args[2], (string)args[3], (DateTime)args[4], (int)args[5], (PersonClass)args[6], (PersonClass)args[7], (DateTime)args[8]);

                    case "CourseWork.DocumentsClasses.CertificateOfDeath":

                        return CertificateManager.CreateCertificate((int)args[0], (int)args[1], (DateTime)args[2], (string)args[3], (DateTime)args[4], (int)args[5], (string)args[6], (DateTime)args[7]);
                    case "CourseWork.DocumentsClasses.CertificateOfChangeName":

                        return CertificateManager.CreateCertificate((int)args[0], (int)args[1], (DateTime)args[2], (string)args[3], (DateTime)args[4], (int)args[5], (string)args[6], (string)args[7], (string)args[8]);
                    case "CourseWork.DocumentsClasses.CertificateOfDivorce":

                        return CertificateManager.CreateCertificate((int)args[0], (int)args[1], (DateTime)args[2], (string)args[3], (DateTime)args[4], (int)args[5], (string)args[6]);
                    case "CourseWork.DocumentsClasses.CertificateOfEstablishingPaternity":

                        return CertificateManager.CreateCertificate((int)args[0], (int)args[1], (DateTime)args[2], (string)args[3], (DateTime)args[4], (int)args[5], (PersonClass)args[6]);
                    case "CourseWork.DocumentsClasses.CertificateOfMarriage":

                        return CertificateManager.CreateCertificate((int)args[0], (int)args[1], (DateTime)args[2], (string)args[3], (DateTime)args[4], (int)args[5], (PersonClass)args[6], (PersonClass)args[7],(string)args[8], (string)args[9]);
                    default:
                        ConsoleUserInterface.ErrorMsg("Неккоректные данные");
                        return CertificateManager.CreateCertificate((int)args[0], (int)args[1], (DateTime)args[2], (string)args[3], (DateTime)args[4], (int)args[5], (PersonClass)args[6], (PersonClass)args[7]);
                }
            }
            catch (Exception e)
            {
                ConsoleUserInterface.ErrorMsg("Неккоректные данные");
                return -1;
            }


        }
    }
}
