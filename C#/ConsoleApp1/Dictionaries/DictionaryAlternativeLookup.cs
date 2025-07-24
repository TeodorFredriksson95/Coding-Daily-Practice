public class DictionaryAlternativeLookup
{

}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }
    public Person(int id, string name, int age, string occupation)
    {
        Id = id;
        Name = name;
        Age = age;
        Occupation = occupation;
    }
    public Person()
    {
        
    }
}

public class PersonEqualityComparer : IEqualityComparer<Person>, IAlternateEqualityComparer<int, Person>
{
    // IEqualityComparer interface implementation
    public bool Equals(Person? x, Person? y) => x != null && y != null && x.Id == y.Id;
    public int GetHashCode(Person person) => person.Id.GetHashCode();

    // IAlternateEqualityComparer interface implementation
    public bool Equals(int id, Person person) => id == person.Id;
    public int GetHashCode(int id) => id.GetHashCode();
    public Person Create(int id) => throw new NotImplementedException();

}