namespace ProgrammingEngi.ThirdPractice;

public class ContactBook
{
    public List<BaseContact> PhoneContacts { get; set; }
    public List<BaseContact> EmailContacts { get; set; }

    public ContactBook(List<BaseContact> phoneContacts, List<BaseContact> emailContacts)
    {
        PhoneContacts = phoneContacts;
        EmailContacts = emailContacts;
    }
    

    public List<BaseContact> GetAllContacts => PhoneContacts.Concat(EmailContacts).ToList();

    public int GetCountOfContacts() => EmailContacts.Count() + PhoneContacts.Count();
}