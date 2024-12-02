#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;



int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	int N, M, X;
	cin >> N >> M >> X;

	vector<vector<pair<int,int>>> road;
	vector<vector<pair<int, int>>> reverse_road;

	for (int i = 0; i <= N; i++)
	{
		vector<pair<int, int>> v1, v2;
		road.push_back(v1);
		reverse_road.push_back(v2);
	}

	for (int i = 0; i < M; i++)
	{
		int start, end, T;
		cin >> start >> end >> T;

		road[start].push_back({ end, T });
		reverse_road[end].push_back({ start,T });
	}

	int* dist = new int[N + 1];
	int* reverse_dist = new int[N + 1];
	for (int i = 0; i < N + 1; i++)
	{
		dist[i] = -1;
		reverse_dist[i] = -1;
	}

	dist[X] = 0;
	reverse_dist[X] = 0;

	bool* visited = new bool[N + 1];
	bool* reverse_visited = new bool[N + 1];
	for (int i = 0; i < N + 1; i++)
	{
		visited[i] = false;
		reverse_visited[i] = false;
	}

	//다익스트라 ( X => ALL )
	for (int i = 0; i < N; i++)
	{
		//curPos정하기
		int minDist = 1000001;
		int curPos = 0;
		for (int j = 1; j <= N; j++)
		{
			if (dist[j] != -1 && minDist > dist[j] && visited[j] == false)
			{
				minDist = dist[j];
				curPos = j;
			}
		}
		visited[curPos] = true;

		for (int j = 0; j < road[curPos].size(); j++)
		{
			if (dist[road[curPos][j].first] > dist[curPos] + road[curPos][j].second || dist[road[curPos][j].first] == -1)
			{
				dist[road[curPos][j].first] = dist[curPos] + road[curPos][j].second;
			}
		}
	}

	//다익스트라 (ALL => X)
	for (int i = 0; i < N; i++)
	{
		//curPos정하기
		int minDist = 1000001;
		int curPos = 0;
		for (int j = 1; j <= N; j++)
		{
			if (reverse_dist[j] != -1 && minDist > reverse_dist[j] && reverse_visited[j] == false)
			{
				minDist = reverse_dist[j];
				curPos = j;
			}
		}
		reverse_visited[curPos] = true;

		for (int j = 0; j < reverse_road[curPos].size(); j++)
		{
			if (reverse_dist[reverse_road[curPos][j].first] > reverse_dist[curPos] + reverse_road[curPos][j].second || reverse_dist[reverse_road[curPos][j].first] == -1)
			{
				reverse_dist[reverse_road[curPos][j].first] = reverse_dist[curPos] + reverse_road[curPos][j].second;
			}
		}
	}

	int maxDist = 0;
	for (int i = 1; i <= N; i++)
	{
		if (maxDist < dist[i] + reverse_dist[i])
		{
			maxDist = dist[i] + reverse_dist[i];
		}
	}

	cout << maxDist;

	return 0;
}