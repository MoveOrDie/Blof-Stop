using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class InvoiceInterent : Invoice 
    {
        private string ServiceProviderName;
        private double ServiceProviderPrice;
        private string FoundationProviderName;
        private double FoundationProviderPrice;
        private bool IsBndle;
        private int InternetSpeedGB;
        private double PerModemFee;
        private double InstallationFee;

    }
}