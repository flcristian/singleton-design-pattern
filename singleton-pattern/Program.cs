using singleton_pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Captain captain1 = Captain.GetCaptain();

        Captain captain2 = Captain.GetCaptain();
    }
}