namespace HouseholdAppliances;

public class Microwave : Appliance, ICooker
{
    public int BoilingTime { get; set; }
    public int MaximumTemperature { get; set; }
    public Microwave(
        string Brand, string Model, int boilingTime, int maximumTemperature, bool IsOn = false
        ) : base(Brand, Model, IsOn)
    {
        BoilingTime = boilingTime;
        MaximumTemperature = maximumTemperature;
    }

    public void Cook(string food)
    {
        try
        {
            if (!IsOn)
                throw new ArgumentException("Microwave off");
            
            Console.WriteLine($"let's cook {food} - Microwave");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex);
            throw ex;
        }
        
    }

    public void Heat(string food)
    {
        try
        {
            if (!IsOn)
                throw new ArgumentException("Microwave off");
            
            Console.WriteLine($"let's heat {food} - Microwave");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex);
            throw ex;
        }
        
    }
}