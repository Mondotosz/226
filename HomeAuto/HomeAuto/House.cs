using System.Collections.Generic;
using System.Linq;

namespace HomeAuto
{
    public class House
    {
        private List<Switch> _switches;

        public House()
        {
            _switches = new List<Switch>();
        }

        public void AddSwitch(string name)
        {
            if (_switches.Where(sw => sw.Name == name).Count() != 0) throw new NameAlreadyTakenException();
            _switches.Add(new Switch(name));
        }

        public void SwitchOn(string name)
        {
            if (_switches.Where(sw => sw.Name == name).Count() <= 0) throw new UnknownNameException();
            _switches.Where(sw => sw.Name == name).First().On();
        }

        public void SwitchOff(string name)
        {
            if (_switches.Where(sw => sw.Name == name).Count() <= 0) throw new UnknownNameException();
            _switches.Where(sw => sw.Name == name).First().Off();
        }

        public void SwitchOnAll()
        {
            _switches.ForEach(sw => { sw.On(); });
        }

        public void SwitchOffAll()
        {
            _switches.ForEach(sw => { sw.Off(); });
        }

        public int SwitchedOnCount
        {
            get => _switches.Where(obj => obj.State == true).Count();
        }

        public int SwitchedOffCount
        {
            get => _switches.Where(obj => obj.State == false).Count();
        }
    }
}
