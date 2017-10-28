namespace MemoryGame
{
    public class ThemeUtil
    {
        public static string getPath(Theme theme)
        {
            string path;
            switch(theme)
            {
                case Theme.ANIMAL:
                    path = @"C:\Users\Crusader2142\Desktop\Assignments\C#\MemoryGame\MemoryGame\MemoryGame";
                    break;
                case Theme.SHAPE:
                    path = @"C:\Users\Crusader2142\Desktop\Assignments\C#\MemoryGame\MemoryGame\MemoryGame";
                    break;
                case Theme.PEOPLE:
                    path = @"C:\Users\Crusader2142\Desktop\Assignments\C#\MemoryGame\MemoryGame\MemoryGame";
                    break;
                case Theme.FLAG:
                    path = @"C:\Users\Crusader2142\Desktop\Assignments\C#\MemoryGame\MemoryGame\MemoryGame";
                    break;
                default:
                    path = @"C:\Users\Crusader2142\Desktop\Assignments\C#\MemoryGame\MemoryGame\MemoryGame";
                    break;
            }
            return path;
        }
    }

}