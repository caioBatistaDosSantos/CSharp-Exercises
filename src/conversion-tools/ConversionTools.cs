namespace conversion_tools;

public class ConversionTools
{

    public string? strVariable;
    public int? intVariable;
    public double? doubleVariable;

    public void ConvertStrToInt()
    {
       intVariable = Convert.ToInt32(strVariable);
    }

    public void ConvertStrToDouble()
    {
        doubleVariable = Convert.ToDouble(strVariable);
    }

    public void ConvertIntToStr()
    {
        throw new NotImplementedException();
    }

    public void ConvertDoubleToStr()
    {
        throw new NotImplementedException();
    }

}
