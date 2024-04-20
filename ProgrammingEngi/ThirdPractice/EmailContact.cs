namespace ProgrammingEngi.ThirdPractice;

public class EmailContact : BaseContact
{
    public string Email { get; set; }
    
    public override string GetCharacteristics()
    {
        string baseText = base.GetCharacteristics();
        baseText += $", Email: {Email}";
        return baseText;
    }
}