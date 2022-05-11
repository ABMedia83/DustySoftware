
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
        Gender = Gender.Male;

        
       

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

    public string GenderString 
    {
        get => genderString;
        private set => genderString = value;
    }

    public Gender Gender 
    {
        get => gender;
        set 
        { 
            gender = value;

            switch(value)
            {
                case Gender.Male:
                GenderString = "Male";
                break;
                case Gender.Fematle:

                GenderString = "Female";

                break;
            }
        }
    }





}