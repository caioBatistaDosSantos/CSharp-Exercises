namespace Animals;

class Cow
{
    Guid Id = Guid.NewGuid();
    int Weight;
    string Breed;

    public Cow(int weight, string breed)
    {
        if (weight <= 0 || breed == null || breed == "")
            throw new ArgumentException("Os dados informados incorretamente");
        
        Weight = weight;
        Breed = breed;
    }
}
