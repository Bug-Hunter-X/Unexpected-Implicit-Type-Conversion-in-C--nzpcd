public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(5); // Explicit creation of MyClass object
        int value = obj1.MyProperty; // Explicit access to the property

        Console.WriteLine(value); // Output: 5

        MyClass obj2 = new MyClass(10);
        int value2 = obj2.MyProperty + 5; // Explicit access to property and addition
        MyClass obj3 = new MyClass(value2); //Explicit creation of MyClass object
        Console.WriteLine(obj3.MyProperty); // Output: 15
    }
}