using System;

namespace Kino
{
    public class Watcher
    {
        private string _fullName;
        private DateTime _birthDate;

        public Watcher(string fullname, DateTime birthDate)
        {
            _fullName = fullname;
            _birthDate = birthDate;
        }

        public bool IsMajor()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
