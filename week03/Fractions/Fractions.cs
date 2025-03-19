using System.Collections.Generic;

public class Fractions
{
    private int numerator;
    private int denominator;

    public Fractions()
    {
        numerator = 1;
        denominator = 1;
    }
    public Fractions(int _numerator)
    {
        numerator = _numerator;
        denominator = 1;
    }
    public Fractions(int _numerator2, int _denominator2)
    {
        numerator = _numerator2;
        denominator = _denominator2;
    }

    public int Numerator
    {
        get{return numerator;}
        set{numerator = value;}
    }

    public int Denominator
    {
        get{return denominator;}
        set{denominator = value;}
    }

//public string GetFractionString()
//{
////string divisorySymbol = "/";
////string parsingNumerator = numerator.ToString();
////string parsingDenominator = denominator.ToString();
////string outcome = parsingNumerator + divisorySymbol + parsingDenominator;
////return outcome;
//}
    public string GetFractionString()
    {        
        return numerator + "/" + denominator;
    }

    public double GetDecimalValue()
    {
        return (double) numerator / denominator;
    }

    
}