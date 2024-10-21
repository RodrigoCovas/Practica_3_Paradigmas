namespace P3
{
    public interface IObstacle
    {
        bool PursueTaxi { get; }
        bool isSolid { get; }
        int Damage { get; }
        double SpeedMultiplier { get; }
        int EffectDuration { get; }
        void ApplyEffect(Taxi taxi);

    }
}
