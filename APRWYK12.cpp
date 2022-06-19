#include <iostream>
#include <vector>

using namespace std;

int sum(vector<int> vec)
{
	int s = 0;
	for (auto val : vec) {
		s += val;
	}
	return s;
}


int main()
{
	int input;
	vector<int> inputs;

	cin >> input;
	inputs.clear();

	if (!(input >= 1 && input <= 100))
		return -1;

	for (size_t i = 1; i < input + 1; i++)
	{
		inputs.push_back(i * i);
		cout << i * i << endl;
	}

	cout << sum(inputs);
}