public class Main {
    public static void main(String[] args) {

        System.out.println("=== Stack ===");
        StackClass s = new StackClass();

        s.push("Jack");
        s.push("John");
        s.push("Joe");
        s.push("Jane");
        s.push("Jim");

        System.out.println("Peek: " + s.peek());
        System.out.println("Size: " + s.size());

        s.pop();
        System.out.println("After pop, Peek: " + s.peek());
        System.out.println("Empty? " + s.empty());

        System.out.println("\n=== List ===");
        ListClass l = new ListClass();

        l.insertBack("Jack");
        l.insertBack("John");
        l.insertBack("Joe");
        l.insertBack("Jane");
        l.insertBack("Jim");

        System.out.println("Front: " + l.peekFront());
        System.out.println("Back: " + l.back());
        System.out.println("Size: " + l.size());

        l.remove(2); // remove Joe
        System.out.println("After remove index 2, Back: " + l.back());

        l.removeBack();
        System.out.println("After removeBack, Size: " + l.size());
    }
}
