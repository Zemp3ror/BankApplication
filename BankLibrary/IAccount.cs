using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public interface IAccount
    {
        
        void Put(decimal sum); //Положить деньги на счёт
        decimal Withdraw(decimal sum); //Взять со счёта
    }
}
