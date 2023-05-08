using System;

static class Program
{
    static void Main()
    {
        try
        {   
            Calculator.Instance.Addition(10, 2);
            Calculator.Instance.Substraction(10, 2);
            Calculator.Instance.Multiplication(10, 2);
            Calculator.Instance.Division(10, 2);
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }
    }
}