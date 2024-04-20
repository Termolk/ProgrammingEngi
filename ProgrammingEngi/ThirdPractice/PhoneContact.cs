namespace ProgrammingEngi.ThirdPractice;

public class PhoneContact : BaseContact
{
    public string Phone { get; set; }
    
    public override string GetCharacteristics()
    {
        string baseText = base.GetCharacteristics();
        baseText += $", Phone: {Phone}";
        return baseText;
    }
}