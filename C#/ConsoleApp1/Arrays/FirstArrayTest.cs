

public class FirstArrayTest
{
    // Array declarations in C# can be nullable or non-nullable. The below snippet is cut directly from the C# documentation.
    // type?[] arrayName; // non nullable array of nullable element types.
    // type[]? arrayName; // nullable array of non-nullable element types.
    // type?[]? arrayName; // nullable array of nullable element types.


    // Let's create a few arrays to demonstrate the difference in nullability vs non-nullability and how to it with different types and values.
   public Car?[] nullableCars; // Works as intended. We declare that the nullableCars array itself is non-nullable, but the individual elements it contains can be either null, or, valid references of type Car

    public FirstArrayTest()
    {
        // Let's create an array of type Car where the value type Car is nullable, matching the below signature
        // type?[] arrayName;
        nullableCars = new Car[5];

        // Add a value of type Car to the first index of the nullableCars array
        nullableCars[0] = new Car("Honda");
    }



}

// Private class Car
public class Car
{
    public string Make { get; }
    public Car(string make)
    {
        Make = make;
    }
}