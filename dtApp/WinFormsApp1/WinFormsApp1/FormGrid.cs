namespace WinFormsApp1;

public class FormGrid : Form
{
    private int[,] grid = new int[3, 3];
    private Label[,] labels = new Label[3, 3];
    private Button buttonA, buttonB, buttonC, buttonD, resetButton;

    public FormGrid()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Size = new Size(400, 500);
        this.StartPosition = FormStartPosition.CenterScreen;

        int startX = 50;
        int startY = 50;
        int cellSize = 80;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                labels[i, j] = new Label
                {
                    Text = "0",
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(startX + j * cellSize, startY + i * cellSize),
                    Size = new Size(cellSize, cellSize),
                    Font = new Font("Arial", 24)
                };
                this.Controls.Add(labels[i, j]);
            }
        }

        int buttonY = startY + 3 * cellSize + 20;
        int buttonWidth = 80;
        int buttonSpacing = 10;

        buttonA = new Button
        {
            Text = "A",
            Location = new Point(startX, buttonY),
            Size = new Size(buttonWidth, 30)
        };
        buttonA.Click += (s, e) => PressButton('A');
        this.Controls.Add(buttonA);

        buttonB = new Button
        {
            Text = "B",
            Location = new Point(startX + (buttonWidth + buttonSpacing), buttonY),
            Size = new Size(buttonWidth, 30)
        };
        buttonB.Click += (s, e) => PressButton('B');
        this.Controls.Add(buttonB);

        buttonC = new Button
        {
            Text = "C",
            Location = new Point(startX + 2 * (buttonWidth + buttonSpacing), buttonY),
            Size = new Size(buttonWidth, 30)
        };
        buttonC.Click += (s, e) => PressButton('C');
        this.Controls.Add(buttonC);

        buttonD = new Button
        {
            Text = "D",
            Location = new Point(startX + 3 * (buttonWidth + buttonSpacing), buttonY),
            Size = new Size(buttonWidth, 30)
        };
        buttonD.Click += (s, e) => PressButton('D');
        this.Controls.Add(buttonD);

        resetButton = new Button
        {
            Text = "Reset",
            Location = new Point(startX + 4 * (buttonWidth + buttonSpacing), buttonY),
            Size = new Size(buttonWidth, 30)
        };
        resetButton.Click += (s, e) => 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = 0;
                }
            }
            UpdateDisplay();
        };
        this.Controls.Add(resetButton);
    }

    private void PressButton(char button)
    {
        switch (button)
        {
            case 'A': // Top-left 2x2
                grid[0, 0]++;
                grid[0, 1]++;
                grid[1, 0]++;
                grid[1, 1]++;
                break;
            case 'B': // Top-right 2x2
                grid[0, 1]++;
                grid[0, 2]++;
                grid[1, 1]++;
                grid[1, 2]++;
                break;
            case 'C': // Bottom-left 2x2
                grid[1, 0]++;
                grid[1, 1]++;
                grid[2, 0]++;
                grid[2, 1]++;
                break;
            case 'D': // Bottom-right 2x2
                grid[1, 1]++;
                grid[1, 2]++;
                grid[2, 1]++;
                grid[2, 2]++;
                break;
        }

        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                labels[i, j].Text = grid[i, j].ToString();
            }
        }
    }
}

