namespace Animals;

public class Cow
{
    public Guid Id = Guid.NewGuid();
    public int Weight;
    public string Breed;

    public Cow(int weight, string breed)
    {
        if (weight <= 0 || breed == null || breed == "")
            throw new ArgumentException("Os dados informados incorretamente");
        
        Weight = weight;
        Breed = breed;
    }
}
