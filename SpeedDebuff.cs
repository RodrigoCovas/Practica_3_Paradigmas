namespace P3
{
    public class SpeedDebuff : IObstacle
    {
        public bool PursueTaxi { get; }
        public bool isSolid { get; }
        public int Damage { get; }
        public double SpeedMultiplier { get; }
        public int EffectDuration { get; }

        public SpeedDebuff()
        {
            PursueTaxi = false;
            isSolid = false;
            Damage = 0;
            SpeedMultiplier = 0.5;
            EffectDuration = 30; // Seconds
        }

        public void ApplyEffect(Taxi taxi)
        {
            taxi.ApplyObstacle(this);
        }
    }
}
