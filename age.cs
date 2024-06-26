namespace Chapter03;

public class Age
{
    public void BirthDate()
    {
        DateTime bDate = new DateTime(2000, 11, 23); 
        DateTime currentDate = DateTime.Today;
        int daysOld = (currentDate - bDate).Days;
        int daysToNextAnniversary = 10000 - (daysOld % 10000);
        DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);
        Console.WriteLine($"You are {daysOld} days old.");
        Console.WriteLine($"Your next 10,000 day anniversary will be on {nextAnniversary.ToShortDateString()}.");
    }
    
}