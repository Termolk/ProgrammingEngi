namespace ProgrammingEngi.ThirdPractice;

public abstract class BaseContact
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public virtual string GetCharacteristics()
    {
        return $"Name: {Name}, birth: {DateOfBirth}";
    }
}