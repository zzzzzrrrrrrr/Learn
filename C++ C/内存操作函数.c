#define _CRT_SECURE_NO_WARNINGS

#include<stdio.h>

//memcpy -- 针对内存块进行拷贝
/*int main()
{
	int arr1[] = { 1,2,3,4,5,6,7,8,9,10 };
	int arr2[20] = { 0 };

	memcpy(arr2, arr1, 20);

	int i = 0;
	for (i = 0; i < 20; i++)
	{
		printf("%d ", arr2[i]);
	}

	return 0;
}*/

//memcpy函数的模拟实现
//memcpy拷贝结束后，会返回目标空间的起始地址
/*void my_memcpy(void* dest,void* src,size_t num)
{
	void* ret = dest;
	int i = 0;
	assert(dest && src);
	while (num--)
	{
		*(char*)dest = *(char*)src;
		((char*)src)++;
		((char*)dest)++;
	}
	return ret;
}

int main()
{
	int arr1[] = { 1,2,3,4,5,6,7,8,9,10 };
	int arr2[20] = { 0 };

	my_memcpy(arr2, arr1, 20);

	int i = 0;
	for (i = 0; i < 20; i++)
	{
		printf("%d ", arr2[i]);
	}

	return 0;
}*/

//memcpy不用完成重叠的内存拷贝
/*void my_memcpy(void* dest, void* src, size_t num)
{
	void* ret = dest;
	int i = 0;
	assert(dest && src);
	while (num--)
	{
		*(char*)dest = *(char*)src;
		((char*)src)++;
		((char*)dest)++;
	}
	return ret;
}

int main()
{
	int arr1[] = { 1,2,3,4,5,6,7,8,9,10 };

	my_memcpy(arr1+2, arr1, 20);

	int i = 0;
	for (i = 0; i < 20; i++)
	{
		printf("%d ", arr1[i]);
	}

	return 0;
}*/

//memove函数
/*int main()
{
	int arr1[] = { 1,2,3,4,5,6,7,8,9,10 };
	
	memove(arr1 + 2, arr1, 20);
	
	int i = 0;
	for (i = 0; i < 10; i++)
	{
		printf("%d ", arr1[i]);
	}

	return 0;
}*/

#include<assert.h>
//memove的模拟实现
/*void* my_memove(void* dest, const void* src, size_t num)
{
	assert(dest && src);
	void* ret = dest;
	if (dest < src)
	{
		while (num--)
		{
			*(char*)dest = *(char*)src;
			dest = (char*)dest + 1;
			src = (char*)src + 1;
		}
	}
	else
	{
		while (num--)
		{
			*((char*)dest + num) = *((char*)src + num);
		}
	}

	return ret;
}

int main()
{
	int arr1[] = { 1,2,3,4,5,6,7,8,9,10 };

	my_memove(arr1+2, arr1, 5 * sizeof(int));

	int i = 0;
	for (i = 0; i < 10; i++)
	{
		printf("%d ", arr1[i]);
	}

	return 0;
}*/

//memset函数
/*int main()
{
	char arr[] = "hello world";
	memset(arr, 'x', 5);
	printf("%s\n", arr);

	return 0;
}*/

//memset函数的模拟实现
/*int main()
{
	int arr[] = { 0 };
	memset(arr, 0, 20);
	for (i = 0; i < 5; i++)
	{
		printf("%d ", arr[i]);
	}

	return 0;
}*/

//memcmp函数
int main()
{
	int arr1[] = { 1,2,3,4,5,6,7 };
	int arr2[] = { 1,2,3,4,8,8,8 };
	int ret = memcmp(arr1, arr2, 17);

	return 0;
}