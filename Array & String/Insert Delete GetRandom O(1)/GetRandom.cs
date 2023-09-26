public class RandomizedSet
{
    private Dictionary<int, int> indices;
    private List<int> arr;
    private Random rand;

    public RandomizedSet()
    {
        indices = new Dictionary<int, int>();
        arr = new List<int>();
        rand = new Random();
    }

    public bool Insert(int val)
    {
        if (indices.ContainsKey(val))
            return false;

        arr.Add(val);
        indices[val] = arr.Count - 1;
        return true;
    }

    public bool Remove(int val)
    {
        if (!indices.ContainsKey(val))
            return false;

        int i = indices[val];
        indices[arr[arr.Count - 1]] = i;
        arr[i] = arr[arr.Count - 1];
        indices.Remove(val);
        arr.RemoveAt(arr.Count - 1);
        return true;
    }

    public int GetRandom()
    {
        return arr[rand.Next(arr.Count)];
    }
}