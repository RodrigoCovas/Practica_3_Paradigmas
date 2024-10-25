namespace P3
{
    public class Taxi
    {
        private static Taxi? _instance; // Singleton instance
        public int _life { get; private set; }
        public double _speed { get; private set; }
        public int _lastLifeValue { get; private set; }
        public double _lastSpeedValue { get; private set; }

        private List<Timer> _timers;

        private List<double> _speedMultipliers;

        private readonly double _initialSpeed = 1;

        private Taxi()
        {
            _life = 100;
            _speed = _initialSpeed;
            _lastLifeValue = _life;
            _lastSpeedValue = _speed;
            _timers = new List<Timer>();
            _speedMultipliers = new List<double>();
        }

        public static Taxi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Taxi();
                }

                return _instance;
            }
        }

        public void ApplyObstacle(Obstacle obstacle)
        {
            _lastLifeValue = _life;
            _lastSpeedValue = _speed;

            if (_life >= obstacle.Damage)
            {
                _life -= obstacle.Damage;
            }
            else
            {
                _life = 0;
            }

            _speed *= obstacle.SpeedMultiplier;

            Timer timer = new Timer(RestoreSpeed, (object)obstacle.SpeedMultiplier, obstacle.EffectDuration * 1000, Timeout.Infinite);
            _timers.Add(timer);
            _speedMultipliers.Add(obstacle.SpeedMultiplier);

            _speed = Math.Round(_speed, 2); // Round to 2 decimal places

            Console.WriteLine(ToString());
        }

        public void RestoreSpeed(object? multiplier)
        {
            if (multiplier is double speedMultiplier)
            {
                _speedMultipliers.Remove(speedMultiplier);

                _lastSpeedValue = _speed;

                if (_speedMultipliers.Count == 0)
                {
                    _speed = _initialSpeed;
                }
                else
                {
                    _speed = _initialSpeed;
                    foreach (var i in _speedMultipliers)
                    {
                        _speed *= i;
                    }
                }

                Console.WriteLine(ToString());
            }
        }

        public override string ToString()
        {
            return $"Life: {_lastLifeValue} -> {_life}, Speed: {_lastSpeedValue} -> {_speed}";
        }
    }
}
