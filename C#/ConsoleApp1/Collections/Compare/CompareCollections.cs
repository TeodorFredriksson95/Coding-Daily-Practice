

public class CompareCollections
{
    // There are different types of indexable collections. Indexable means the ability to access an element of
    // a collection using an index.

    // Explore different types of collections

    // Arrays
    string[] stringArray = ["one", "two", "three"];
    string[] stringArray2 = { "one", "two", "three" };

    // Lists
    List<string> stringList = ["one", "two", "three"];



    public static void Main()
    {

        
        // Spread element
        string[] electricalConcepts = ["voltage", "current", "resistance"];
        string[] OhmsLaw = [.. electricalConcepts]; // The spread element produces 3 different elements, which can be seen in the electricalConcepts array.

        CompareCollections collections = new CompareCollections();

        foreach (var item in collections.stringArray)
        {
            System.Console.WriteLine($"string array elements: {item}");
        }
    }
    


}