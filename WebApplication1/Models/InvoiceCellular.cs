using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class InvoiceCellular : Invoice
    {
        private int SubNumber;
        private bool UnlimitedCalls;
        private bool UnlimitedSms;
        private bool UnlimitedInternet;
        private int MinutePack;
        private int SmsPack;
        private int InternetPackGB;
        private int AbroadPackMinutes;
    }
}