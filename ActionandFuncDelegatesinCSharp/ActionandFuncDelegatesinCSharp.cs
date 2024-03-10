namespace ActionandFuncDelegatesinCSharp
{
    public class ActionandFuncDelegatesinCSharp
    {
        // Simple Action delegate
        public Action<int, int> add = (a, b) => Console.WriteLine($"Sum: {a + b}");
    }
}
