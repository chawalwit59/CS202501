using System.Collections.Generic;

public class ListClass
{
    private List<string> data = new List<string>();

    public void InsertFront(string value)
    {
        data.Insert(0, value);
    }

    public void InsertBack(string value)
    {
        data.Add(value);
    }

    public void Insert(int index, string value)
    {
        if (index >= 0 && index <= data.Count)
            data.Insert(index, value);
    }

    public void Remove(int index)
    {
        if (index >= 0 && index < data.Count)
            data.RemoveAt(index);
    }

    public void RemoveBack()
    {
        if (data.Count > 0)
            data.RemoveAt(data.Count - 1);
    }

    public string PeekFront()
    {
        if (data.Count == 0)
            return "empty";
        return data[0];
    }

    public string Back()
    {
        if (data.Count == 0)
            return "empty";
        return data[data.Count - 1];
    }

    public int Size()
    {
        return data.Count;
    }

    public bool Empty()
    {
        return data.Count == 0;
    }
}
