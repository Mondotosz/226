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
            _account = account;
            _amount = amount;
        }

        public DateTime FirstOccurrence
        {
            get => _firstOccurrence;
            set { throw new NotImplementedException(); }
        }

        public TimeSpan RecurringDuration
        {
            get => _recurringDuration;
            set { throw new NotImplementedException(); }
        }

        public void TriggerPayment(DateTime dueDate)
        {
            throw new NotImplementedException();
        }
    }
}
