public class Phone: Product
{
    int Memory {get; set;}
    int Ram{get; set;}
    string Model{get; set;}
    public Phone(){}
    public Phone (int mem, int ram, string mod)
    {
        Memory=mem;
        Ram=ram;
        Model=mod;
    }
}