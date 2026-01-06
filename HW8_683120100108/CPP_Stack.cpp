#include <iostream>
#include <vector>
using namespace std;

// ================= Stack =================
class Stack {
private:
    vector<string> data;

public:
    void push(string value) {
        data.push_back(value);
    }

    void pop() {
        if (!data.empty())
            data.pop_back();
    }

    string peek() {
        if (data.empty())
            return "empty";
        return data.back();
    }

    int size() {
        return data.size();
    }

    bool empty() {
        return data.empty();
    }
};

// ================= List =================
class List {
private:
    vector<string> data;

public:
    void insertFront(string value) {
        data.insert(data.begin(), value);
    }

    void insertBack(string value) {
        data.push_back(value);
    }

    void insert(int index, string value) {
        if (index >= 0 && index <= data.size())
            data.insert(data.begin() + index, value);
    }

    void remove(int index) {
        if (index >= 0 && index < data.size())
            data.erase(data.begin() + index);
    }

    void removeBack() {
        if (!data.empty())
            data.pop_back();
    }

    string peekFront() {
        if (data.empty())
            return "empty";
        return data.front();
    }

    string back() {
        if (data.empty())
            return "empty";
        return data.back();
    }

    int size() {
        return data.size();
    }

    bool empty() {
        return data.empty();
    }
};

// ================= main =================
int main() {

    cout << "=== Stack ===" << endl;
    Stack s;
    s.push("Jack");
    s.push("John");
    s.push("Joe");
    s.push("Jane");
    s.push("Jim");

    cout << "Peek (top): " << s.peek() << endl;
    cout << "Size: " << s.size() << endl;

    s.pop();
    cout << "After pop, peek: " << s.peek() << endl;

    cout << "Empty? " << (s.empty() ? "true" : "false") << endl;

    cout << "\n=== List ===" << endl;
    List l;
    l.insertBack("Jack");
    l.insertBack("John");
    l.insertBack("Joe");
    l.insertBack("Jane");
    l.insertBack("Jim");

    cout << "Front: " << l.peekFront() << endl;
    cout << "Back: " << l.back() << endl;
    cout << "Size: " << l.size() << endl;

    l.remove(2); // remove Joe
    cout << "After remove index 2, back: " << l.back() << endl;

    l.removeBack();
    cout << "After removeBack, size: " << l.size() << endl;

    return 0;
}
