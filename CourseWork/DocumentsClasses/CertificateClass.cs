using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace CourseWork.DocumentsClasses
{
    public abstract class CertificateClass
    {
        private int series, number, numberofact;
        private string issueplace;
        private DateTime issuedate, dateofact;
        public int Series
        {
            private set { if (value > 999 && value < 10000) series = value; else throw new ArgumentException("Серия свидетельства неккоректна!"); }
            get { return series; }
        }
        public int Number
        {
            private set { if (value > 99999 && value < 1000000) number = value; else throw new ArgumentException("Номер свидетельства неккоректен!"); }
            get { return number; }
        }
        public DateTime IssueDate
        {
            private set { if (value > DateTime.Now) throw new ArgumentException("Дата выдачи неккоректна!"); else issuedate = value; }
            get { return issuedate; }
        }
        public string IssuePlace
        {
            private set
            {
                if (Regex.Match(value, @"[а-яёА-ЯË]{2,20}", RegexOptions.IgnoreCase).Success) issueplace = value; else throw new ArgumentException("Место рождения неккоректно!");
            }
            get { return issueplace; }
        }
        public DateTime DateOfAct
        {
            private set { if (value > DateTime.Now) throw new ArgumentException("Дата записи акта неккоректна!"); else dateofact = value; }
            get { return dateofact; }
        }
        public int NumberOfAct
        {
            private set { if (value >= 0) numberofact = value; else throw new ArgumentException("Номер акта неккоректен!"); }
            get { return numberofact; }
        }

        public CertificateClass(int series, int number, DateTime issueDate, string issuePlace, DateTime actDate, int actNumber)
        {
            this.Series = series;
            this.Number = number;
            this.IssueDate = issueDate;
            this.IssuePlace = issuePlace;
            this.NumberOfAct = actNumber;
            this.DateOfAct = actDate;
        }
        public CertificateClass()
        {
            this.Series = 9999;
            this.Number = 999999;
            this.IssueDate = DateTime.Now;
            this.IssuePlace = "Нигде";
            this.NumberOfAct = 999999999;
            this.DateOfAct = DateTime.Now;
        }
    }
}