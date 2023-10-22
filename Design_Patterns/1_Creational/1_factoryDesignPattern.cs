public interface CreditCard
{
    public void GetCardType();
    public void GetCardLimit();
    public void GetCardAnnualCharge();
}

// class resposible for creation of objects
public class Factory
{
    // Basic notes


    // program main ke andar sirf below code jayega
    // --CreditCard card = Factory.GetCardDetails("titanium");
    // --card.GetCardLimit();
    // --card.GetCardType();
    // --card.GetCardAnnualCharge();


    // improvements
    // abhi bhi if else condition ka use ho rha h chaahe main() mein ho ya fir is factory class me
    // koi naya Card add krna hua toh 1 ya 2 if else condition add krni padegi
    //  tight coupling main and concrete credit cards se hata di h par ab tight coupling factory or concrete credit cards ke beech me ho gayi h



    // yeh pura kaam pehle main ke andar hota tha ,ab is factory class ka use krke object generate karenge
    public static CreditCard GetCardDetails(string rCard)
    {
        CreditCard card = null;

        if (rCard == "titanium")
        {
            card = new TitaniumCard();
        }
        if (rCard == "platinum")
        {
            card = new Platinum();
        }
        if (rCard == "vitanium")
        {
            card = new vitanium();
        }

        return card;

    }
}

public class TitaniumCard : CreditCard
{
    public void GetCardType()
    {
        Console.WriteLine("Titanium");
    }
    public void GetCardLimit()
    {
        Console.WriteLine("3500");
    }
    public void GetCardAnnualCharge()
    {
        Console.WriteLine("200");
    }
}

public class Platinum : CreditCard
{
    public void GetCardType()
    {
        Console.WriteLine("platinum");
    }
    public void GetCardLimit()
    {
        Console.WriteLine("4500");
    }
    public void GetCardAnnualCharge()
    {
        Console.WriteLine("300");
    }
}

public class vitanium : CreditCard
{
    public void GetCardType()
    {
        Console.WriteLine("vitanium");
    }
    public void GetCardLimit()
    {
        Console.WriteLine("5500");
    }
    public void GetCardAnnualCharge()
    {
        Console.WriteLine("500");
    }
}