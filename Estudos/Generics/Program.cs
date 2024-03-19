internal class Program
{
    private class ExampleClass{}
    private static void Main(string[] args)
    {
        GenericList<int> list1 = new GenericList<int>();
        list1.Add(1);

        GenericList<string> list2 = new GenericList<string>();
        list2.Add("Botafogo");
        
        GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
        list3.Add(new ExampleClass());
    }
    
}

public class GenericList<T>{
    public void Add(T input){}
}
