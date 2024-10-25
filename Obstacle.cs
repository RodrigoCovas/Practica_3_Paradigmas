namespace P3
{
    public abstract class Obstacle
    {
        public bool PursueTaxi { get; protected set; }
        public bool isSolid { get; protected set; }
        public int Damage { get; protected set; }
        public double SpeedMultiplier { get; protected set; }
        public int EffectDuration { get; protected set; }
        public void ApplyEffect(Taxi taxi)
        {
            taxi.ApplyObstacle(this);
        }

    }
}
