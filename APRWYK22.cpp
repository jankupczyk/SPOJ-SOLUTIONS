#include <iostream>
#include <vector>

using namespace std;

int max(vector<int> vec)
{
    int max = -1;
    for (auto val : vec)
    {
        if (max < val)
            max = val;
    }
    return max;
}

int min(vector<int> vec)
{
    int min = 10001;
    for (auto val : vec)
    {
        if (val < min)
            min = val;
    }
    return min;
}

int main()
{
    int len;
    vector<int> inputs;

    cin >> len;

    if (!(len >= 1 && len <= 10000))
        return -1;

    int x;
    for (size_t i = 0; i < len; i++)
    {
        cin >> x;
        if (x >= 1 && x <= 1000)
        {
            inputs.push_back(x);
        }
    }
    cout << min(inputs) << " " << max(inputs);
}