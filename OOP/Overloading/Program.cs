// Function Overloading
class Student
{
    private string _firstName;
    private string _lastName;

    public void SetName(string firstName)
    {
        _firstName = firstName;
    }

    public void SetName(string firstName, string lastName)
    {
        SetName(firstName);
        _lastName = lastName;
    }
}

namespace Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student rushi = new Student();
            rushi.SetName("Rushi", "Naikwadi");
        }
    }
}

