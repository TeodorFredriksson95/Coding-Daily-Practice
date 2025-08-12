

public class HashSetTest
{
    // I gather that a hashset is an unordered collection and provides high-performance set operations. Performing operations on set is not
    // to be confused with performing operations on an ordered collection. Let's review what unordered means in the context of collections below.

    public static void Main()
    {
        HashSet<int> hashInts = new HashSet<int>();
        hashInts.Add(10);
        hashInts.Add(20);
        hashInts.Add(10);

        // Collection initializer
        HashSet<int> hashIntsInitializer = new HashSet<int> { 10, 20, 30 };

        // System.Console.WriteLine(hashInts[1]); // This is not valid. We're trying to access an element based on an index, an ordered position.
        // But HashSets are considered unordered, meaning we can't access elements by a defined position. However, we CAN iterate over the collection.

        foreach (var item in hashIntsInitializer)
        {
            System.Console.WriteLine($"Element in hashIntsInitializer: {item}");
        }

        // From what I understand, the main benefit of a hashset is that the operations performed on it are computationally efficient in regards to 
        // insertion, retrieval, deletion and lookups.

        int retrievedValue;
        if (hashInts.TryGetValue(10, out retrievedValue ))
        {
            System.Console.WriteLine("hashInts contains value = {0}", retrievedValue);
        }
    }
}