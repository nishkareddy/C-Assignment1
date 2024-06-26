namespace Chapter03
{
    public class printPyramid
    {
        public void star()
        {
            Console.WriteLine("Enter the number of rows:");

            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                {
                    Console.WriteLine("");

                }
            }
        }
    }
}
