namespace InterviewExercise.ClassLibrary;

public class ExtractSingleOccurrenceOfNumberFromList
{
    public List<int> Extract(int[]? numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The input array is null or empty.");
        }

        var numberCounts = new Dictionary<int, int>();
        foreach (var number in numbers)
        {
            if (numberCounts.ContainsKey(number))
            {
                numberCounts[number]++;
            }
            else
            {
                numberCounts[number] = 1;
            }
        }

        return numberCounts.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key).ToList();
    }
}
