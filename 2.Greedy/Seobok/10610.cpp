#define _CRT_SECURE_NO_WARNINGS	
#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <vector>
#include <queue>
#include <stack>
#include <math.h>
#include <algorithm>
#include <map>

using namespace std;

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	//cout << fixed;
	//cout.precision(6);

	string N;
	cin >> N;

	vector<int> v;

	int sum = 0;

	for (int i = 0; i < N.length(); i++)
	{
		v.push_back(N[i] - '0');
		sum += N[i] - '0';
	}

	sort(v.begin(), v.end());

	if (sum % 3 != 0 || v[0] != 0)
		cout << -1;
	else
	{
		for (int i = 0; i < v.size(); i++)
		{
			cout << v[v.size() - i - 1];
		}
	}

}