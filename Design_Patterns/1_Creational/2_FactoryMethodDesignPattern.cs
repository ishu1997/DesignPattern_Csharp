// Improvement from Factory Design Pattern


#region  main execution
// CreditCard platinumCard = new PlatinumCardFactory().createProduct();
// platinumCard.GetCardLimit();
// platinumCard.GetCardType();
// platinumCard.GetCardAnnualCharge();


// CreditCard titaniumCard = new TitaniumCardFactory().createProduct();
// titaniumCard.GetCardLimit();
// titaniumCard.GetCardType();
// titaniumCard.GetCardAnnualCharge();
#endregion

public abstract class CreditCardFactory
{

    public abstract CreditCard makeProduct();
    public CreditCard createProduct()
    {
        return makeProduct();
    }
}

public class PlatinumCardFactory : CreditCardFactory
{
    public override CreditCard makeProduct()
    {
        return new Platinum();
    }
}

public class TitaniumCardFactory : CreditCardFactory
{
    public override CreditCard makeProduct()
    {
        return new TitaniumCard();
    }
}

public class vitaniumCardFactory : CreditCardFactory
{
    public override CreditCard makeProduct()
    {
        return new vitanium();
    }
}