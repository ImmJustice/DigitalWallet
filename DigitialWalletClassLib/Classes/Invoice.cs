using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitialWalletClassLib
{
    class Invoice
    {
        private string _accountFrom { get; set; }
        private string _accountTo { get; set; }
        private double _amount { get; set; }
        private DateTime _dateIssued { get; set; }
        private string _invoiceNo { get; set; }
    }
}
