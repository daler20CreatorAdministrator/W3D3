public class Car : Product
{
    public string? Model{get; set;}
    public int Probeg {get; set;}
    public string? Fueltype{get; set;}
    public Car(){}
    public Car(string mod, int prob, string fuel){
        Model = mod;
        prob = Probeg;
        fuel=Fueltype;
        
    }

}