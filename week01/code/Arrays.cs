public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: make an array the size of length
        double[] multiples = new double[length];

        // Step 2: loop through each spot in the array
        for (int i = 0; i < length; i++)
        {
            // Step 3: fill each spot with number times (i + 1)
            multiples[i] = number * (i + 1);
        }

        // Step 4: return the finished array
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: grab the last 'amount' items from the end of the list
        List<int> tail = data.GetRange(data.Count - amount, amount);

        // Step 2: grab the rest of the items from the front
        List<int> head = data.GetRange(0, data.Count - amount);

        // Step 3: empty the list so we can put it back in the new order
        data.Clear();

        // Step 4: add the end part first, then the front part
        data.AddRange(tail);
        data.AddRange(head);
    }
}
