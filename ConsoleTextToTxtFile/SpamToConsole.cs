namespace ConsoleTextToTxtFile
{
    internal static class SpamToConsole
    {
        public static void Main(string[] array)
        {
            foreach (var item in array)
            {
                Logger.WriteLine(item);
            }
        }
    }
}