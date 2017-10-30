namespace MemoryGame
{
    public class LevelUtil
    {
        private LevelUtil()
        {

        }

        public static int getAttempts(Level level)
        {
            int attempts;
            switch (level)
            {
                case Level.Easy:
                    attempts = 20;
                    break;
                case Level.Medium:
                    attempts = 15;
                    break;
                case Level.Hard:
                    attempts = 10;
                    break;
                case Level.Extreme:
                    attempts = 5;
                    break;
                default:
                    attempts = 0;
                    break;
            }
            return attempts;
        }

    }

}