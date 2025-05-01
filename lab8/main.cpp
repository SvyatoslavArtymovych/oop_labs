#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
#include "ArrayProcessor.h"

using namespace std;

int main() {
    vector<int> arr = {1, 0, 5, 1, 7, 0, 2, 1};

    ArrayProcessor processor(arr);

    cout << "Product of elements with even indices: " << processor.getEvenIndexProduct() << endl;
    cout << "Sum of elements between the first and last zeros: " << processor.sumBetweenFirstAndLastZeros() << endl;

    return 0;
}
