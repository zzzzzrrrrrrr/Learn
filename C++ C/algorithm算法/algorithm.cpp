#include <iostream>
#include<algorithm>
#include<vector>

using namespace std;

//sort排序(begin指针和end指针)
int main()
{
	vector<int> nums = { 3 ,7 , 1  ,9  ,5 , 2  , 6 };
	sort(nums.begin(), nums.end());
	//partial_sort(nums.begin(), nums.begin() + 3, nums.end());
	

	for (auto num : nums)
	{
		cout << num << " ";
	}
	cout << endl;

	//find查找某个特定位置的数字
	auto ret = find(nums.begin(), nums.end(), 5);

	cout << *ret << endl;

	return 0;
}