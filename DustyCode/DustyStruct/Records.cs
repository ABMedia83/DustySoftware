public record TheRecord 
{
     public string Message {get; init;} 
}

public record BetterRecord: TheRecord
{
    public double RealValue {get; init;}
}