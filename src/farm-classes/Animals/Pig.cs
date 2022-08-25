namespace Animals;

class Pig
{
    Guid Id = Guid.NewGuid();
    int Age;

    public Pig(int age)
    {
        if (age < 0)
            throw new ArgumentException("Idade informada incorretamente");
        
        Age = age;
    }
}
