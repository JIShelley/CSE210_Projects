class Program
{
    static void DisplayPersonInformation(Person person)
    {
        // if (person is Doctor doctor)
        // {
        //     Console.WriteLine(doctor.GetDoctorInfo());
        // }
        // else if (person is Police police)
        // {
        //     Console.WriteLine(police.GetPoliceInfo());
        // }
        // else
        // {
        Console.WriteLine(person.GetPersonInfo());
        Console.WriteLine($"Salary: {person.GetSalary()}");
        // }
    }
    
    static void Main(string[] args)
    {
        // Person myPerson = new Person("Bob", "Floyd", 56, 238);

        // Console.WriteLine(myPerson.GetPersonInfo());

        Police myPolice = new Police("John", "Doe", 35, 180, "Handcuffs");
        // Console.WriteLine(myPolice.GetPersonInfo());

        Doctor myDoctor = new Doctor("Jane", "Smith", 40, 150, "Stethoscope");
        // Console.WriteLine(myDoctor.GetPersonInfo());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myPolice);
        myPeople.Add(myDoctor);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
            // Console.WriteLine(person.GetPersonInfo());
            // if (person is Doctor d)
            // {
            //     Console.WriteLine(d.GetDoctorInfo());
            // }
        }
    }
}