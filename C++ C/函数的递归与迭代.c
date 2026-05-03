#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<math.h>
#include<string.h>

//函数的递归
//接受一个整型值（无符号），按照顺序打印它的每一位
/*void print(unsigned int n)//print只是一个函数名，和printf不是一个东西
{
	if (n > 9)//如果把if(n > 9)删掉代码则会弹出Stack overflow，这是指栈溢出
	{
		print(n / 10);//如果把(n / 10)换成(n)则会死递归
	}
	printf("%d ", n % 10);
}

int main()
{
	unsigned int num = 0;
	
	scanf("%u", &num);
	print(num);

	return 0;
}*/

//编写函数不允许创建临时变量
//求字符串的长度
//模拟实现strlen

//int my_strlen(char str[])//参数部分写成数组形式
/*int my_strlen(char* str)//参数部分写成指针形式
{
	int count = 0;
	while (*str != '\0')//如果是if他就不回来了，不造成循环
	{
		count++;//计数，临时变量
		str++//找下一个字符
	}
	return count;
}*/

//递归求解不创建临时变量来求字符串长度
//my_strlen("abc");
//1+my_strlen("bc");
//1+1+my_strlen("c");
//1+1+1+my_strlen("");
//1+1+1+0

/*int my_strlen(char* str)
{
	if (*str != '\0')
		return 1 + my_strlen(str+1);//++有时会有副作用
	else
		return 0;
}

int main()
{
	char arr[] = "abc";//[a b c \0]
	//char*
	int len = my_strlen(arr);
	
	printf("%d\n", len);
	
	return 0;
}*/

//递归存在限制条件，当满足这个限制条件的时候，递归便不再继续
//每次递归调用之后越来越接近这个限制条件

//求n的阶乘

//递归实现
/*int fac(int n)
{
	if (n <= 1)
		return 1;
	else
		return n * fac(n - 1);
}*/

//迭代实现-非递归
/*int fac(int n)
{
	int i = 0;
	int ret = 1;
	for (i = 1; i <= n; i++)
	{
		ret *= i;
	}

	return ret;
}*/

/*int main()
{
	int n = 0;
	scanf("%d", &n);
	int ret = fac(n);
	printf("ret=%d\n", ret);
	return 0;
}*/

/*int main()
{
	int i = 0;
	int n = 0;
	int ret = 1;
	scanf("%d", &n);

	int sum = 0;

	for (i = 1; i <= n; i++)
	{
		ret *= i;
		sum += ret;
	}

	printf("%d\n", sum);
	
	return 0;
}*/

//求第n个斐波那契数
//斐波那契数列
//1 1 2 3 5 8 13 21 34 55 ...

/*int Fib(int n)
{
	if (n <= 2)
		return 1;
	else
		return Fib(n - 1) + Fib(n - 2);
}

int main()
{
	int n = 0;
	scanf("%d", &n);
	int ret = Fib(n);
	
	printf("%d\n", ret);

	return 0;
}

int main()
{



	return 0;
}*/