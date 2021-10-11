namespace HomeAuto
{
    public class Switch
    {
        private string _name;
        private bool _state;

        public Switch(string name)
        {
            _name = name;
            _state = false;
        }

        public void On()
        {
            _state = true;
        }

        public void Off()
        {
            _state = false;
        }

        public string Name{
            get => _name;
        }

        public bool State {
            get => _state;
        }
    }
}
