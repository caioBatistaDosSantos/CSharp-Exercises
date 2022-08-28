namespace HouseholdAppliances.Test;

public class ApplianceTests
{
    public static TheoryData<object, object> PolymorphismData => new TheoryData<object, object>
    {
        {
            new Microwave("Samsung", "MW-01", 5, 100),
            new ElectricStove("Electrolux", "ST-02", 10, 200)
        },
    };

    [Theory]
    [InlineData("Samsung", "ST-01", 5, 100, false)]
    [InlineData("Electrolux", "ST-02", 10, 200, false)]
    public void TestMicrowave(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        var microwave = new Microwave(brand, model, boilingTime, maximumTemperature);

        microwave.Brand.Should().Be(brand);
        microwave.Model.Should().Be(model);
        microwave.BoilingTime.Should().Be(boilingTime);
        microwave.IsOn.Should().Be(initialIsOn);
    }

    [Theory]
    [InlineData("Samsung", "MW-01", 5, 100, false)]
    [InlineData("Electrolux", "MW-02", 10, 200, false)]
    public void TestElectricStove(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        var eletricStove = new ElectricStove(brand, model, boilingTime, maximumTemperature);

        eletricStove.Brand.Should().Be(brand);
        eletricStove.Model.Should().Be(model);
        eletricStove.BoilingTime.Should().Be(boilingTime);
        eletricStove.IsOn.Should().Be(initialIsOn);
    }

    [Theory]
    [MemberData(nameof(PolymorphismData))]
    public void TestPolymorphism(object microwave, object electricStove)
    {
        microwave.Should().BeAssignableTo<ICooker>();
        microwave.Should().BeAssignableTo<Appliance>();
        
        electricStove.Should().BeAssignableTo<ICooker>();
        electricStove.Should().BeAssignableTo<Appliance>();
    }
}