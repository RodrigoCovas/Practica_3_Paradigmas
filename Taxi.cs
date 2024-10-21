namespace P3
{
    public class Taxi
    {
        private static Taxi? _instance; // Singleton instance
        private int _life;
        private double _speed;
        private int _lastLifeValue;
        private double _lastSpeedValue;

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

            _life -= obstacle.Damage;
            _speed *= obstacle.SpeedMultiplier;

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
