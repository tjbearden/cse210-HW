public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 3;
    }
    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top=top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom= bottom;
    }
    public string GetFratctionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double GetDecimalValue()
    {
        double decimalNumber = (double)_top / (double)_bottom;
        return decimalNumber;
    }


}