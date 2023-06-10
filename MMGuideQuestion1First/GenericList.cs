using MMGuideQuestion1.Models;

public class GenericList<T> 
{
    public GenericList()
    {
    }

    public void DoSomething(T item)
    {
        switch (item)
        {
            case Animal:
                Console.WriteLine("Foo Animal");
                break;
            case double:
                Console.WriteLine("Foo Number");
                break;
            default:
                Console.WriteLine("Foo Bar");
                break;
        }
    }
}