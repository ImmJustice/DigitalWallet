using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletClassLib
{
    public class Transaction
    {
        private string _accountFrom { get; set; }
        private string _accountTo { get; set; }
        private double _amount { get; set; }
        private DateTime _datePaid { get; set; }
        private string _invoiceNo { get; set; }
    }
}
