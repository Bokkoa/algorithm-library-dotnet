namespace AlgorithmLibrary.Entities;

public class LongestConsecutiveSequenceEntity
{
    public int Execute(int[] nums) {

        if(nums.Length <= 0) return 0;

        int currentLongSequence = 0;
        int longestSequence = 0;

        Dictionary<int, bool> history = nums.Distinct().ToDictionary(n => n, n => false);

        for(int index = 0; index < nums.Length; index++)
        {
            bool hasNext = true;
            bool hasPrev = true;
            currentLongSequence = 1;

            // not visited
            if (history[nums[index]] == false)
            {
                int nextNum = nums[index] + 1;
                while (history.ContainsKey(nextNum) && history[nextNum] == false)
                {
                    currentLongSequence++;
                    history[nextNum] = true;
                    nextNum += 1;
                }

                int prevNum = nums[index] - 1;

                while (history.ContainsKey(prevNum) && history[prevNum] == false)
                {
                        currentLongSequence++;
                        history[prevNum] = true;
                        prevNum -= 1;
                }
            }

            if(currentLongSequence > longestSequence) { longestSequence = currentLongSequence; }

        }

       
        return longestSequence;
    }

    public int ExecuteNLogNAlgorithm(int[] nums)
    {

        if (nums.Length <= 0) return 0;

        int currentLongSequence = 0;
        int longestSequence = 0;

        nums = nums.OrderBy(n => n).ToArray();

        for (int index = 0; index < nums.Length - 1; index++)
        {
            // skipping repeated values
            if (nums[index] == nums[index + 1]) continue;


            if ((nums[index]) + 1 == nums[index + 1])
            {
                currentLongSequence++;
            }
            else
            {
                if (currentLongSequence > longestSequence)
                {
                    // updating longest in case
                    longestSequence = currentLongSequence;
                }

                // reseting secuence
                currentLongSequence = 0;
            }

        }

        if (currentLongSequence > longestSequence)
        {
            // updating longest in case
            longestSequence = currentLongSequence;
        }
        // sum the initial value count
        return longestSequence + 1;
    }

}
