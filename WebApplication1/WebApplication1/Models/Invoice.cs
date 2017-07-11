using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    abstract public class Invoice
    {
        public int InvoiceNumber;
        public string InvoiceName;
        public DateTime InvoiceDate;
        public int UserId;
        public double TotalPrice;
        public string FreeText;
        public DateTime DateUploaded;
        public string[] IvoicePicture = new string[5];
    }   
}