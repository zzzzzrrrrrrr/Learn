#define _CRT_SECURE_NO_WARNINGS//strcpy和scanf都需要这个来避免报错
#include<stdio.h>
#include<string.h>//memset需要这个头文件

//strcpy的学习运用
/*int main()
{
	char arr1[20] = { 0 };//arr1数组[20]给20个字符空间{ 0 }什么东西都没有
	char arr2[] = "114514";//arr2数组放一个114514

	strcpy(arr1,arr2);//strcpy把arr2的东西拷贝到arr1的字符空间里面

	printf("%s\n", arr1);//输出arr1字符空间内的东西

	return 0;
}*/

//memset的学习运用
/*int main()
{
	char arr[20] = "nknma";//arr内设置20字符空间空间里面有nknma
	memset(arr + 4, 'n', 1);//arr里面的字符中第五个字符变成n，1是变一个n
	printf("%s\n", arr);//输出最终的结果

	return 0;
}*/

//自定义函数
/*int get_max(int x, int y)
{
	return (x > y ? x : y );
}

int main()
{	
	int a = 0;
	int b = 0;
	scanf("%d %d" , &a , &b );
	//求较大值
	//函数的调用
	int m = get_max( a , b );//比较a和b的大小然后把结果赋值给m
	
	printf("%d\n", m );//输出结果
	return 0;
}*/

//写一个函数可以交换两个整形变量的内容

//形式参数
/*void Swap(int x, int y)
{
	int z = 0;
	z = x;
	x = y;
	y = z;
}*/

//
//当实参传递给形参的时候，形参是实参的一份临时拷贝
//对形参的修改不会影响实参
//
/*int main()
{
	int a = 0;
	int b = 0;
	scanf("%d %d",&a, &b);
	//交换
	printf("交换前:a=%d b=%d\n", a, b);
	//a和b是实参
	Swap(a, b);//交换a和b的值
	printf("交换后:a=%d b=%d\n", a, b);

	return 0;
}*/

//以上是错误示范，形参修改不影响实参导致a和b没有交换
//以下是正确例子

/*void Swap(int* px, int* py)
{
	int z = *px;//z=a
	*px = *py;//a=b
	*py = z;//b=z
}

int main()
{
	int a = 0;
	int b = 0;
	scanf("%d %d",&a, &b);
	//交换
	printf("交换前:a=%d b=%d\n", a, b);
	//a和b叫实参
	Swap(&a,&b);//交换a和b的值
	printf("交换后:a=%d b=%d\n", a, b);

	return 0;
}*/
