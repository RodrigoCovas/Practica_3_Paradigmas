namespace P3
{
    public class Taxi
    {
        private static Taxi? _instance; // Singleton instance
        public int _life { get; private set; }
        public double _speed { get; private set; }
        public int _lastLifeValue { get; private set; }
        public double _lastSpeedValue { get; private set; }

        private Taxi()
        {
            _life = 100;
            _speed = 1;
            _lastLifeValue = _life;
            _lastSpeedValue = _speed;
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

        public void ApplyObstacle(IObstacle obstacle)
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
            _speed = Math.Round(_speed, 2); // Round to 2 decimal places

            Console.WriteLine(ToString());
        }

        public void RestoreSpeed(double originalSpeed)
        {
            _lastSpeedValue = _speed;

            _speed = originalSpeed;

            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Life: {_lastLifeValue} -> {_life}, Speed: {_lastSpeedValue} -> {_speed}";
        }


    }
}
