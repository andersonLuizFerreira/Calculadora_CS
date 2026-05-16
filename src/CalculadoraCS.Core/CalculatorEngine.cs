using System.Globalization;

namespace CalculadoraCS.Core;

public sealed class CalculatorEngine
{
    private readonly List<string> _history = new();
    private decimal? _leftOperand;
    private CalculatorOperation _pendingOperation = CalculatorOperation.None;
    private bool _replaceDisplay = true;

    public string Display { get; private set; } = "0";

    public decimal Memory { get; private set; }

    public IReadOnlyList<string> HistoryLines => _history;

    private static string DecimalSeparator => CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

    public void InputDigit(string digit)
    {
        if (digit.Length != 1 || digit[0] < '0' || digit[0] > '9')
        {
            throw new ArgumentException("Digit must be a single numeric character.", nameof(digit));
        }

        if (_replaceDisplay || Display == "0")
        {
            Display = digit;
            _replaceDisplay = false;
            return;
        }

        Display += digit;
    }

    public void InputDecimalSeparator()
    {
        if (_replaceDisplay)
        {
            Display = "0" + DecimalSeparator;
            _replaceDisplay = false;
            return;
        }

        if (!Display.Contains(DecimalSeparator, StringComparison.Ordinal))
        {
            Display += DecimalSeparator;
        }
    }

    public void SetOperation(CalculatorOperation operation)
    {
        if (operation == CalculatorOperation.None)
        {
            return;
        }

        if (_pendingOperation != CalculatorOperation.None && !_replaceDisplay)
        {
            Evaluate();
        }

        _leftOperand = CurrentValue();
        _pendingOperation = operation;
        _replaceDisplay = true;
    }

    public void Evaluate()
    {
        if (_pendingOperation == CalculatorOperation.None || _leftOperand is null)
        {
            _replaceDisplay = true;
            return;
        }

        var rightOperand = CurrentValue();
        var result = Calculate(_leftOperand.Value, rightOperand, _pendingOperation);
        AddHistory($"{Format(_leftOperand.Value)} {SymbolFor(_pendingOperation)} {Format(rightOperand)} = {Format(result)}");
        Display = Format(result);
        _leftOperand = null;
        _pendingOperation = CalculatorOperation.None;
        _replaceDisplay = true;
    }

    public void Percent()
    {
        var current = CurrentValue();
        var percentValue = _leftOperand.HasValue && _pendingOperation != CalculatorOperation.None
            ? _leftOperand.Value * current / 100m
            : current / 100m;

        Display = Format(percentValue);
        _replaceDisplay = true;
    }

    public void SquareRoot()
    {
        var value = CurrentValue();
        if (value < 0)
        {
            throw new InvalidOperationException("Nao e possivel calcular raiz quadrada de numero negativo.");
        }

        var result = (decimal)Math.Sqrt((double)value);
        AddHistory($"sqr({Format(value)}) = {Format(result)}");
        Display = Format(result);
        _replaceDisplay = true;
    }

    public void Clear()
    {
        Display = "0";
        _leftOperand = null;
        _pendingOperation = CalculatorOperation.None;
        _replaceDisplay = true;
    }

    public void MemoryRecall()
    {
        Display = Format(Memory);
        _replaceDisplay = true;
    }

    public void MemoryAdd()
    {
        Memory += CurrentValue();
        _replaceDisplay = true;
    }

    public void MemorySubtract()
    {
        Memory -= CurrentValue();
        _replaceDisplay = true;
    }

    public void MemoryClear()
    {
        Memory = 0m;
        _replaceDisplay = true;
    }

    private decimal CurrentValue()
    {
        if (decimal.TryParse(Display, NumberStyles.Number, CultureInfo.CurrentCulture, out var value))
        {
            return value;
        }

        throw new InvalidOperationException("Display contem valor numerico invalido.");
    }

    private static decimal Calculate(decimal left, decimal right, CalculatorOperation operation)
    {
        return operation switch
        {
            CalculatorOperation.Add => left + right,
            CalculatorOperation.Subtract => left - right,
            CalculatorOperation.Multiply => left * right,
            CalculatorOperation.Divide when right == 0m => throw new DivideByZeroException("Nao e possivel dividir por zero."),
            CalculatorOperation.Divide => left / right,
            _ => right
        };
    }

    private void AddHistory(string entry)
    {
        _history.Insert(0, entry);
        if (_history.Count > 4)
        {
            _history.RemoveAt(_history.Count - 1);
        }
    }

    private static string Format(decimal value)
    {
        return value.ToString("0.##########", CultureInfo.CurrentCulture);
    }

    private static string SymbolFor(CalculatorOperation operation)
    {
        return operation switch
        {
            CalculatorOperation.Add => "+",
            CalculatorOperation.Subtract => "-",
            CalculatorOperation.Multiply => "*",
            CalculatorOperation.Divide => "/",
            _ => string.Empty
        };
    }
}
