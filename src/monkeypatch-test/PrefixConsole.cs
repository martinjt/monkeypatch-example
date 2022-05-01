namespace monkeypatch_test;

public static class PrefixConsole
{
    public static void WriteLine(string text)
    {
        System.Console.WriteLine("WithPrefix: " + text);
    }
}