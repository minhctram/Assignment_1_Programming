
namespace MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        DateTime birthday = new DateTime(1997, 11, 20);
        Console.WriteLine(birthday);
        DateTime today = DateTime.Today;
        Console.WriteLine(today);
        TimeSpan age = today -  birthday;
        int days = age.Days;
        Console.WriteLine($"you are {days} days old");
        int daysToNextAnniversary = 10000 - (days % 10000);
        DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);
        Console.WriteLine($"Your next 10,000-day anniversary will be on: {nextAnniversary.ToShortDateString()}");
    }
}