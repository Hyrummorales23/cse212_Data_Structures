public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>

    ///-----------PLAN TO IMPLEMENT MultiplesOf FUNCTION------------------
    /// Step 1: Create an array to store the results with the specified length
    /// Step 2: Use a loop to calculate each multiple
    /// We'll iterate from 0 to length-1
    /// Step 3: Calculate each multiple by multiplying the number by (i+1)
    /// We use (i+1) because we want 1×, 2×, 3× etc., not 0×
    /// Step 4: Return the completed array of multiples
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1
        double[] multiples = new double[length];
        // Step 2
        for (int i = 0; i < length; i++)
        {
            // Step 3
            multiples[i] = number * (i + 1);
        }
        // Step 4
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>

    //////-----------PLAN TO IMPLEMENT RotateListRight FUNCTION------------------ 
    /// Using List Slicing
    /// Step 1: Calculate the split point - the index where rotation occurs
    /// For right rotation, we take elements from (length - amount) to end
    /// Step 2: Get the right part that will move to the front
    /// Step 3: Get the left part that will move to the back
    /// Step 4: Clear the original list and rebuild it
    /// Add rotated part first
    /// Then add the remaining elements

    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1
        int splitPoint = data.Count - amount;
        // Step 2
        List<int> rightPart = data.GetRange(splitPoint, amount);
        // Step 3
        List<int> leftPart = data.GetRange(0, splitPoint);
        // Step 4
        data.Clear();
        data.AddRange(rightPart); // Add rotated part first
        data.AddRange(leftPart);  // Then add the remaining elements
    }
}
