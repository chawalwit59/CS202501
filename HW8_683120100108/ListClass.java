import java.util.ArrayList;

public class ListClass {
    private ArrayList<String> data = new ArrayList<>();

    public void insertFront(String value) {
        data.add(0, value);
    }

    public void insertBack(String value) {
        data.add(value);
    }

    public void insert(int index, String value) {
        if (index >= 0 && index <= data.size())
            data.add(index, value);
    }

    public void remove(int index) {
        if (index >= 0 && index < data.size())
            data.remove(index);
    }

    public void removeBack() {
        if (!data.isEmpty())
            data.remove(data.size() - 1);
    }

    public String peekFront() {
        if (data.isEmpty())
            return "empty";
        return data.get(0);
    }

    public String back() {
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
