﻿namespace ActionandFuncDelegatesinCSharp
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
        }
    }
}
