namespace ActionandFuncDelegatesinCSharp
{
    public class ActionandFuncDelegatesinCSharp
    {
        // Simple Action delegate
        public Action<int, int> add = (a, b) => Console.WriteLine($"Sum: {a + b}");

        // Action delegate with no parameters
        public Action printMyName = () => Console.WriteLine("Sardar Mudassar Ali Khan!");

        // Func delegate to calculate square
        public Func<int, int> square = x => x * x;

        // Func delegate with multiple parameters
        public Func<int, int, int> multiply = (x, y) => x * y;

        // Action delegate to print elements of an array
        public Action<int[]> printArray = (arr) =>
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        };

        // Func delegate to find the maximum value in an array
        public Func<int[], int> maxNumber = arr => arr.Max();
    }
}

