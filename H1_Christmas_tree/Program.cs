namespace H1_Christmas_tree
{
    internal class Program
    {
        static void Main()
        {
            // Creates 2 variables, to keep track of * per line and spaces per line
            int line = 1;
            int spaces = 8;

            // Creates a for loop which runs 8 times, which is the length of the tree
            for (int i = 0; i < 8; i++)
            {
                // Adds the spaces for tree, so its centered
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                // If its true, then the line will only be green, else its multi colored
                if (i == 0 || i == 2 || i == 4 || i == 6)
                {
                    // Changes color to green and adds the "line" variable amount of "*"
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(string.Concat(Enumerable.Repeat("*", line)));
                }
                else
                {
                    // Creates another for loop to keep track of the multi colored lines
                    for (int j = 0; j < line; j++)
                    {
                        // If its true then its green, else its red
                        if (j == 0 || j == 2 || j == 4 || j == 6 || j == 8 || j == 10 || j == 12 || j == 14)
                            Console.ForegroundColor = ConsoleColor.Green;
                        else
                            Console.ForegroundColor = ConsoleColor.Red;

                        // Prints out an asterisk
                        Console.Write("*");
                    }
                    // Goes to the next line
                    Console.WriteLine();
                }

                // Increases the line value by 2 and removes 1 space
                line += 2;
                spaces--;
            }
        }
    }
}