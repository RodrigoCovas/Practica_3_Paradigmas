namespace P3
{
    public class SpeedDebuffFactory : ObstacleFactory
    {
        public override IObstacle CreateObstacle()
        {
            return new SpeedDebuff();
        }
    }
}
