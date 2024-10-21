namespace P3
{
    public class ConstructionFenceFactory : ObstacleFactory
    {
        public override IObstacle CreateObstacle()
        {
            return new ConstructionFence();
        }
    }
}
