// See https://aka.ms/new-console-template for more information


namespace PreseasonTickets
{
    class FootballTiers
    {
        static void Main(string[] args)
        {
            var x = 700
            switch (x)
            {
                case 50:
                    Console.WriteLine("You can afford a end zone upper level ticket. Sadly, these are the worst.");
                    break;
                case 130:
                    Console.WriteLine("You can afford a 50-yard line upper level ticket. The players in the game look like ants.");
                    break;
                case 160 ;
                    Console.WriteLine("You can afford an end zone lower level ticket. These are cheap seats, but you get an ok view.");
                    break;
                case 330:
                    Console.WriteLine("Enjoy one of the best seats in the stadium. If you're on the right side of your team, it's worth the money.");
                    break;
                case 1,000:
                    Console.WriteLine("Welcome to the VIP section of the stadium. Say hi to one of the many celebrities while you're there.");
                    break;
                default:
                    Console.WriteLine("You should at least have about 50 dollars or more to afford a preseason ticket.");
                    break;
            }
        }
    }
}