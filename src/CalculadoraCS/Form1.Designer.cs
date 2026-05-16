namespace CalculadoraCS;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        displayTextBox = new TextBox();
        memoryLabel = new Label();
        historyLabels = new Label[4];
        var keypad = new TableLayoutPanel();
        SuspendLayout();
        keypad.SuspendLayout();

        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(242, 244, 248);
        ClientSize = new Size(360, 560);
        MinimumSize = new Size(360, 560);
        Text = "Calculadora";

        displayTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        displayTextBox.BackColor = Color.White;
        displayTextBox.BorderStyle = BorderStyle.FixedSingle;
        displayTextBox.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
        displayTextBox.Location = new Point(16, 16);
        displayTextBox.Name = "displayTextBox";
        displayTextBox.ReadOnly = true;
        displayTextBox.Size = new Size(312, 57);
        displayTextBox.TabIndex = 0;
        displayTextBox.Text = "0";
        displayTextBox.TextAlign = HorizontalAlignment.Right;

        memoryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        memoryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        memoryLabel.ForeColor = Color.FromArgb(38, 84, 124);
        memoryLabel.Location = new Point(16, 80);
        memoryLabel.Name = "memoryLabel";
        memoryLabel.Size = new Size(312, 20);
        memoryLabel.TabIndex = 1;
        memoryLabel.TextAlign = ContentAlignment.MiddleRight;

        for (var i = 0; i < historyLabels.Length; i++)
        {
            historyLabels[i] = new Label
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(82, 93, 105),
                Location = new Point(16, 104 + (i * 24)),
                Name = $"historyLabel{i + 1}",
                Size = new Size(312, 22),
                TabIndex = 2 + i,
                TextAlign = ContentAlignment.MiddleRight
            };
            Controls.Add(historyLabels[i]);
        }

        keypad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        keypad.ColumnCount = 4;
        keypad.Location = new Point(16, 212);
        keypad.Name = "keypad";
        keypad.RowCount = 6;
        keypad.Size = new Size(312, 300);
        keypad.TabIndex = 6;

        for (var column = 0; column < 4; column++)
        {
            keypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        }

        for (var row = 0; row < 6; row++)
        {
            keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        }

        AddButton(keypad, "MC", 0, 0, MemoryClearButton_Click);
        AddButton(keypad, "MR", 1, 0, MemoryRecallButton_Click);
        AddButton(keypad, "M+", 2, 0, MemoryAddButton_Click);
        AddButton(keypad, "M-", 3, 0, MemorySubtractButton_Click);

        AddButton(keypad, "C", 0, 1, ClearButton_Click);
        AddButton(keypad, "%", 1, 1, PercentButton_Click);
        AddButton(keypad, "sqr", 2, 1, SquareRootButton_Click);
        AddButton(keypad, "/", 3, 1, OperationButton_Click, true);

        AddButton(keypad, "7", 0, 2, DigitButton_Click);
        AddButton(keypad, "8", 1, 2, DigitButton_Click);
        AddButton(keypad, "9", 2, 2, DigitButton_Click);
        AddButton(keypad, "*", 3, 2, OperationButton_Click, true);

        AddButton(keypad, "4", 0, 3, DigitButton_Click);
        AddButton(keypad, "5", 1, 3, DigitButton_Click);
        AddButton(keypad, "6", 2, 3, DigitButton_Click);
        AddButton(keypad, "-", 3, 3, OperationButton_Click, true);

        AddButton(keypad, "1", 0, 4, DigitButton_Click);
        AddButton(keypad, "2", 1, 4, DigitButton_Click);
        AddButton(keypad, "3", 2, 4, DigitButton_Click);
        AddButton(keypad, "+", 3, 4, OperationButton_Click, true);

        AddButton(keypad, "0", 0, 5, DigitButton_Click);
        AddButton(keypad, ".", 1, 5, DecimalButton_Click);
        AddButton(keypad, "=", 2, 5, EqualsButton_Click, true, 2);

        Controls.Add(keypad);
        Controls.Add(memoryLabel);
        Controls.Add(displayTextBox);
        keypad.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox displayTextBox;
    private Label memoryLabel;
    private Label[] historyLabels;

    private static void AddButton(
        TableLayoutPanel keypad,
        string text,
        int column,
        int row,
        EventHandler clickHandler,
        bool accent = false,
        int columnSpan = 1)
    {
        var button = new Button
        {
            BackColor = accent ? Color.FromArgb(38, 84, 124) : Color.White,
            Dock = DockStyle.Fill,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 12F, FontStyle.Bold),
            ForeColor = accent ? Color.White : Color.FromArgb(35, 43, 52),
            Margin = new Padding(4),
            Name = $"button{text.Replace("+", "Plus").Replace("-", "Minus").Replace("*", "Multiply").Replace("/", "Divide").Replace("%", "Percent").Replace(".", "Decimal")}",
            TabIndex = row * 4 + column + 10,
            Text = text,
            UseVisualStyleBackColor = false
        };

        button.FlatAppearance.BorderColor = Color.FromArgb(210, 216, 224);
        button.Click += clickHandler;
        keypad.Controls.Add(button, column, row);

        if (columnSpan > 1)
        {
            keypad.SetColumnSpan(button, columnSpan);
        }
    }
}
