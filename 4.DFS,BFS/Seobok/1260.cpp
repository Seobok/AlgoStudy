#define _CRT_SECURE_NO_WARNINGS	
#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <vector>
#include <queue>
#include <math.h>
#include <algorithm>
#include <map>

using namespace std;

vector<int>* arr;
bool* DFS_visitied;
bool* BFS_visitied;
queue <int> BFS_queue;


void DFS(int v)
{
	DFS_visitied[v] = true;
	cout << v << " ";

	for (int i = 0; i < arr[v].size(); i++)
	{
		if (!DFS_visitied[arr[v][i]])
			DFS(arr[v][i]);
	}
}

void BFS(int v)
{
	BFS_visitied[v] = true;

	for (int i = 0; i < arr[v].size(); i++)
	{
		if (!BFS_visitied[arr[v][i]])
		{
			BFS_queue.push(arr[v][i]);
			BFS_visitied[arr[v][i]] = true;
		}

	}

	if (!BFS_queue.empty())
	{
		int temp = BFS_queue.front();
		cout << temp << " ";
		BFS_queue.pop();
		BFS(temp);
	}
}

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	/*cout << fixed;
	cout.precision(0);*/

	int N, M, V;

	cin >> N >> M >> V;

	arr = new vector<int>[N + 1];
	DFS_visitied = new bool[N + 1];
	BFS_visitied = new bool[N + 1];

	for (int i = 0; i < M; i++)
	{
		int a, b;
		cin >> a >> b;
		arr[a].push_back(b);
		arr[b].push_back(a);
	}

	for (int i = 0; i < N + 1; i++)
	{
		sort(arr[i].begin(), arr[i].end());
	}

	for (int i = 0; i < N + 1; i++)
	{
		DFS_visitied[i] = false;
		BFS_visitied[i] = false;
	}

	DFS(V);
	cout << "\n" << V << " ";
	BFS(V);

}