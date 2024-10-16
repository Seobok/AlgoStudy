#define _USE_MATH_DEFINES

#include <iostream>
#include <vector>
#include <math.h>
#include <algorithm>

using namespace std;

bool compare_len(string a, string b)
{
	return a.length() < b.length();
}

bool compare_dict(string a, string b)
{
	return a.compare(b) < 0;
}

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	//cout << fixed;
	//cout.precision(6);

	int N;

	cin >> N;

	string* words = new string[N];

	for (int i = 0; i < N; i++)
	{
		cin >> words[i];
	}

	if (N == 1)
		cout << words[0];

	else
	{
		sort(words, words + N, compare_dict);
		stable_sort(words, words + N, compare_len);

		for (int i = 0; i < N; i++)
		{
			if (i == N - 1)
			{
				cout << words[i] << "\n";
			}
			else if (words[i].compare(words[i + 1]) != 0)
			{
				cout << words[i] << "\n";
			}
		}
	}

	return 0;
}