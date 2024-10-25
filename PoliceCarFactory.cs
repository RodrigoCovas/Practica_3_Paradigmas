namespace P3
{
    public class PoliceCarFactory : ObstacleFactory
    {
        public override Obstacle CreateObstacle()
        {
            return new PoliceCar();
        }
    }
}
