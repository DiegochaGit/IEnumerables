namespace IEnumerables;

public class HorseConflict
{
    // Methods for Exercise 37

    private Dictionary<string, LinkedList<string>> conflicts;

    public HorseConflict()
    {
        conflicts = new Dictionary<string, LinkedList<string>>();
    }

    public LinkedList<string> GetConflicts(string location)
    {
        if (!conflicts.ContainsKey(location))
        {
            conflicts[location] = new LinkedList<string>();
            foreach (string otherLocation in conflicts.Keys)
            {
                if (HasConflict(location, otherLocation))
                {
                    conflicts[location].AddLast(otherLocation);
                    conflicts[otherLocation].AddLast(location);
                }
            }
        }
        return conflicts[location];
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
}

