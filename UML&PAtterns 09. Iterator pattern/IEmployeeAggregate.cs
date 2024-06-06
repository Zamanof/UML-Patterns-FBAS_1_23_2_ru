namespace UML_PAtterns_09._Iterator_pattern;

interface IEmployeeAggregate
{
    IIterator<Employee> CreateIterator(bool reverse);
}
