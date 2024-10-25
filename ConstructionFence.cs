namespace P3
{
    public class ConstructionFence : Obstacle
    {
        public ConstructionFence()
        {
            PursueTaxi = false;
            isSolid = true;
            Damage = 10;
            SpeedMultiplier = 0.8;
            EffectDuration = 1; // Seconds
        }
    }
}
