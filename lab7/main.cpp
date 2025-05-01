// main.cpp
#include "Stack.h"

int main() {
    // Create a stack of integers
    Stack<int> s;

    // Add some elements to the stack and print it
    s.push(10);
    s.push(20);
    s.push(30);
    s.print();

    // Pop an element from the stack and print again
    s.pop();
    s.print();

    // Copy the stack and print the copy
    Stack<int> s2 = s.copy();
    cout << "Stack copy:" << endl;
    s2.print();

    // Show that the original stack is not affected
    cout << "Original stack after copy:" << endl;
    s.print();
    s2.pop();
    cout << "Stack copy after pop:" << endl;
    s2.print();
    cout << "Original stack after copy and pop:" << endl;
    s.print();

    return 0;
}
