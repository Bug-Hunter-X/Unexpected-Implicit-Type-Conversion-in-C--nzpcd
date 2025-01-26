public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj) { return obj.MyProperty; }

    public static implicit operator MyClass(int value) { return new MyClass(value); }
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 5; // Implicit conversion from int to MyClass
        int value = obj1; // Implicit conversion from MyClass to int

        Console.WriteLine(value); // Output: 5

        MyClass obj2 = new MyClass(10);
        int value2 = obj2 + 5; // Implicit conversion from MyClass to int, then addition, then implicit conversion from int to MyClass

        Console.WriteLine(value2); // Output: 15
    }
}