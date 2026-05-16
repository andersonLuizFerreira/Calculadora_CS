using CalculadoraCS.Core;

namespace CalculadoraCS.Tests;

[TestClass]
public sealed class CalculatorEngineTests
{
    [TestMethod]
    public void Evaluate_Addition_UpdatesDisplayAndHistory()
    {
        var calculator = new CalculatorEngine();

        calculator.InputDigit("2");
        calculator.SetOperation(CalculatorOperation.Add);
        calculator.InputDigit("3");
        calculator.Evaluate();

        Assert.AreEqual("5", calculator.Display);
        Assert.AreEqual(1, calculator.HistoryLines.Count);
    }

    [TestMethod]
    public void Percent_WithPendingAddition_UsesWindowsCalculatorBehavior()
    {
        var calculator = new CalculatorEngine();

        calculator.InputDigit("2");
        calculator.InputDigit("0");
        calculator.InputDigit("0");
        calculator.SetOperation(CalculatorOperation.Add);
        calculator.InputDigit("1");
        calculator.InputDigit("0");
        calculator.Percent();
        calculator.Evaluate();

        Assert.AreEqual("220", calculator.Display);
    }

    [TestMethod]
    public void SquareRoot_ForValidValue_UpdatesDisplay()
    {
        var calculator = new CalculatorEngine();

        calculator.InputDigit("9");
        calculator.SquareRoot();

        Assert.AreEqual("3", calculator.Display);
    }

    [TestMethod]
    public void MemoryOperations_UpdateAndRecallMemory()
    {
        var calculator = new CalculatorEngine();

        calculator.InputDigit("8");
        calculator.MemoryAdd();
        calculator.Clear();
        calculator.InputDigit("3");
        calculator.MemorySubtract();
        calculator.MemoryRecall();

        Assert.AreEqual("5", calculator.Display);
    }

    [TestMethod]
    public void History_KeepsOnlyFourMostRecentLines()
    {
        var calculator = new CalculatorEngine();

        for (var i = 0; i < 5; i++)
        {
            calculator.InputDigit("1");
            calculator.SetOperation(CalculatorOperation.Add);
            calculator.InputDigit("1");
            calculator.Evaluate();
            calculator.Clear();
        }

        Assert.AreEqual(4, calculator.HistoryLines.Count);
    }

    [TestMethod]
    public void DivideByZero_Throws()
    {
        var calculator = new CalculatorEngine();

        calculator.InputDigit("1");
        calculator.SetOperation(CalculatorOperation.Divide);
        calculator.InputDigit("0");

        Assert.ThrowsException<DivideByZeroException>(calculator.Evaluate);
    }
}
