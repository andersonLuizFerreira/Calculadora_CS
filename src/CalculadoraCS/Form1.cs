namespace CalculadoraCS;

using CalculadoraCS.Core;
using System.Globalization;

public partial class Form1 : Form
{
    private readonly CalculatorEngine _calculator = new();

    public Form1()
    {
        InitializeComponent();
        UpdateDisplay();
    }

    private void DigitButton_Click(object? sender, EventArgs e)
    {
        if (sender is Button button)
        {
            _calculator.InputDigit(button.Text);
            UpdateDisplay();
        }
    }

    private void DecimalButton_Click(object? sender, EventArgs e)
    {
        _calculator.InputDecimalSeparator();
        UpdateDisplay();
    }

    private void OperationButton_Click(object? sender, EventArgs e)
    {
        if (sender is not Button button)
        {
            return;
        }

        var operation = button.Text switch
        {
            "+" => CalculatorOperation.Add,
            "-" => CalculatorOperation.Subtract,
            "*" => CalculatorOperation.Multiply,
            "/" => CalculatorOperation.Divide,
            _ => CalculatorOperation.None
        };

        _calculator.SetOperation(operation);
        UpdateDisplay();
    }

    private void EqualsButton_Click(object? sender, EventArgs e)
    {
        ExecuteSafely(_calculator.Evaluate);
    }

    private void PercentButton_Click(object? sender, EventArgs e)
    {
        ExecuteSafely(_calculator.Percent);
    }

    private void SquareRootButton_Click(object? sender, EventArgs e)
    {
        ExecuteSafely(_calculator.SquareRoot);
    }

    private void ClearButton_Click(object? sender, EventArgs e)
    {
        _calculator.Clear();
        UpdateDisplay();
    }

    private void MemoryRecallButton_Click(object? sender, EventArgs e)
    {
        _calculator.MemoryRecall();
        UpdateDisplay();
    }

    private void MemoryAddButton_Click(object? sender, EventArgs e)
    {
        _calculator.MemoryAdd();
        UpdateDisplay();
    }

    private void MemorySubtractButton_Click(object? sender, EventArgs e)
    {
        _calculator.MemorySubtract();
        UpdateDisplay();
    }

    private void MemoryClearButton_Click(object? sender, EventArgs e)
    {
        _calculator.MemoryClear();
        UpdateDisplay();
    }

    private void ExecuteSafely(Action action)
    {
        try
        {
            action();
        }
        catch (Exception ex) when (ex is DivideByZeroException or InvalidOperationException)
        {
            displayTextBox.Text = "Erro";
            MessageBox.Show(ex.Message, "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _calculator.Clear();
            return;
        }

        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        displayTextBox.Text = _calculator.Display;

        for (var i = 0; i < historyLabels.Length; i++)
        {
            historyLabels[i].Text = i < _calculator.HistoryLines.Count
                ? _calculator.HistoryLines[i]
                : string.Empty;
        }

        memoryLabel.Text = _calculator.Memory == 0m
            ? string.Empty
            : "M " + _calculator.Memory.ToString("0.##########", CultureInfo.CurrentCulture);
    }
}
