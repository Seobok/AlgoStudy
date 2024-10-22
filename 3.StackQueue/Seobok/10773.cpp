#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <vector>
#include <math.h>
#include <algorithm>

using namespace std;

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	//cout << fixed;
	//cout.precision(0);

	int K;

	cin >> K;

	vector<int> v;

	for (int i = 0; i < K; i++)
	{
		int temp;

		cin >> temp;

		if (temp == 0)
			v.pop_back();
		else
			v.push_back(temp);
	}

	int sum = 0;

	for (int i = 0; i < v.size(); i++)
	{
		sum += v[i];
	}

	cout << sum;

	return 0;
}