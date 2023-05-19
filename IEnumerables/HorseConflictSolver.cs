using System.Text.RegularExpressions;

namespace IEnumerables;

public class HorseConflictSolver
{
    // Methods for Exercise 37

    private LinkedList<string> horseLocations;
    private Dictionary<string, List<string>> conflicts;

    public HorseConflictSolver()
    {
        horseLocations = new LinkedList<string>();
        conflicts = new Dictionary<string, List<string>>();
    }

    public static void ValidateLocations(string locations)
    {
        string[] separatedLocations = locations.Split(',');
        foreach (string separatedLocation in separatedLocations)
        {
            if (!Regex.IsMatch(separatedLocation.Trim(), "^[A-H][1-8]$"))
            {
                throw new ArgumentException("Invalid Location of a horse!");
            }
        }
    }

    public void ProcessInput(string input)
    {
        string[] locations = input.Split(',');
        foreach (string location in locations)
        {
            horseLocations.AddLast(location.Trim());
            conflicts[location.Trim()] = new List<string>();
        }

        foreach (string location in horseLocations)
        {
            CheckConflicts(location);
        }
    }

    private void CheckConflicts(string location)
    {
        foreach (string otherLocation in horseLocations)
        {
            if (location != otherLocation && HasConflict(location, otherLocation))
            {
                if (!conflicts[location].Contains(otherLocation))
                {
                    conflicts[location].Add(otherLocation);
                }
                if (!conflicts[otherLocation].Contains(location))
                {
                    conflicts[otherLocation].Add(location);
                }
            }
        }
    }

    private bool HasConflict(string location1, string location2)
    {
        int x1 = location1[0] - 'A';
        int y1 = location1[1] - '1';
        int x2 = location2[0] - 'A';
        int y2 = location2[1] - '1';

        int dx = Math.Abs(x1 - x2);
        int dy = Math.Abs(y1 - y2);

        return (dx == 1 && dy == 2) || (dx == 2 && dy == 1);
    }


    public string GetResults()
    {
        var results = string.Empty;
        foreach (string location in horseLocations)
        {
            results += $"Analyzing Horse in {location} => ";
            if (conflicts[location].Count == 0)
            {
                results += "none";
            }
            else
            {
                for (int i = conflicts[location].Count - 1; i >= 0; i--)
                {
                    results += $"Conflict with {conflicts[location][i]}   ";
                }
            }
            results += "\n";
        }
        return results;
    }
}

