namespace MemoryGame
{
    public class ThemeUtil
    {
        public static string getPath(Theme theme)
        {
            string path;
            switch(theme)
            {
                case Theme.SHAPE:
                    path = @"..\..\Pictures\Shapes";
                    break;
                case Theme.GAME:
                    path = @"..\..\Pictures\Games";
                    break;
                case Theme.MEME:
                    path = @"..\..\Pictures\Memes";
                    break;
                default:
                    path = @"..\..\Pictures\Shapes";
                    break;
            }
            return path;
        }
    }

}