using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CourseWork.DocumentsClasses
{
    public abstract class CertificateClass
    {
        
        public int Series { private set; get; }
        public int Number { private set; get; }
        public DateTime IssueDate { private set; get; }
        public string IssuePlace { private set; get; }
        public DateTime DateOfAct { private set; get; }
        public int NumberOfAct { private set; get; }
       
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
            this.Series = 0;
            this.Number = 0;
            this.IssueDate = DateTime.Now;
            this.IssuePlace = "";
            this.NumberOfAct = 0;
            this.DateOfAct = DateTime.Now; 
        }
    }
}