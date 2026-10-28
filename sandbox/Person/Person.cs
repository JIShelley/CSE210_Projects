class person
{
    private string firstName;

    private string lastName;
    private int age;

    private double weight;


    public Person(string firstName, string lastName, int age, double weight) : base(firstName, lastName, age, weight)
    {
        _FirstName = firstName;
        _LastName = lastName;
        _Age = age;
        _Weight = weight;
    }

    public string GetPersonInfo()
    {
        return $"Name: {_FirstName} {_LastName}, Age: {_Age}, Weight: {_Weight}";
    }
}