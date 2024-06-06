namespace UML_PAtterns_09._Iterator_pattern;

internal class EmployeeIterator : IIterator<Employee>
{
    private EmployeeListAggregate _aggregate;
    private int _currentIndex;

    public EmployeeIterator(EmployeeListAggregate aggregate)
    {
        _aggregate = aggregate;
        _currentIndex = 0;
    }

    public Employee Current()
        => _aggregate.GetEmployee( _currentIndex++);

    public bool HasNext()
    {
        if (_aggregate.Count() > _currentIndex) return true;
        return false;
    }
}