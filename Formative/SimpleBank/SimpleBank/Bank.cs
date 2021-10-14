using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleBank
{
    public class Bank
    {
        private List<Account> _accounts;
        private List<RecurringPayment> _recurringPayments;
        
        public Bank(){
            _accounts = new List<Account>();
            _recurringPayments = new List<RecurringPayment>();
        }

        public double TotalBalance {
            get => _accounts.Sum(account => account.Balance);
        }

        public void TriggerPayments(DateTime dueDate){
            throw new NotImplementedException();
        }
    }
}
