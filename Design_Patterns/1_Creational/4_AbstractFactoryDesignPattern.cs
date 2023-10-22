#region main part
// var tataCar = new TataVehicleFactory().GetCar();
// var tataBike = new TataVehicleFactory().GetBike();
// tataCar.GetDetails();
// tataBike.GetDetails();


// var teslaCar = new TeslaVehicleFactory().GetCar();
// var teslaBike = new TeslaVehicleFactory().GetBike();
// teslaCar.GetDetails();
teslaBike.GetDetails();

#endregion


public interface iCar
{
    public void GetDetails();
}

public interface iBike
{
    public void GetDetails();
}

public class RegularCar : iCar
{
    public void GetDetails()
    {
        Console.WriteLine($"fetching regular car details ....");
    }
}

public class SportsCar : iCar
{
    public void GetDetails()
    {
        Console.WriteLine($"fetching sports car details ....");
    }
}

public class RegularBike : iBike
{
    public void GetDetails()
    {
        Console.WriteLine($"fetching Regular bike details ....");
    }
}

public class SportsBike : iBike
{
    public void GetDetails()
    {
        Console.WriteLine($"fetching sports bike details ....");
    }
}


public interface iVehicleFactory
{
    public iCar GetCar();
    public iBike GetBike();
}


public class TataVehicleFactory : iVehicleFactory
{
    public iBike GetBike()
    {
        return new RegularBike();
    }

    public iCar GetCar()
    {
        return new RegularCar();
    }
}


public class TeslaVehicleFactory : iVehicleFactory
{
    public iBike GetBike()
    {
        return new SportsBike();
    }

    public iCar GetCar()
    {
        return new SportsCar();
    }
}