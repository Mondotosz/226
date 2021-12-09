using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkg
{
    public class Valet
    {
        private string _name;
        private bool _available;

        public Valet(string name)
        {
            _name = name;
            _available = true;
        }

        public bool Available
        {
            get => _available;
        }

        public async void Drive(Vehicle vehicle)
        {
            _available = false;
            await Task.Delay(5 * 60 * 1000);
            _available = true;
        }

        public async void CaughtCovid()
        {
            _available = false;
            await Task.Delay(2 * 7 * 24 * 60 * 60 * 1000);
            _available = true;
        }
    }
}
