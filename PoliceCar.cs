namespace P3
{
    public class PoliceCar : IObstacle
    {
        public bool PursueTaxi { get; }
        public bool isSolid { get; }
        public int Damage { get; }
        public double SpeedMultiplier { get; }
        public int EffectDuration { get; }

        public PoliceCar()
        {
            PursueTaxi = true;
            isSolid = true;
            Damage = 30;
            SpeedMultiplier = 0.8;
            EffectDuration = 1; // Seconds
        }

        public void ApplyEffect(Taxi taxi)
        {
            taxi.ApplyObstacle(this);
        }
    }
}
