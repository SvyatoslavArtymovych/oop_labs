// Stack.h
#ifndef STACK_H
#define STACK_H

#include <vector>
#include <iostream>
using namespace std;

template<typename T>
class Stack {
private:
    vector<T> data;

public:
    void push(const T& value) {
        data.push_back(value);
    }

    void pop() {
        if (!data.empty()) {
            data.pop_back();
        } else {
            cout << "The stack is already emtpy!" << endl;
        }
    }

    Stack<T> copy() const {
        Stack<T> newStack;
        newStack.data = data;
        return newStack;
    }

    void print() const {
        cout << "Stack: ";
        for_each(data.rbegin(), data.rend(), [](const T& item) {
            cout << item << " ";
        });
        cout << endl;
    }
};

#endif
