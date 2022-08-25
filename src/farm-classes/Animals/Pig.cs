namespace Animals;

public class Pig
{
    public Guid Id = Guid.NewGuid();
    public int Age;

    public Pig(int age)
    {
        if (age < 0)
            throw new ArgumentException("Idade informada incorretamente");
        
        Age = age;
    }
}
