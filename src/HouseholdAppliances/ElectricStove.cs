namespace HouseholdAppliances;

public class ElectricStove : Appliance, ICooker
{
    public int BoilingTime { get; set; }
    public int MaximumTemperature { get; set; }
    public ElectricStove(
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
                throw new ArgumentException("device off");
            
            Console.WriteLine($"let's cook {food}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex);
            throw ex;
        }
        
    }

    public void Bake(string food)
    {
        try
        {
            if (!IsOn)
                throw new ArgumentException("device off");
            
            Console.WriteLine($"let's bake {food}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex);
            throw ex;
        }
        
    }
}