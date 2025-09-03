namespace DesafioProjetoHospedagem.Models;

public class Person
{
    public Person() { }

    public Person(string firstName)
    {
        FirstName = firstName;
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}".ToUpper();
}