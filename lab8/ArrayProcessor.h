#ifndef ARRAY_PROCESSOR_H
#define ARRAY_PROCESSOR_H

#include <vector>
#include <algorithm>
#include <numeric>
using namespace std;

class ArrayProcessor {
private:
    vector<int> data;

public:
    ArrayProcessor(const vector<int>& input) : data(input) {}

    int getEvenIndexProduct() const {
        int product = 1;
        for (size_t i = 0; i < data.size(); i += 2) {
            product *= data[i];
        }
        return product;
    }

    int sumBetweenFirstAndLastZeros() const {
        auto firstZero = find(data.begin(), data.end(), 0);
        auto lastZeroReverse = find(data.rbegin(), data.rend(), 0);

        // check if we found both zeros
        if (firstZero == data.end() || lastZeroReverse == data.rend())
            return 0;

        auto lastZero = data.end() - (lastZeroReverse - data.rbegin());

        // check if the first zero is before the last zero
        if (firstZero >= lastZero)
            return 0;

        return accumulate(firstZero + 1, lastZero, 0);
    }
};

#endif
