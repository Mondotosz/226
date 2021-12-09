namespace DateTimeExercises
{
    public class Person
    {
        private string _name;
        protected DateTime _birthdate;

        public Person(string name, DateTime birthdate)
        {
            _name = name;
            _birthdate = birthdate;
        }

        public bool IsMajor
        {
            get
            {
                return (DateTime.Now - _birthdate).Days / 365.25 >= 18;
            }
        }
    }
}