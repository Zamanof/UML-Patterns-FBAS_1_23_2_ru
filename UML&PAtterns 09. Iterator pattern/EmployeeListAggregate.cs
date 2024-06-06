namespace UML_PAtterns_09._Iterator_pattern;

internal class EmployeeListAggregate : IEmployeeAggregate
{
    private List<Employee> _employeeList;

    public EmployeeListAggregate()
    {
        _employeeList = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        _employeeList.Add(employee);
    }

    public int Count()
        => _employeeList.Count();
    public Employee GetEmployee(int index) => _employeeList[index];

    public IIterator<Employee> CreateIterator(bool reverse = false)
    {
        if (reverse) return new EmployeeIteratorReverse(this);
        return new EmployeeIterator(this);
    }
}
