class Doctor : Person
{
    private string _tools;

    public Doctor(string firstName, string lastName, int age, double weight, string tools) : base(firstName, lastName, age, weight)
    {
        _tools = tools;
    }

    public override string GetPersonInfo()
    {
        return $"Doctor Tools: {_tools}, {base.GetPersonInfo()}";
    }

    public override double GetSalary()
    {
        return 120000.00;
    }
}

