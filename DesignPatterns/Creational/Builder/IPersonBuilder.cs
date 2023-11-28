namespace Builder
{
    internal interface IPersonBuilder
    {
        void SetNationalId(int nationalId);
        void SetAge(int age);
        void SetFirstName(string firstName);
        void SetLastName(string lastName);
        void SetBirthDate(DateTime birthDate);
        Person Build();
    }
}
