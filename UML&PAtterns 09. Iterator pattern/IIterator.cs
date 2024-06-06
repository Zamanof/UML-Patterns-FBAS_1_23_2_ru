namespace UML_PAtterns_09._Iterator_pattern;

interface IIterator<T>
{
    bool HasNext();
    T Current();
}
