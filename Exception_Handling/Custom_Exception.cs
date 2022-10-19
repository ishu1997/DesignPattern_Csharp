public class OddNumberException : Exception
{
    //Overriding the Message property
    // without this message 'Exception of type 'OddNumberException' was thrown.'
    public override string Message
    {
        get
        {   // overriding the method will give us these errors
            return "Divisor Cannot be Odd Number";
        }
    }


}


public class checkCustomException
{
    // call this function in program.cs
    public static void check()
    {
        int i = 3;

        try
        {
            Console.WriteLine("execution started");
            if (i % 2 != 0)
            {
                throw new OddNumberException();
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message.ToString());
        }

        Console.WriteLine("executed");
    }
}