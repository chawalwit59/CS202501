import java.util.ArrayList;

public class StackClass {
    private ArrayList<String> data = new ArrayList<>();

    public void push(String value) {
        data.add(value);
    }

    public void pop() {
        if (!data.isEmpty())
            data.remove(data.size() - 1);
    }

    public String peek() {
        if (data.isEmpty())
            return "empty";
        return data.get(data.size() - 1);
    }

    public int size() {
        return data.size();
    }

    public boolean empty() {
        return data.isEmpty();
    }
}
