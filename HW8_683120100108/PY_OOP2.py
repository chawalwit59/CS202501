# ===== Stack =====
class Stack:
    def __init__(self):
        self.data = []

    def push(self, value):
        self.data.append(value)

    def pop(self):
        if not self.empty():
            return self.data.pop()

    def peek(self):
        if self.empty():
            return "empty"
        return self.data[-1]

    def size(self):
        return len(self.data)

    def empty(self):
        return len(self.data) == 0


# ===== List (สืบทอดจาก Stack) =====
class ListDS(Stack):
    def insertFront(self, value):
        self.data.insert(0, value)

    def insertBack(self, value):
        self.push(value)

    def insert(self, index, value):
        if 0 <= index <= len(self.data):
            self.data.insert(index, value)

    def remove(self, index):
        if 0 <= index < len(self.data):
            self.data.pop(index)

    def removeBack(self):
        self.pop()

    def peekFront(self):
        if self.empty():
            return "empty"
        return self.data[0]

    def back(self):
        return self.peek()


# ===== ทดสอบการทำงาน =====
if __name__ == "__main__":
    print("=== Stack ===")
    s = Stack()
    s.push("Jack")
    s.push("John")
    s.push("Joe")
    print("Top:", s.peek())
    print("Size:", s.size())

    print("\n=== List ===")
    lst = ListDS()
    lst.insertBack("Jack")
    lst.insertBack("John")
    lst.insertFront("Joe")
    lst.insert(1, "Jane")
    print("Front:", lst.peekFront())
    print("Back:", lst.back())
    print("Size:", lst.size())
