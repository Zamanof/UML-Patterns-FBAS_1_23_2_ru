namespace UML_PAtterns_09._Iterator_pattern;

class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName}";
    }
}
