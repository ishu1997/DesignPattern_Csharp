// var obj = singleton.GetSingletonInstance();
// obj.printMessage("i am teacher");

// var obj2 = singleton.GetSingletonInstance();
// obj2.printMessage("i am student");



CreditCard platinumCard = new PlatinumCardFactory().createProduct();
platinumCard.GetCardLimit();
platinumCard.GetCardType();
platinumCard.GetCardAnnualCharge();


CreditCard titaniumCard = new TitaniumCardFactory().createProduct();
titaniumCard.GetCardLimit();
titaniumCard.GetCardType();
titaniumCard.GetCardAnnualCharge();

