using System.Collections.Generic;

public class StackClass
{
    private List<string> data = new List<string>();

    public void Push(string value)
    {
        data.Add(value);
    }

    public void Pop()
    {
        if (data.Count > 0)
            data.RemoveAt(data.Count - 1);
    }

    public string Peek()
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
