#define _CRT_SECURE_NO_WARNINGS

#include<stdio.h>

//假设我们计算某年某月有多少天?
// 1  2  3  4  5  6  7  8  9  10 11 12 
// 31 28 31 30 31 30 31 31 30 31 30 31
//    29
int is_leap_year(int y);

int get_days_of_month(int y, int m)
{
	int days[] = { 0,31,28,31,30,31,30,31,31,30,31,30,31 };
	//        下标 0  1  2  3  4  5  6  7  8  9 10 11 12
	int day = days[m];
	if (is_leap_year(y) && m == 2)
		day += 1;

	return 0;
}

int is_leap_year(int y)
{
	if (((y % 4 == 0) && (y % 100 != 0)) || ( y % 400 == 0))
		return 1;//是闰年返回1
	else
		return 0; //不是闰年返回0
}

#include<stdbool.h>//bool类型头文件
/*_Bool is_leap_year(int y)
{
	if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 = 0))
		return true;//闰年返回真	
	else
		return false;//不是闰年返回假
}*/

int main()
{
	int year;
	int month;
	scanf("%d %d", &year, &month);
	int days = get_days_of_month(year,month);
	printf("%d\n",days);

	return 0;
}
//函数可以嵌套调用但是不可以嵌套定义

//函数的链式访问
int main()
{
	printf("%d", printf("%d", printf("%d", 43)));
	return 0;
}
//结果是4321，先读取最里面的个数再一个一个向外进行调用（链式访问）

//static修饰局部变量可以延长其生命周期
//extern可以声明外部的其他符号
//static修饰全局变量会打破extern声明外部符号，导致该符号只能在该源文件中使用