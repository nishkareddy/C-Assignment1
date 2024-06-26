namespace Chapter03;

public class Counting
{
    public void Result()
    {
        for (int inc = 1; inc <= 4; inc++)
        {
            for (int i = 0; i <= 24; i += inc)
            {
                Console.Write(i);
                if (i + inc <= 24)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
            
    }
            
}