namespace Builder
{
    internal class PersonBuilder : IPersonBuilder
    {
        private Person _person;

        public PersonBuilder()
        {
            _person = new Person();
        }

        public void SetAge(int age)
        {
            _person.Age = age;
        }

        public void SetBirthDate(DateTime birthDate)
        {
            _person.BirthDate = birthDate;
        }

        public void SetFirstName(string firstName)
        {
            _person.FirstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            _person.LastName = lastName;
        }

        public void SetNationalId(int nationalId)
        {
            _person.NationalId = nationalId;
        }
        public Person Build()
        {
            return _person;
        }
    }
}
