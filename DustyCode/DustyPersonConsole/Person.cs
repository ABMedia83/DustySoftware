
public enum Gender 
{
    Male,
    Fematle 
}
public class Person 
{
    ///Field's 
    private string firstName, lastName,genderString;
    private Gender gender;

    public Person() 
    {
        FirstName = "Albert";
        LastName = "Something"; 

    }



    public string FirstName 
    {
        get => firstName;
        set => firstName = value;





    }

     public string LastName 
    {
        get => lastName;
        set => lastName = value;
    }







}