namespace DesignPatterns.Behavioral.Iterator
{
    public interface IIterator<out T>
    {
        T First();
        T Next();
        T Current();
        bool IsDone();
    }
}
