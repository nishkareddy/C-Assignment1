// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using  Chapter03;
class Exercise03
{
    static void Main()
    {
       
        for (int i = 1; i <= 100; i++)
        {
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;
            if (fizz && buzz)
                Console.WriteLine("Fizz and Buzz");
            else if (fizz)
                Console.WriteLine("/fizz/");
            else if (buzz)
                Console.WriteLine("/buzz/");
            else
                Console.WriteLine(i);
        }

        printPyramid p = new printPyramid();
        p.star();
        trial t = new trial();
        t.GuessNum();
        Age a = new Age();
        a.BirthDate();
        GreetingTime gt = new GreetingTime();
        gt.GreetTime();
        Counting c = new Counting();
        c.Result();
        

    }
}