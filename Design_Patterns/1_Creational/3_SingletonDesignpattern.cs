public sealed class singleton
{

    public static singleton instance = null;
    public static int counter = 0;

    // object to provide thready safety
    public static readonly object lockObject = new object();
    private singleton()
    {
        Console.WriteLine($"counter updated +{counter}");
    }

    public static singleton GetSingletonInstance()
    {

        lock (lockObject)
        {
            if (instance != null)
            {
                return instance;
            }

        }


        return new singleton();
    }

    public void printMessage(string mess)
    {
        Console.WriteLine($"message from the concrete {mess}");
    }

}



#region main part
// var obj = singleton.GetSingletonInstance();
// obj.printMessage("i am teacher");

// var obj2 = singleton.GetSingletonInstance();
// obj2.printMessage("i am student");
#endregion