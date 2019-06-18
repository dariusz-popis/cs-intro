namespace Day01.Library
{
    public static class ThreadExtensions
    {
        public static void SleepSec(this int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 1000);
        }
    }
}
