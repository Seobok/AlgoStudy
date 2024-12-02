#include <iostream>
#include <vector>
using namespace std;

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	int N, M;
	cin >> N >> M;

	vector<vector<pair<int, int>>> v;
	for (int i = 0; i < N; i++)
	{
		vector<pair<int, int>> temp;
		v.push_back(temp);
	}

	for (int i = 0; i < M; i++)
	{
		int S, E, P;
		cin >> S >> E >> P;

		v[S - 1].push_back({ E - 1,P });
	}

	int Start, End;
	cin >> Start >> End;
	Start--;
	End--;

	bool* visited = new bool[N];
	for (int i = 0; i < N; i++)
	{
		visited[i] = false;
	}
	int* dist = new int[N];
	for (int i = 0; i < N; i++)
	{
		dist[i] = 100000001;
	}

	dist[Start] = 0;

	for (int i = 0; i < N; i++)
	{
		int curPoint;
		int minDist = 100000001;
		for (int j = 0; j < N; j++)
		{
			if (visited[j] == false && dist[j] < minDist)
			{
				curPoint = j;
				minDist = dist[j];
			}
		}


		visited[curPoint] = true;
		for (int j = 0; j < v[curPoint].size(); j++)
		{
			int visitPoint = v[curPoint][j].first;
			if (dist[visitPoint] > dist[curPoint] + v[curPoint][j].second)
			{
				dist[visitPoint] = dist[curPoint] + v[curPoint][j].second;
			}
		}
	}

	cout << dist[End];



	return 0;
}