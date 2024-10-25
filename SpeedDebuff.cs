namespace P3
{
    public class SpeedDebuff : Obstacle
    {
        public SpeedDebuff()
        {
            PursueTaxi = false;
            isSolid = false;
            Damage = 0;
            SpeedMultiplier = 0.5;
            EffectDuration = 30; // Seconds
        }
    }
}
