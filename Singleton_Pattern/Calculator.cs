using System;

//no thread safe
public sealed class Calculator
{
    #region Member(s)
    private static Calculator instance;
    public static Calculator Instance 
    { 
        get 
        { 
            if(instance == null) 
            {
                instance = new Calculator();
            }
            return instance;
        } 
    }
    #endregion

    #region Method(s)
    public void Addition(int x, int y) 
    {
        Console.WriteLine("x + y is equal to : " +( x + y));
    }

    public void Substraction(int x, int y)
    {
        Console.WriteLine("x - y is equal to : "+ (x - y));
    }

    public void Multiplication(int x, int y)
    {
        Console.WriteLine("x * y is equal to : " + (x * y));
    }

    public void Division(int x, int y)
    {
        Console.WriteLine("x / y is equal to : " + (x / y));
    }
    #endregion

}
