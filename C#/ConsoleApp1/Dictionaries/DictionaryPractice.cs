
//Dicitonaries provide efficient key-value lookup.
//Unique keys

public class DictionaryPractice
{
    public void Run()
    {

        //This is a simple console application to practice using dictionaries in C#.        
        Console.WriteLine("Dictionary Practice");

        //Create an empty deictionary

        Dictionary<int, string> gameCompanies = new Dictionary<int, string>();

        //Add items to the dictionary
        gameCompanies.Add(1, "Riot");
        gameCompanies.Add(2, "Blizzard");
        gameCompanies.Add(3, "Valve");
        gameCompanies.Add(4, "Epic Games");

        //The keys are unique. Trying to add a duplicate key will throw an ArgumentException exception

        // gameCompanies.Add(1, "Ubisoft"); // This will throw an exception

        //Do the same, but put inside a try-catch block

        try
        {
            gameCompanies.Add(1, "Ubisoft");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine($"Error in full: {ex}");
            Console.WriteLine("An element with Key = \"1\" already exists.");
        }


        // The Item property is another name for the indexer, so you
        // can omit its name when accessing elements.
        Console.WriteLine("For key = \"1\", value = {0}.",
        gameCompanies[1]);


        //An efficient way to check if key-values exist is by using the TryGetValue method. It uses a key as parameter for lookup, and returns true or false depending on the result of the lookup.
        string value = "";

        //We initiaize an empty string variable. If the TryGetValue methos is successfull, we will assign the value to the variable.
        if (gameCompanies.TryGetValue(2, out value))
        {
            System.Console.WriteLine("For key = \"2\", value = {0}.", value);
        }
        else
        {
            System.Console.WriteLine("Key not found.");
        }

        //The above isn't very dynamic, so lets make a method that takes a key as a parameter and returns the value if it exists. This will also allow use to verify in logs
        // the key we're actually using for lookup. We return a string value that returns the string value of the key if the key was found, or a message with the key that was
        // used trying to find a value, but ultimately returned null.

        LookUpDictionaryValue(gameCompanies, 3);

    }

    private string LookUpDictionaryValue(Dictionary<int, string> dictionary, int key)
    {
        if (dictionary.TryGetValue(key, out string value))
        {
            return $"For key = \"{key}\", value = {value}.";
        }
        else
        {
            return $"Key = \"{key}\" not found in the dictionary.";
        }
    }

    public void InsertDictionaryValue(Dictionary<int, string> dictionary, int key, string value)
    {
        // Check if dictionary contains key. If it doesn't exist, add value at that key.
        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, value);
            Console.WriteLine($"Inserted value \"{value}\" at key = \"{key}\".");
        }
        else
        {
            Console.WriteLine($"Key = \"{key}\" already exists with value \"{dictionary[key]}\".");
        }
    }
}
