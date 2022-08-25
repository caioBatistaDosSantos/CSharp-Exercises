namespace Animals;

public class Chicken   
{
    public Guid Id = Guid.NewGuid();
    public int EggsPerWeek;
    public Chicken? Mother;

    public Chicken(int eggsPerWeek, Chicken mother)
    {
        if (eggsPerWeek <= 0)
            throw new ArgumentException("Idade informada incorretamente");
        
        EggsPerWeek = eggsPerWeek;
        Mother = mother;
    }

    public Chicken(int eggsPerWeek)
    {
        if (eggsPerWeek < 0)
            throw new ArgumentException("Informe quantos ovos por semana essa galinha bota");
        
        EggsPerWeek = eggsPerWeek;
    }
}
