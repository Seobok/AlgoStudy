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

	int T;

	cin >> T;

	string temp;
	getline(cin, temp);

	for (int j = 0; j < T; j++)
	{
		string n;

		getline(cin, n);

		vector<int> v;
		bool check = true;

		for (int i = 0; i < n.length(); i++)
		{
			if (n[i] == '(')
			{
				v.push_back(1);
			}
			if (n[i] == ')')
			{
				if (v.empty())
				{
					check = false;
					break;
				}
				if (v.back() == 1)
				{
					v.pop_back();
				}
				else
				{
					check = false;
					break;
				}
			}
		}

		if (!v.empty())
			check = false;
		if (check)
			cout << "YES\n";
		else
			cout << "NO\n";
	}

	return 0;
}