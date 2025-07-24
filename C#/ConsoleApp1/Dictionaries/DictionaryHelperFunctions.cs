public static class DictionaryHelperFunctions
{
    // Helper method: Add Box to dictionary
    public static void AddBox(Dictionary<Box, string> boxDictionary, Box box, string name)
    {
        try
        {
            boxDictionary.Add(box, name);
        }
        catch (ArgumentException e)
        {
            System.Console.WriteLine($"Unable to add {box}: {e.Message}");
        }
    }

}