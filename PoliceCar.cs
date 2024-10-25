namespace P3
{
    public class PoliceCar : Obstacle
    {
        public PoliceCar()
        {
            PursueTaxi = true;
            isSolid = true;
            Damage = 30;
            SpeedMultiplier = 0.8;
            EffectDuration = 1; // Seconds
        }
    }
}
