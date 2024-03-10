namespace ActionandFuncDelegatesinCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ActionandFuncDelegatesinCSharp actionandFuncDelegatesinCSharp = new ActionandFuncDelegatesinCSharp();

            // Invoking the Action delegate
            actionandFuncDelegatesinCSharp.add(10, 20);

            // Invoking the Action delegate with no parameters
            actionandFuncDelegatesinCSharp.printMyName();

            // Invoking the Func delegate
            Console.WriteLine($"Square: {actionandFuncDelegatesinCSharp.square(5)}");

            // Invoking the Func delegate
            Console.WriteLine($"Product: {actionandFuncDelegatesinCSharp.multiply(5, 10)}");

            // Invoking the Action delegate
            actionandFuncDelegatesinCSharp.printArray(new int[] { 1, 2, 3, 4, 5 });
        }
    }
}
