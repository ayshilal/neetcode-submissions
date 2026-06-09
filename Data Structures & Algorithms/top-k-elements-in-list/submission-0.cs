public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
      List<int> topKElements = new List<int>();
      Dictionary<int, int> numberOfOccurrences = new Dictionary<int, int>();


        foreach(int number in nums)
        {
            if(!numberOfOccurrences.ContainsKey(number))
                numberOfOccurrences.Add(number, 1);
        
            else
                numberOfOccurrences[number]++;
        }

        topKElements = new List<int>(numberOfOccurrences.Keys);
        topKElements.Sort((a, b) => numberOfOccurrences[b].CompareTo(numberOfOccurrences[a]));
    
    return topKElements.GetRange(0, k).ToArray();
    }
}
