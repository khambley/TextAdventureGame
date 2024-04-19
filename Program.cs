namespace TextAdventureGame;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text Adventure Game!");

        bool gameOver = false;

        while (!gameOver)
        {
            // Display the current room description
            Console.WriteLine("You are in a dark room. There is a door to the north.");

            // Prompt the player for input
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine() ?? "";

            // Process the player's input
            if (input.Equals("go north", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("You move to the next room.");
                // You would have more code here to handle moving to the next room
            }
            else if (input.ToLower() == "quit")
            {
                gameOver = true;
            }
            else
            {
                Console.WriteLine("I don't understand that command.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
