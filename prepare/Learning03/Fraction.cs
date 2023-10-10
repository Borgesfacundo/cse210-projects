 public class Fraction 
{
    private int _top = 1;
    private int _bottom = 1;

    public string NumFraction()
    {
        string number = $"Number is {_top}/{_bottom}";

        return number;
    }
    public string NumFraction(int wholeNumber)
    {
        string number = $"The number is {wholeNumber}/{_bottom}";
        return number;
    }
    public string NumFraction(int top, int bottom)
    {
        string number = $"The number is {top}/{bottom}";
        return number;

    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


}