namespace UML_PAtterns_09._Iterator_pattern;

internal class EmployeeIteratorReverse : IIterator<Employee>
{
    private EmployeeListAggregate _aggregate;
    private int _currentIndex;

    public EmployeeIteratorReverse(EmployeeListAggregate aggregate)
    {
        _aggregate = aggregate;
        _currentIndex = _aggregate.Count() - 1;
    }

    public Employee Current()
        => _aggregate.GetEmployee(_currentIndex--);


    public bool HasNext()
    {
        if(_currentIndex >= 0) return true;
        return false;
    }
}