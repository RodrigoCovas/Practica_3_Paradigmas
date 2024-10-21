namespace P3
{
    public class PoliceCarFactory : ObstacleFactory
    {
        public override IObstacle CreateObstacle()
        {
            return new PoliceCar();
        }
    }
}
