using System.Text.RegularExpressions;

namespace IEnumerables;

public class Harvest
{
    // Methods for Exercise 36

    private Dictionary<string, string> field;
    private int[] horsePosition;

    public Harvest(string fruits, string initialPosition)
    {
        field = new Dictionary<string, string>();
        string[] fruitsArray = fruits.Split(',');
        foreach (string fruit in fruitsArray)
        {
            field[fruit.Substring(0, 2)] = fruit.Substring(2);
        }
        horsePosition = new int[] { 8 - int.Parse(initialPosition[1].ToString()), initialPosition[0] - 'A' };
    }

    public static void ValidateFruits(string fruits)
    {
        string[] separatedFruits = fruits.Split(',');
        foreach (string separatedFruit in separatedFruits)
        {
            if (!Regex.IsMatch(separatedFruit.Trim(), "^[A-H][1-8][-+*=]$"))
            {
                throw new ArgumentException("Invalid Fruit!");
            }
        }
    }

    public static void ValidateInitialPosition(string initialPosition)
    {
        if (!Regex.IsMatch(initialPosition.Trim(), "^[A-H][1-8]$"))
            {
                throw new ArgumentException("Invalid Initial Position!");
            }
    }

    public string CollectFruits(string movements)
    {
        string collectedFruits = string.Empty;
        foreach (string movement in movements.Split(','))
        {
            int[] newPosition = MoveHorse(movement);
            string newPositionStr = (char)('A' + newPosition[1]) + (8 - newPosition[0]).ToString();
            if (field.ContainsKey(newPositionStr))
            {
                collectedFruits += field[newPositionStr];
                field.Remove(newPositionStr);
            }
        }
        return collectedFruits;
    }

    private int[] MoveHorse(string movement)
    {
        int row = horsePosition[0];
        int col = horsePosition[1];
        switch (movement)
        {
            case "UL":
                row -= 2;
                col -= 1;
                break;
            case "UR":
                row -= 2;
                col += 1;
                break;
            case "LU":
                row -= 1;
                col -= 2;
                break;
            case "LD":
                row += 1;
                col -= 2;
                break;
            case "RU":
                row -= 1;
                col += 2;
                break;
            case "RD":
                row += 1;
                col += 2;
                break;
            case "DL":
                row += 2;
                col -= 1;
                break;
            case "DR":
                row += 2;
                col += 1;
                break;
            default:
                throw new ArgumentException("Invalid movement!");
        }
        if (row < 0 || row > 7 || col < 0 || col > 7)
        {
            throw new ArgumentException("Movement out of range!");
        }
        horsePosition[0] = row;
        horsePosition[1] = col;
        return horsePosition;
    }
}

