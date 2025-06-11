using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);
    public class AccountEventArgs
    {
        public string Message { get; } // Сообщение
        public decimal Sum { get; } // Сумма на которую изменился счёт
        public AccountEventArgs(string _message, decimal _sum)
        {
            this.Message = _message;
            this.Sum = _sum;
        }
    }
}
