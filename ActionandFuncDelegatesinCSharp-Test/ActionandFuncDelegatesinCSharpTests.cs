using ActionandFuncDelegatesinCSharp;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace ActionandFuncDelegatesinCSharp_Test
{
    public class ActionandFuncDelegatesinCSharpTests
    {
        [Fact]
        public void TestAddActionDelegate()
        {
            var funcDelegatesinCSharpCode = new ActionandFuncDelegatesinCSharpCode();
            var expectedOutput = "Sum: 11";
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            funcDelegatesinCSharpCode.add(3, 8);
            consoleOutput.Flush();

            Assert.Equal(expectedOutput, consoleOutput.ToString().Trim());
        }

        [Fact]
        public void TestPrintMyNameActionDelegate()
        {
            var funcDelegatesinCSharpCode = new ActionandFuncDelegatesinCSharpCode();
            var expectedOutput = "Sardar Mudassar Ali Khan";
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            funcDelegatesinCSharpCode.printMyName();
            consoleOutput.Flush(); 

            Assert.Equal(expectedOutput, consoleOutput.ToString().Trim());
        }

        [Fact]
        public void TestSquareFuncDelegate()
        {
            var funcDelegatesinCSharpCode = new ActionandFuncDelegatesinCSharpCode();
            var result = funcDelegatesinCSharpCode.square(4);

            Assert.Equal(16, result);
        }

        [Fact]
        public void TestMultiplyFuncDelegate()
        {
            var funcDelegatesinCSharpCode = new ActionandFuncDelegatesinCSharpCode();
            var result = funcDelegatesinCSharpCode.multiply(3, 5);

            Assert.Equal(15, result);
        }

        [Fact]
        public void TestPrintArrayActionDelegate()
        {
            var funcDelegatesinCSharpCode = new ActionandFuncDelegatesinCSharpCode();
            var expectedOutput = "1\n2\n3\n";
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            funcDelegatesinCSharpCode.printArray(new[] { 1, 2, 3 });
            consoleOutput.Flush();

            Assert.Equal(expectedOutput, consoleOutput.ToString());

        }

        [Fact]
        public void TestMaxNumberFuncDelegate()
        {
            var funcDelegatesinCSharpCode = new ActionandFuncDelegatesinCSharpCode();
            var result = funcDelegatesinCSharpCode.maxNumber(new[] { 5, 10, 3, 8 });

            Assert.Equal(10, result);
        }

        [Fact]
        public void TestLogMessageActionDelegate()
        {
            var funcDelegatesinCSharpCode = new ActionandFuncDelegatesinCSharpCode();
            var expectedOutput = "Log: Testing logging\n";
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            funcDelegatesinCSharpCode.logMessage("Testing logging");
            consoleOutput.Flush(); 

            Assert.Equal(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void TestIsEvenFuncDelegate()
        {
            var funcDelegatesinCSharpCode = new ActionandFuncDelegatesinCSharpCode();
            var result = funcDelegatesinCSharpCode.isEven(6);

            Assert.True(result);
        }

        [Fact]
        public void TestArithmeticOperationActionDelegate()
        {
            var funcDelegatesinCSharpCode = new ActionandFuncDelegatesinCSharpCode();
            var expectedOutput = "Sum: 12\nDifference: 8\nProduct: 20\nDivision: 5\n";
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            funcDelegatesinCSharpCode.arithmeticOperation(10, 2);
            consoleOutput.Flush();

            Assert.Equal(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void TestConcatenateFuncDelegate()
        {
            var funcDelegatesinCSharpCode = new ActionandFuncDelegatesinCSharpCode();
            var result = funcDelegatesinCSharpCode.concatenate("Hello, ", "World!");

            Assert.Equal("Hello, World!", result);
        }

    }
}