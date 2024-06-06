using UML_PAtterns_09._Iterator_pattern;

EmployeeListAggregate employeeList = new();
employeeList.AddEmployee(new Employee(id:1, firstName:"Harry", lastName:"Potter"));
employeeList.AddEmployee(new Employee(id:2, firstName:"Ron", lastName: "Weasley"));
employeeList.AddEmployee(new Employee(id:3, firstName: "Hermione ", lastName: "Granger"));
employeeList.AddEmployee(new Employee(id:4, firstName: "Rubeus ", lastName: "Hagrid"));

var iterator = employeeList.CreateIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Current());
}
iterator = employeeList.CreateIterator(reverse:true);
Console.WriteLine();
while (iterator.HasNext())
    Console.WriteLine(iterator.Current());

