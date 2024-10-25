namespace P3
{
    public class ConstructionFenceFactory : ObstacleFactory
    {
        public override Obstacle CreateObstacle()
        {
            return new ConstructionFence();
        }
    }
}
