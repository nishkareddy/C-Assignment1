namespace Chapter03;

public class GreetingTime
{
    public void GreetTime()
    {
        DateTime currentTime = DateTime.Now;
        int mrng = 5;   // 5 AM
        int aftn = 12;  // 12 PM
        int evg = 17;   // 5 PM
        int night= 21;  //10 pm
        Console.WriteLine($"Current time:{currentTime}");
        if (currentTime.Hour >= mrng && currentTime.Hour < aftn)
        {
         Console.WriteLine("Good morning");
        }
        else if (currentTime.Hour >= aftn && currentTime.Hour < evg)
        {
            Console.WriteLine("Good afternoon");
        }
        else if (currentTime.Hour >= evg && currentTime.Hour < night)
        {
            Console.WriteLine("Good evening");
        }
        else
        {
            Console.WriteLine("Good night");
        }
    }
}