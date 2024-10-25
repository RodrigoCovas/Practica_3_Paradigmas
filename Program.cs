namespace P3
{
    internal class Program
    {
        static Dictionary<ConsoleKey, ObstacleFactory> factories = new Dictionary<ConsoleKey, ObstacleFactory>
                {
                    { ConsoleKey.A , new PoliceCarFactory() },
                    { ConsoleKey.S , new ConstructionFenceFactory() },
                    { ConsoleKey.D , new SpeedDebuffFactory() }
                };

        public static void Main(string[] args)
        {
            Taxi taxi = Taxi.Instance;
            Console.WriteLine("Press a key to create an obstacle:\nA -> Police Car\nS -> Construction Fence\nD -> Speed Debuff");

            while (true)
            {
                if (taxi._life <= 0)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key; // True so that it doesn't appear in the terminal

                    if (factories.ContainsKey(key))
                    {
                        ObstacleFactory factory = factories[key];
                        Obstacle obstacle = factory.CreateObstacle();
                        obstacle.ApplyEffect(taxi);
                    }
                    else if (key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    Thread.Sleep(20); // Milliseconds
                }
            }
        }
    }
}
