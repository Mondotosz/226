using System;

namespace SimpleBank
{
    public class RecurringPayment
    {
        private Account _account;
        private double _amount;
        private DateTime _firstOccurrence;
        private TimeSpan _recurringDuration;

        public RecurringPayment(Account account, double amount)
        {
            throw new NotImplementedException();
        }

        public DateTime FirstOccurrence
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public TimeSpan RecurringDuration
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void TriggerPayment(DateTime dueDate)
        {
            throw new NotImplementedException();
        }
    }
}
