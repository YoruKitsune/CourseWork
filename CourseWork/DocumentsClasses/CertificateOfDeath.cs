using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CourseWork.DocumentsClasses
{
    public class CertificateOfDeath : CertificateClass
    {
        private DateTime deathdate;
        private string deathplace;
        public string DeathPlace
        {
            private set
            {
                if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) deathplace = value;
                else throw new ArgumentException("Место смерти неккоректно!");
            }
            get { return deathplace; }
        }
        public DateTime DeathDate
        {
            private set { if (value > DateTime.Now) throw new ArgumentException("Дата неккоректна!"); else deathdate = value; }
            get { return deathdate; }
        }

        public CertificateOfDeath(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber, string deathPlace, DateTime deathDate) : base(series, number, issueDate, issuePlace, actDate, actNumber)
        {
            DeathPlace = deathPlace;
            DeathDate = deathDate;
        }
        public CertificateOfDeath() : base()
        {
            DeathPlace = "Нигде";
            DeathDate = DateTime.Now;
        }
    }
}