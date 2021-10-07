using System;
using System.Collections.Generic;

namespace SimpleBank
{
    public class Bank
    {
        private List<Account> _accounts;
        private List<RecurringPayment> _recurringPayments;
        
        public double TotalBalance {
            get { throw new NotImplementedException();}
        }

        public void TriggerPayment(DateTime dueDate){
            throw new NotImplementedException();
        }
    }
}
